# 📂 Category Hierarchy Solution

A C# (.NET 8) console application solving two problems with hierarchical category data:

1. Retrieve category details with inherited keywords.
2. List category IDs at a specified hierarchy level.

## 🧑‍💻 Author

**Akash Kool**  
.NET Full Stack Developer

## 🚀 Problem Statement

Given a category hierarchy with `CategoryId`, `ParentCategoryId`, `Name`, and `Keywords`, build functions to:

- Retrieve category properties (inherit keywords from ancestors if missing).
- Get category IDs at a specific hierarchy level.

### 🛠️ Features

#### ✅ Task 1 — Get Category Properties  
Given a category ID, return a string containing: `ParentCategoryID`, `Name`, and `Keywords` (inherited from the nearest ancestor if missing).

**Example**  
Input: `201`  
Output: `"ParentCategoryID=200, Name=Computer, Keywords=Teaching"`

#### ✅ Task 2 — Get Categories at N-th Level  
Given a level (N), return all category IDs at that level. (Root categories are at Level 1)

**Example**  
Input: `2`  
Output: `[101, 102, 201]`

## 🏗️ Project Structure

| Directory/File                          | Description           |
|------------------------------------------|-----------------------|
| `CategoryHierarchySolution/`             | Root project folder   |
| `CategoryHierarchySolution/Models/`      | Contains model files  |
| `CategoryHierarchySolution/Services/`    | Contains service files|
| `CategoryHierarchySolution/CategoryData.cs` | Category data file    |
| `CategoryHierarchySolution/Program.cs`   | Main entry file       |
| `CategoryHierarchySolution/CategoryHierarchySolution.csproj` | Project file |


## ⚙️ Technologies

- **C# 12**, **.NET 8** Console Application
- **LINQ** for data querying
- **Recursion** to traverse hierarchies

## 💻 How to Run

Ensure **.NET 8 SDK** is installed.  
Run the application using the following command:

```bash
dotnet run
```

## 📝 Sample Output

### Task 1 — Get Category Properties
```bash
ParentCategoryID=200, Name=Computer, Keywords=Teaching
ParentCategoryID=201, Name=Operating System, Keywords=Teaching
```
### Task 2 — Get Categories at N-th Level
```bash
Level 2 Category IDs: 101, 102, 201
Level 3 Category IDs: 103, 109, 202
```

## 🕰️ Time Taken

**1 hour 15 minutes**  
Including:
- Understanding requirements
- Designing clean, extensible code
- Writing and testing the solution

## 📌 Notes

- Modular, reusable code (CategoryService)
- Handles multi-root hierarchies
- Extensible for future features (e.g., API, UI)

## 📫 Contact

Feel free to reach out if you have any questions:  
**akashkool96@gmail.com**

## 🏆 Thank You



