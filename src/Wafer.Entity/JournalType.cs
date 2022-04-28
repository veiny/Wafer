namespace Wafer.Entity;

/// <summary>
/// 现金日记账/银行日记账 账户类别
/// </summary>
public class JournalType
{
    private int uid;
    private string journaltype;
    private string name;
    private string cardnumber;
    private Currency currency;
    private int accountscode;

    /// <summary>
    /// 编码,自动增长
    /// </summary>
    public int Uid { get => uid; set => uid = value; }
    /// <summary>
    /// 账户类型
    /// 现金/银行存款
    /// </summary>
    public string Journaltype { get => journaltype; set => journaltype = value; }
    /// <summary>
    /// 账户名称
    /// 现金
    /// 工商银行/建设银行
    /// </summary>
    public string Name { get => name; set => name = value; }
    /// <summary>
    /// 账号
    /// </summary>
    public string Cardnumber { get => cardnumber; set => cardnumber = value; }
    /// <summary>
    /// 币别
    /// </summary>
    public Currency Currency { get => currency; set => currency = value; }
    /// <summary>
    /// 会计科目编码
    /// 现金1001
    /// 银行 1002
    /// </summary>
    public int Accountscode { get => accountscode; set => accountscode = value; }
}