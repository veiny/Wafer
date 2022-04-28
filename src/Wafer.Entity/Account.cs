using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wafer.Entity;
public class Account
{
    private AccountType type;
    private string accountcode;
    private string accountname;
    private string cncode;
    private int blancedirection;
    private bool status;

}
public class AccountType
{
    private int id;
    private string name;

    /// <summary>
    /// 科目类别
    /// 1.资产 2.负债 3.权益 4.成本 5.损益
    /// </summary>
    public int Id { get => id; set => id = value; }
    /// <summary>
    /// 科目类别名称
    /// </summary>
    public string Name { get => name; set => name = value; }
}
