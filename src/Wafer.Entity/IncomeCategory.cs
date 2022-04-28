namespace Wafer.Entity;

public class IncomeCategory
{
    private int id;
    private string name;
    private string category;
    /// <summary>
    /// 编码 autoid
    /// </summary>
    public int Id { get => id; set => id = value; }
    /// <summary>
    /// 名称
    /// eg.机械费
    /// </summary>
    public string Name { get => name; set => name = value; }
    /// <summary>
    /// 类别
    /// eg.支出/收入
    /// </summary>
    public string Category { get => category; set => category = value; }
}
