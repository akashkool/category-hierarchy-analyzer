namespace CategoryHierarchySolution.Models;

public class Category
{
    public int CategoryId { get; set; }
    public int ParentCategoryId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Keywords { get; set; } = string.Empty;
}