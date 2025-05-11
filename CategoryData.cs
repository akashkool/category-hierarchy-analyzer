using CategoryHierarchySolution.Models;

namespace CategoryHierarchySolution;

public static class CategoryData
{
    public static List<Category> Categories => new()
    {
        new Category { CategoryId = 100, ParentCategoryId = -1, Name = "Business", Keywords = "Money" },
        new Category { CategoryId = 200, ParentCategoryId = -1, Name = "Tutoring", Keywords = "Teaching" },
        new Category { CategoryId = 101, ParentCategoryId = 100, Name = "Accounting", Keywords = "Taxes" },
        new Category { CategoryId = 102, ParentCategoryId = 100, Name = "Taxation", Keywords = "" },
        new Category { CategoryId = 201, ParentCategoryId = 200, Name = "Computer", Keywords = "" },
        new Category { CategoryId = 103, ParentCategoryId = 101, Name = "Corporate Tax", Keywords = "" },
        new Category { CategoryId = 202, ParentCategoryId = 201, Name = "Operating System", Keywords = "" },
        new Category { CategoryId = 109, ParentCategoryId = 101, Name = "Small Business Tax", Keywords = "" },
    };
}
