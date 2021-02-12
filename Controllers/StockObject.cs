using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManager.Controllers
{
    public class StockObject
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public string code { get; set; }
        public int maxAge { get; set; }
    }

    public class MajorDirectHolders
    {
        public List<object> holders { get; set; }
        public int maxAge { get; set; }
    }

    public class RegularMarketOpen
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class AverageDailyVolume3Month
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Volume24Hr
    {
    }

    public class RegularMarketDayHigh
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class AverageDailyVolume10Day
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class RegularMarketChange
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class RegularMarketPreviousClose
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class PreMarketPrice
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class PostMarketChange
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class PostMarketPrice
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class PreMarketChange
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class CirculatingSupply
    {
    }

    public class RegularMarketDayLow
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class PriceHint
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class RegularMarketPrice
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class RegularMarketVolume
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class OpenInterest
    {
    }

    public class MarketCap
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class PreMarketChangePercent
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class VolumeAllCurrencies
    {
    }

    public class StrikePrice
    {
    }

    public class PostMarketChangePercent
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class RegularMarketChangePercent
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class Price
    {
        public string quoteSourceName { get; set; }
        public RegularMarketOpen regularMarketOpen { get; set; }
        public AverageDailyVolume3Month averageDailyVolume3Month { get; set; }
        public string exchange { get; set; }
        public int regularMarketTime { get; set; }
        public Volume24Hr volume24Hr { get; set; }
        public RegularMarketDayHigh regularMarketDayHigh { get; set; }
        public string shortName { get; set; }
        public AverageDailyVolume10Day averageDailyVolume10Day { get; set; }
        public string longName { get; set; }
        public RegularMarketChange regularMarketChange { get; set; }
        public string currencySymbol { get; set; }
        public RegularMarketPreviousClose regularMarketPreviousClose { get; set; }
        public int postMarketTime { get; set; }
        public PreMarketPrice preMarketPrice { get; set; }
        public int preMarketTime { get; set; }
        public int exchangeDataDelayedBy { get; set; }
        public object toCurrency { get; set; }
        public PostMarketChange postMarketChange { get; set; }
        public PostMarketPrice postMarketPrice { get; set; }
        public string exchangeName { get; set; }
        public PreMarketChange preMarketChange { get; set; }
        public CirculatingSupply circulatingSupply { get; set; }
        public RegularMarketDayLow regularMarketDayLow { get; set; }
        public PriceHint priceHint { get; set; }
        public string currency { get; set; }
        public RegularMarketPrice regularMarketPrice { get; set; }
        public RegularMarketVolume regularMarketVolume { get; set; }
        public object lastMarket { get; set; }
        public string regularMarketSource { get; set; }
        public OpenInterest openInterest { get; set; }
        public string marketState { get; set; }
        public object underlyingSymbol { get; set; }
        public MarketCap marketCap { get; set; }
        public string quoteType { get; set; }
        public PreMarketChangePercent preMarketChangePercent { get; set; }
        public VolumeAllCurrencies volumeAllCurrencies { get; set; }
        public string postMarketSource { get; set; }
        public StrikePrice strikePrice { get; set; }
        public string symbol { get; set; }
        public PostMarketChangePercent postMarketChangePercent { get; set; }
        public string preMarketSource { get; set; }
        public int maxAge { get; set; }
        public object fromCurrency { get; set; }
        public RegularMarketChangePercent regularMarketChangePercent { get; set; }
    }

    public class ReportDate
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class PctHeld
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class Position
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Value
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }


    public class FundOwnership
    {
        public int maxAge { get; set; }
    }

    public class StartDate
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class Shares
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Transaction
    {
        public string filerName { get; set; }
        public string transactionText { get; set; }
        public string moneyText { get; set; }
        public string ownership { get; set; }
        public StartDate startDate { get; set; }
        public Value value { get; set; }
        public string filerRelation { get; set; }
        public Shares shares { get; set; }
        public string filerUrl { get; set; }
        public int maxAge { get; set; }
    }

    public class InsiderTransactions
    {
        public List<Transaction> transactions { get; set; }
        public int maxAge { get; set; }
    }

    public class LatestTransDate
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class PositionDirect
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class PositionDirectDate
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class Holder
    {
        public int maxAge { get; set; }
        public string name { get; set; }
        public string relation { get; set; }
        public string url { get; set; }
        public string transactionDescription { get; set; }
        public LatestTransDate latestTransDate { get; set; }
        public PositionDirect positionDirect { get; set; }
        public PositionDirectDate positionDirectDate { get; set; }
    }

    public class InsiderHolders
    {
        public List<Holder> holders { get; set; }
        public int maxAge { get; set; }
    }

    public class NetPercentInsiderShares
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class NetInfoCount
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class TotalInsiderShares
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class BuyInfoShares
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class BuyPercentInsiderShares
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class SellInfoCount
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class SellInfoShares
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class SellPercentInsiderShares
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class BuyInfoCount
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class NetInfoShares
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class NetSharePurchaseActivity
    {
        public string period { get; set; }
        public NetPercentInsiderShares netPercentInsiderShares { get; set; }
        public NetInfoCount netInfoCount { get; set; }
        public TotalInsiderShares totalInsiderShares { get; set; }
        public BuyInfoShares buyInfoShares { get; set; }
        public BuyPercentInsiderShares buyPercentInsiderShares { get; set; }
        public SellInfoCount sellInfoCount { get; set; }
        public SellInfoShares sellInfoShares { get; set; }
        public SellPercentInsiderShares sellPercentInsiderShares { get; set; }
        public int maxAge { get; set; }
        public BuyInfoCount buyInfoCount { get; set; }
        public NetInfoShares netInfoShares { get; set; }
    }

    public class InsidersPercentHeld
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class InstitutionsPercentHeld
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class InstitutionsFloatPercentHeld
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class InstitutionsCount
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class MajorHoldersBreakdown
    {
        public int maxAge { get; set; }
        public InsidersPercentHeld insidersPercentHeld { get; set; }
        public InstitutionsPercentHeld institutionsPercentHeld { get; set; }
        public InstitutionsFloatPercentHeld institutionsFloatPercentHeld { get; set; }
        public InstitutionsCount institutionsCount { get; set; }
    }

    public class QuoteType
    {
        public string exchange { get; set; }
        public string shortName { get; set; }
        public string longName { get; set; }
        public string exchangeTimezoneName { get; set; }
        public string exchangeTimezoneShortName { get; set; }
        public bool isEsgPopulated { get; set; }
        public string gmtOffSetMilliseconds { get; set; }
        public string quoteType { get; set; }
        public string symbol { get; set; }
        public string messageBoardId { get; set; }
        public string market { get; set; }
    }

    public class InstitutionOwnership
    {
        public int maxAge { get; set; }
    }

    public class PreviousClose
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class TwoHundredDayAverage
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class TrailingAnnualDividendYield
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class PayoutRatio
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class NavPrice
    {
    }

    public class TotalAssets
    {
    }

    public class FiftyDayAverage
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class TrailingAnnualDividendRate
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class Open
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class AverageVolume10days
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class ExpireDate
    {
    }

    public class Yield
    {
    }

    public class DividendRate
    {
    }

    public class ExDividendDate
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class Beta
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class TrailingPE
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class MaxSupply
    {
    }

    public class AverageVolume
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class PriceToSalesTrailing12Months
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class DayLow
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class Ask
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class YtdReturn
    {
    }

    public class AskSize
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Volume
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class FiftyTwoWeekHigh
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class ForwardPE
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class FiveYearAvgDividendYield
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class FiftyTwoWeekLow
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class Bid
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class DividendYield
    {
    }

    public class BidSize
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class DayHigh
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class SummaryDetail
    {
        public PreviousClose previousClose { get; set; }
        public RegularMarketOpen regularMarketOpen { get; set; }
        public TwoHundredDayAverage twoHundredDayAverage { get; set; }
        public TrailingAnnualDividendYield trailingAnnualDividendYield { get; set; }
        public PayoutRatio payoutRatio { get; set; }
        public Volume24Hr volume24Hr { get; set; }
        public RegularMarketDayHigh regularMarketDayHigh { get; set; }
        public NavPrice navPrice { get; set; }
        public AverageDailyVolume10Day averageDailyVolume10Day { get; set; }
        public TotalAssets totalAssets { get; set; }
        public RegularMarketPreviousClose regularMarketPreviousClose { get; set; }
        public FiftyDayAverage fiftyDayAverage { get; set; }
        public TrailingAnnualDividendRate trailingAnnualDividendRate { get; set; }
        public Open open { get; set; }
        public object toCurrency { get; set; }
        public AverageVolume10days averageVolume10days { get; set; }
        public ExpireDate expireDate { get; set; }
        public Yield yield { get; set; }
        public object algorithm { get; set; }
        public DividendRate dividendRate { get; set; }
        public ExDividendDate exDividendDate { get; set; }
        public Beta beta { get; set; }
        public CirculatingSupply circulatingSupply { get; set; }
        public StartDate startDate { get; set; }
        public RegularMarketDayLow regularMarketDayLow { get; set; }
        public PriceHint priceHint { get; set; }
        public string currency { get; set; }
        public TrailingPE trailingPE { get; set; }
        public RegularMarketVolume regularMarketVolume { get; set; }
        public object lastMarket { get; set; }
        public MaxSupply maxSupply { get; set; }
        public OpenInterest openInterest { get; set; }
        public MarketCap marketCap { get; set; }
        public VolumeAllCurrencies volumeAllCurrencies { get; set; }
        public StrikePrice strikePrice { get; set; }
        public AverageVolume averageVolume { get; set; }
        public PriceToSalesTrailing12Months priceToSalesTrailing12Months { get; set; }
        public DayLow dayLow { get; set; }
        public Ask ask { get; set; }
        public YtdReturn ytdReturn { get; set; }
        public AskSize askSize { get; set; }
        public Volume volume { get; set; }
        public FiftyTwoWeekHigh fiftyTwoWeekHigh { get; set; }
        public ForwardPE forwardPE { get; set; }
        public int maxAge { get; set; }
        public object fromCurrency { get; set; }
        public FiveYearAvgDividendYield fiveYearAvgDividendYield { get; set; }
        public FiftyTwoWeekLow fiftyTwoWeekLow { get; set; }
        public Bid bid { get; set; }
        public bool tradeable { get; set; }
        public DividendYield dividendYield { get; set; }
        public BidSize bidSize { get; set; }
        public DayHigh dayHigh { get; set; }
    }

    public class PageViews
    {
        public string shortTermTrend { get; set; }
        public string midTermTrend { get; set; }
        public string longTermTrend { get; set; }
        public int maxAge { get; set; }
    }

    public class RegularMarketTime
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class FiftyTwoWeekRange
    {
        public string raw { get; set; }
        public string fmt { get; set; }
    }

    public class SharesOutstanding
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class FiftyTwoWeekHighChange
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class FiftyTwoWeekLowChange
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class FiftyTwoWeekLowChangePercent
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class RegularMarketDayRange
    {
        public string raw { get; set; }
        public string fmt { get; set; }
    }

    public class FiftyTwoWeekHighChangePercent
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class GM
    {
        public int sourceInterval { get; set; }
        public string quoteSourceName { get; set; }
        public RegularMarketOpen regularMarketOpen { get; set; }
        public string exchange { get; set; }
        public RegularMarketTime regularMarketTime { get; set; }
        public FiftyTwoWeekRange fiftyTwoWeekRange { get; set; }
        public SharesOutstanding sharesOutstanding { get; set; }
        public RegularMarketDayHigh regularMarketDayHigh { get; set; }
        public string shortName { get; set; }
        public string longName { get; set; }
        public string exchangeTimezoneName { get; set; }
        public RegularMarketChange regularMarketChange { get; set; }
        public RegularMarketPreviousClose regularMarketPreviousClose { get; set; }
        public FiftyTwoWeekHighChange fiftyTwoWeekHighChange { get; set; }
        public string exchangeTimezoneShortName { get; set; }
        public FiftyTwoWeekLowChange fiftyTwoWeekLowChange { get; set; }
        public int exchangeDataDelayedBy { get; set; }
        public RegularMarketDayLow regularMarketDayLow { get; set; }
        public int priceHint { get; set; }
        public string currency { get; set; }
        public RegularMarketPrice regularMarketPrice { get; set; }
        public RegularMarketVolume regularMarketVolume { get; set; }
        public bool isLoading { get; set; }
        public bool triggerable { get; set; }
        public int gmtOffSetMilliseconds { get; set; }
        public long firstTradeDateMilliseconds { get; set; }
        public string region { get; set; }
        public string marketState { get; set; }
        public MarketCap marketCap { get; set; }
        public string quoteType { get; set; }
        public bool invalid { get; set; }
        public string symbol { get; set; }
        public string language { get; set; }
        public FiftyTwoWeekLowChangePercent fiftyTwoWeekLowChangePercent { get; set; }
        public RegularMarketDayRange regularMarketDayRange { get; set; }
        public string messageBoardId { get; set; }
        public FiftyTwoWeekHigh fiftyTwoWeekHigh { get; set; }
        public FiftyTwoWeekHighChangePercent fiftyTwoWeekHighChangePercent { get; set; }
        public string uuid { get; set; }
        public string market { get; set; }
        public FiftyTwoWeekLow fiftyTwoWeekLow { get; set; }
        public RegularMarketChangePercent regularMarketChangePercent { get; set; }
        public string fullExchangeName { get; set; }
        public bool tradeable { get; set; }
    }

    public class QuoteData
    {
        public GM GM { get; set; }
    }

    public class MktmData
    {
    }

    public class Root
    {
        public StockObject financialsTemplate { get; set; }
        public MajorDirectHolders majorDirectHolders { get; set; }
        public Price price { get; set; }
        public FundOwnership fundOwnership { get; set; }
        public InsiderTransactions insiderTransactions { get; set; }
        public InsiderHolders insiderHolders { get; set; }
        public NetSharePurchaseActivity netSharePurchaseActivity { get; set; }
        public MajorHoldersBreakdown majorHoldersBreakdown { get; set; }
        public QuoteType quoteType { get; set; }
        public SummaryDetail summaryDetail { get; set; }
        public string symbol { get; set; }
        public PageViews pageViews { get; set; }
        public QuoteData quoteData { get; set; }
        public MktmData mktmData { get; set; }
    }
}
