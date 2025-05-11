// Program.cs
using CategoryHierarchySolution;
using CategoryHierarchySolution.Services;

// Initialize service with category data
var service = new CategoryService(CategoryData.Categories);

// ---- Task 1 Example ----
Console.WriteLine("=== Task 1 Output ===");
Console.WriteLine(service.GetCategoryProperties(201));
// Output: ParentCategoryID=200, Name=Computer, Keywords=Teaching

Console.WriteLine(service.GetCategoryProperties(202));
// Output: ParentCategoryID=201, Name=Operating System, Keywords=Teaching

// ---- Task 2 Example ----
Console.WriteLine("\n=== Task 2 Output ===");
var level2 = service.GetCategoryIdsByLevel(2);
Console.WriteLine($"Level 2 Category IDs: {string.Join(", ", level2)}"); 
// Output: Level 2 Category IDs: 101, 102, 201

var level3 = service.GetCategoryIdsByLevel(3);
Console.WriteLine($"Level 3 Category IDs: {string.Join(", ", level3)}"); 
// Output: Level 3 Category IDs: 103, 109, 202
