using System;
namespace Wafer.Entity;
/// <summary>
/// 日记账
/// 银行日记账/现金日记账
/// </summary>
public class Journal
{
    private string id;
    private string sn;
    private DateTime date;
    private string summary;
    private IncomeCategory incomecategory;
    private Department department;
    private decimal lend;
    private decimal loan;
    private decimal balance;
    private int voucherid;
    private string reciprocalaccountnumber;
    private Payments payments;
    private int billid;
    private string notes;

    /// <summary>
    /// 日记账ID
    /// 20220420230352663
    /// </summary>
    public string Id { get => id; set => id = value; }
    /// <summary>
    /// 交易流水号
    /// 2-001-20220420-1
    /// 2-001-20220420-2
    /// </summary>
    public string Sn { get => sn; set => sn = value; }
    /// <summary>
    /// 交易日期
    /// </summary>
    public DateTime Date { get => date; set => date = value; }
    /// <summary>
    /// 摘要
    /// </summary>
    public string Summary { get => summary; set => summary = value; }
    /// <summary>
    /// 收支类别
    /// </summary>
    public IncomeCategory Incomecategory { get => incomecategory; set => incomecategory = value; }
    /// <summary>
    /// 往来单位
    /// </summary>
    public Department Department { get => department; set => department = value; }
    /// <summary>
    /// 收入(借方)
    /// </summary>
    public decimal Lend { get => lend; set => lend = value; }
    /// <summary>
    /// 支出(贷方)
    /// </summary>
    public decimal Loan { get => loan; set => loan = value; }
    /// <summary>
    /// 余额
    /// </summary>
    public decimal Balance { get => balance; set => balance = value; }
    /// <summary>
    /// 关联凭证
    /// </summary>
    public int Voucherid { get => voucherid; set => voucherid = value; }
    /// <summary>
    /// 往来账号
    /// </summary>
    public string Reciprocalaccountnumber { get => reciprocalaccountnumber; set => reciprocalaccountnumber = value; }
    /// <summary>
    /// 结算方式
    /// </summary>
    public Payments Payments { get => payments; set => payments = value; }
    /// <summary>
    /// 票据号
    /// </summary>
    public int Billid { get => billid; set => billid = value; }
    /// <summary>
    /// 备注
    /// </summary>
    public string Notes { get => notes; set => notes = value; }
}
