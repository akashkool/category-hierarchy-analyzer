using CategoryHierarchySolution.Models;

namespace CategoryHierarchySolution.Services;

public class CategoryService
{
    private readonly Dictionary<int, Category> _categoryMap;

    public CategoryService(IEnumerable<Category> categories)
    {
        _categoryMap = categories.ToDictionary(c => c.CategoryId);
    }

    // Task 1: Get Category Properties String
    public string GetCategoryProperties(int categoryId)
    {
        if (!_categoryMap.TryGetValue(categoryId, out var category))
            throw new ArgumentException($"Category ID {categoryId} not found.");

        var keywords = category.Keywords;
        var parentId = category.ParentCategoryId;

        while (string.IsNullOrWhiteSpace(keywords) && parentId != -1)
        {
            if (!_categoryMap.TryGetValue(parentId, out var parent))
                break;

            keywords = parent.Keywords;
            parentId = parent.ParentCategoryId;
        }

        return $"ParentCategoryID={category.ParentCategoryId}, Name={category.Name}, Keywords={keywords}";
    }

    // Task 2: Get Category IDs by N-th Level
    public List<int> GetCategoryIdsByLevel(int level)
    {
        var result = new List<int>();
        var levelMap = new Dictionary<int, int>(); // categoryId -> level

        void AssignLevel(int categoryId, int currentLevel)
        {
            levelMap[categoryId] = currentLevel;

            foreach (var child in _categoryMap.Values.Where(c => c.ParentCategoryId == categoryId))
            {
                AssignLevel(child.CategoryId, currentLevel + 1);
            }
        }

        // Start with roots (ParentCategoryId = -1)
        foreach (var root in _categoryMap.Values.Where(c => c.ParentCategoryId == -1))
        {
            AssignLevel(root.CategoryId, 1);
        }

        result = levelMap.Where(kvp => kvp.Value == level).Select(kvp => kvp.Key).ToList();
        return result;
    }
}
