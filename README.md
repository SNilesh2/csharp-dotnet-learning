# 🚀 C# & .NET Learning Journey

[![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet&logoColor=white)](#)
[![C#](https://img.shields.io/badge/C%23-Modern%20C%23-239120?logo=c-sharp&logoColor=white)](#)
[![IDE](https://img.shields.io/badge/IDE-Visual%20Studio%20Community-5C2D91?logo=visual-studio&logoColor=white)](#)
[![Platform](https://img.shields.io/badge/Platform-Windows-0078D6?logo=windows&logoColor=white)](#)

Welcome to my **C# and .NET learning journey** repository! This repository documents my hands-on practice, code experiments, and progressive mastery of C# and the .NET ecosystem using **Visual Studio Community**.

---

## 📌 Repository Overview

This repository is structured as modular practice projects, starting from basic syntax and fundamental programming constructs up to modern language features and clean architecture principles.

Each directory focuses on a distinct concept with runnable sample code and practical examples.

```text
csharp-dotnet-learning/
│
├── 01-HelloWorld/              # First C# program and console fundamentals
├── Text/                       # Strings, concatenation, and string interpolation
├── Numbers/                    # Arithmetic operations, operator precedence, and type limits
├── Branches And Loops/         # Conditional logic (if/else) and control flow
├── List Collections/           # Generic List<T>, modern collection expressions, and iteration
├── StringToNumber/             # Data type conversions using System.Convert
├── Tuple and Types/            # C# Tuples, value deconstruction, and Record types
├── Pattern Matching/           # Switch expressions, pattern matching, and raw string literals
├── Conditional Compilation/    # Preprocessor directives (#if, #define, DEBUG flags)
└── MyApp/                      # OOP fundamentals, Model-Service architecture, and clean code
```

---

## 📚 Curriculum & Topic Breakdown

| Module | Core Concepts Covered | Key Language Features |
| :--- | :--- | :--- |
| **[01-HelloWorld](./01-HelloWorld)** | Program entry points, standard output | `Console.WriteLine`, Top-level structure |
| **[Text](./Text)** | Text manipulation, string interpolation | `$"{name}"`, string formatting, `.Length` |
| **[Numbers](./Numbers)** | Math operations, precedence, numeric boundaries | `int`, `double`, `decimal`, `int.MaxValue` |
| **[Branches And Loops](./Branches%20And%20Loops)** | Flow control, boolean evaluations | `if`, `else`, logical operators `&&`, `\|\|` |
| **[List Collections](./List%20Collections)** | Dynamic arrays, collection manipulation | `List<T>`, Collection expressions `[...]`, `foreach` |
| **[StringToNumber](./StringToNumber)** | Safe type parsing and explicit conversions | `Convert.ToInt32`, `Convert.ToDecimal`, `Convert.ToDouble` |
| **[Tuple and Types](./Tuple%20and%20Types)** | Lightweight data structures, immutable records | `(X, Y)`, `public record Point(...)`, expression-bodied members |
| **[Pattern Matching](./Pattern%20Matching)** | Modern switch expressions, transaction parsing | `switch` expressions, tuple patterns, raw string literals `"""` |
| **[Conditional Compilation](./Conditional%20Compilation)** | Build configurations, preprocessor flags | `#define`, `#if DEBUG`, `#else`, `#endif` |
| **[MyApp](./MyApp)** | Object-Oriented Programming (OOP) & structuring | Models (`Product`), Services (`ProductService`), Separation of Concerns |

---

## 🛠️ Tools & Prerequisites

To explore and run the projects in this repository:

- **IDE**: [Visual Studio Community Edition](https://visualstudio.microsoft.com/vs/community/)
  - Workload: **.NET desktop development**
- **Runtime/SDK**: [.NET SDK (Version 10 / 9)](https://dotnet.microsoft.com/download)
- **Solution Format**: Modern Visual Studio XML Solution format (`.slnx`)

---

## ⚡ How to Run

### Method 1: Using Visual Studio Community (Recommended)

1. Clone or download this repository:
   ```bash
   git clone https://github.com/SNilesh2/csharp-dotnet-learning.git
   ```
2. Navigate to any project folder (e.g., `MyApp/` or `Pattern Matching/`).
3. Double-click the **`.slnx`** or **`.csproj`** file to open it in **Visual Studio Community**.
4. In Visual Studio, set the desired project as the **Startup Project**.
5. Press **`F5`** (Debug) or **`Ctrl + F5`** (Run without debugging) to execute.

### Method 2: Using the .NET CLI

You can also run any module directly from PowerShell or Terminal:

```bash
# Navigate to the project folder
cd "MyApp"

# Run the project
dotnet run
```

---

## 🌟 Key Highlights & Modern C# Features Used

- **Raw String Literals (`"""..."""`)**: Clean multi-line strings without escaping quotes (see [Pattern Matching](./Pattern%20Matching)).
- **Collection Expressions (`[...]`)**: Modern concise collection initialization syntax (see [List Collections](./List%20Collections)).
- **Positional Records**: Concise immutable data models with built-in equality and methods (see [Tuple and Types](./Tuple%20and%20Types)).
- **Switch Expressions & Tuple Matching**: Elegant and expressive control flow over traditional switch statements.
- **Clean Architecture & Separation of Concerns**: Isolating data definitions (`Models/`) from business logic (`Services/`) (see [MyApp](./MyApp)).

---

## 🗺️ Next Steps & Learning Roadmap

- [ ] Advanced LINQ (Language Integrated Query) queries and transformations
- [ ] Asynchronous programming (`async` / `await` and `Task`)
- [ ] Exception handling & custom exception types
- [ ] File I/O and JSON serialization (`System.Text.Json`)
- [ ] Unit testing with xUnit or NUnit
- [ ] Building web APIs with ASP.NET Core
- [ ] Relational databases with Entity Framework Core (EF Core)

---

## 👤 Author

- **GitHub**: [SNilesh2](https://github.com/SNilesh2)
- **Goal**: Documenting continuous progress and building strong foundations in C# and modern .NET development.

---
⭐ *Feel free to star this repository if you find this learning progression helpful!*
