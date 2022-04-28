using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wafer.Entity;

public class Log
{
    private int userid;
    private string username;
    private string logtype;
    private string mode;
    private string message;
    private DateTime date;
    /// <summary>
    /// 用户id
    /// </summary>
    public int Userid { get => userid; set => userid = value; }
    /// <summary>
    /// 用户名称
    /// </summary>
    public string Username { get => username; set => username = value; }
    /// <summary>
    /// 日志类型
    /// </summary>
    public string Logtype { get => logtype; set => logtype = value; }
    /// <summary>
    /// 模块
    /// </summary>
    public string Mode { get => mode; set => mode = value; }
    /// <summary>
    /// 日志内容
    /// </summary>
    public string Message { get => message; set => message = value; }
    /// <summary>
    /// 操作时间
    /// </summary>
    public DateTime Date { get => date; set => date = value; }
}
