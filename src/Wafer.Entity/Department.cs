namespace Wafer.Entity;

/// <summary>
/// 往来单位
/// </summary>
public class Department
{
    private int id;
    private DepartmentType departmenttype;
    private string name;
    private string description;

    /// <summary>
    /// 往来单位id
    /// </summary>
    public int Id { get => id; set => id = value; }
    /// <summary>
    /// 往来单位类型
    /// 客户/供应商/职员/部门
    /// </summary>
    public DepartmentType Departmenttype { get => departmenttype; set => departmenttype = value; }
    /// <summary>
    /// 名称
    /// </summary>
    public string Name { get => name; set => name = value; }
    /// <summary>
    /// 备注
    /// </summary>
    public string Description { get => description; set => description = value; }
}
/// <summary>
/// 往来单位类型
/// 客户/供应商/资源/部门
/// </summary>
public class DepartmentType
{
    private int typeid;
    private string name;
    /// <summary>
    /// 单位类型id
    /// </summary>
    public int Typeid { get => typeid; set => typeid = value; }
    /// <summary>
    /// 名称
    /// </summary>
    public string Name { get => name; set => name = value; }
}
