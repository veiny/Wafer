using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wafer.Entity;

/// <summary>
/// 基本信息
/// </summary>
public class BaseInformation
{
    private string companyname;
    private string accountname;
    private string isbn;
    private string phone;
    private string trade;
    private int accountuseyear;
    private int accountusemonth;

    /// <summary>
    /// 公司名称
    /// </summary>
    public string Companyname { get => companyname; set => companyname = value; }
    /// <summary>
    /// 账套名称
    /// </summary>
    public string Accountname { get => accountname; set => accountname = value; }
    /// <summary>
    /// 行业
    /// </summary>
    public string Trade { get => trade; set => trade = value; }
    /// <summary>
    /// 账套启用年
    /// 2022
    /// </summary>
    public int AccountuseYear { get => accountuseyear; set => accountuseyear = value; }
    /// <summary>
    /// 账套启用月
    /// 4
    /// </summary>
    public int AccountuseMonth { get => accountusemonth; set => accountusemonth = value; }
    /// <summary>
    /// 社会统一信用代码
    /// </summary>
    public string ISBN { get => isbn; set => isbn = value; }
    /// <summary>
    /// 联系电话
    /// </summary>
    public string Phone { get => phone; set => phone = value; }
}
