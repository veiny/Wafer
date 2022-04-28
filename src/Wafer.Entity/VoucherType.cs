namespace Wafer.Entity;

public class VoucherType
{
    private string vouchercode;
    private string vouchertitle;
    private bool isdefault;
    /// <summary>
    /// 凭证字
    /// 记/收/付/转
    /// </summary>
    public string Vouchercode { get => vouchercode; set => vouchercode = value; }
    /// <summary>
    /// 打印标题
    /// 记账凭证/收款凭证/付款凭证/转账凭证
    /// </summary>
    public string VoucherTitle { get => vouchertitle; set => vouchertitle = value; }
    /// <summary>
    /// 是否默认,只有一个
    /// </summary>
    public bool Isdefault { get => isdefault; set => isdefault = value; }
}
