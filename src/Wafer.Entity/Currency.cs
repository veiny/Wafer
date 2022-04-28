namespace Wafer.Entity;
/// <summary>
/// 币别
/// </summary>
public class Currency
{
    private string currencyCode;
    private string currencyName;
    private double rate;
    private bool basecurrency;
    private string currencyDescription;
    /// <summary>
    /// 编码
    /// eg.RMB
    /// </summary>
    public string CurrencyCode { get => currencyCode; set => currencyCode = value; }
    /// <summary>
    /// 描述
    /// </summary>
    public string CurrencyDescription { get => currencyDescription; set => currencyDescription = value; }
    /// <summary>
    /// 币别名称
    /// eg.人民币
    /// </summary>
    public string CurrencyName { get => currencyName; set => currencyName = value; }
    /// <summary>
    /// 汇率
    /// 默认 本币位为1.0000
    /// </summary>
    public double Rate { get => rate; set => rate = value; }
    /// <summary>
    /// 是否本币位
    /// 默认 true
    /// </summary>
    public bool Basecurrency { get => basecurrency; set => basecurrency = value; }
}
