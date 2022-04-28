namespace Wafer.Entity;

/// <summary>
/// 结算方式
/// </summary>
public class Payments
{
    private int id;
    private string name;

    /// <summary>
    /// 结算方式id
    /// </summary>
    public int Id { get => id; set => id = value; }
    /// <summary>
    /// 结算方式名称
    /// eg.现金/银行汇款/支票/电汇/银行承兑汇票/信用证
    /// </summary>
    public string Name { get => name; set => name = value; }
}
