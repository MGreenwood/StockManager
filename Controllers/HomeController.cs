using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StockManager.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Http;
using Newtonsoft.Json;

namespace StockManager.Controllers
{
    public class HomeController : Controller
    {
        public static bool isWorking = false;
        const string CONNECTION_STRING = "Server=tcp:osam.database.windows.net,1433;Initial Catalog=SampleProject;Persist Security Info=False;User ID=mgreenwood.dev;Password=SecurePasswordHere1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private readonly ILogger<HomeController> _logger;

        static List<Customer> users = new List<Customer>(); 

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // connect to db
            SqlConnection cnn = Connect();
            try
            {
                cnn.Open();
                string sql = "SELECT * FROM Users ORDER BY LastName";
                SqlDataReader reader = ExecuteRead(sql, cnn);
                if (reader != null && users.Count == 0)
                {
                    while (reader.Read()) // build list of users
                    {
                        users.Add(new Customer((int)reader.GetValue(0), (string)reader.GetValue(1), (string)reader.GetValue(2)));
                    }
                    cnn.Close();
                }
            }
            catch { // TODO
            }

            return View(users);
        }

        public async Task<IActionResult> UserView(int custID)
        {
            SqlConnection cnn = Connect();
            List<Security> securities = new List<Security>();
            int listID = users.FindIndex(cust => cust.id == custID);

            if (users.Count < custID || listID == -1) // either user not in db or invalid url param
                return StatusCode(404, "User not found");

            ViewBag.name = $"{users[listID].fname} {users[listID].lname}";

            try
            {
                cnn.Open();
                string sql = $"SELECT * FROM Securities WHERE PersonID = {custID} ORDER BY Ticker"; 
                SqlDataReader reader = ExecuteRead(sql, cnn);

                if(reader != null)
                {
                    while (reader.Read())
                    {
                        securities.Add(new Security((string)reader.GetValue(0), (int)reader.GetValue(2), (decimal)reader.GetValue(3), 0));
                    }
                }
                else
                {
                    // error handling TODO
                }

                cnn.Close();
            }
            catch { // TODO
            }

            isWorking = true;
            return View(await GetStocks(securities));
        }

        SqlDataReader ExecuteRead(string sql, SqlConnection cnn)
        {
            try
            {
                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataReader reader = command.ExecuteReader();

                return reader;
            }
            catch { // TODO 
            }

            return null;
        }

        SqlConnection Connect()
        {
            SqlConnection cnn;
            cnn = new SqlConnection(CONNECTION_STRING);

            return cnn;
        }

        public class Customer
        {
            public int id;
            public string fname, lname;
            
            public Customer(int idIn, string fn, string ln)
            {
                id = idIn;
                fname = fn;
                lname = ln;
            }
        }

        public class Security
        {
            public string ticker;
            public int numShares;
            public decimal purchasePrice;
            public decimal currentPrice;

            public Security(string tick, int num, decimal pp, decimal curr)
            {
                ticker = tick;
                numShares = num;
                purchasePrice = pp;
                currentPrice = curr;
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        async Task<List<Security>> GetStocks(List<Security> securities)
        {
            List<StockObject> stockObjects = new List<StockObject>();
            foreach(Security sec in securities)
            {
                Root ob = await GetStockData(sec.ticker);
                sec.currentPrice = (decimal)ob.price.regularMarketPrice.raw;
            }

            isWorking = false;
            return securities;
        }

        async Task<Root> GetStockData(string ticker)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://apidojo-yahoo-finance-v1.p.rapidapi.com/stock/v2/get-holders?symbol={ticker}&region=US"),
                Headers =
                {
                    { "x-rapidapi-key", "128a68023fmsh302ad26c7d7ab9ep103a17jsn1cd1642702b5" },
                    { "x-rapidapi-host", "apidojo-yahoo-finance-v1.p.rapidapi.com" },
                },
            };
            using (var response = client.SendAsync(request))
            {
                var body = await response.Result.Content.ReadAsStringAsync();
                Root ob =  JsonConvert.DeserializeObject<Root>(body);
                return ob;
            }
        }
    }
}
