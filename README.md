<h1 align="center">📚 C# Learning Journey</h1>

<p align="center">
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&amp;logo=c-sharp&amp;logoColor=white" alt="C#">
  <img src="https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&amp;logo=dotnet&amp;logoColor=white" alt=".NET">
  <img src="https://img.shields.io/badge/Visual%20Studio%202022-5C2D91?style=for-the-badge&amp;logo=visualstudio&amp;logoColor=white" alt="Visual Studio 2022">
  <img src="https://img.shields.io/badge/Projects-5-2EA043?style=for-the-badge" alt="5 projects">
</p>

<p align="center">
  Five C# console applications, built one after another while learning the language —<br>
  each one adding a topic the previous project did not cover.
</p>

---

## 📖 About This Repository

This is a **learning repository**, not a product. Each folder is a complete, runnable
Visual Studio console application written while working through C# fundamentals.

They are ordered by difficulty. The first project uses only variables, conditionals and a
loop. The last one pulls together methods, a data structure and file I/O. The fourth is
where object-oriented programming starts.

Every project folder has **its own README** explaining what it does and which concepts it
practises — open a folder to read it.

## 🗂️ The Projects

| # | Project | What it does | New topics it introduced |
|:---:|:---|:---|:---|
| 1 | [🍽️ **Canteen Order System**](./CanteenOrderSystem) | Take an order, calculate the total, apply a tiered discount, print the bill | Variables, `if`/`else`, `switch-case`, `while` |
| 2 | [🎯 **Lucky Number Game**](./LuckyNumberGame) | Guess a number in 7 tries with higher/lower hints, scoring and replay | Arrays, `Random`, `do-while`, `char`, `float`, `decimal` |
| 3 | [🎬 **Cinema Ticket Booking**](./CinemaTicketBookingSystem) | Draw a seat map, reserve seats, apply a group discount | Multidimensional arrays, nested loops, `Math`, `DateTime`, `bool` |
| 4 | [⚔️ **Game Character Management**](./GameCharacterManagementSystem) | Create Warriors and Mages, attack, defend, calculate power | **OOP** — classes, constructors, properties, inheritance, overloading |
| 5 | [🎮 **Mini Game & Utility Center**](./MiniGameAndUtility%20Center) | Eight mini programs behind one menu | Methods, `Stack`, file read/write |

## 📁 Repository Structure

Each project keeps its original Visual Studio layout — a `.sln` solution file next to a
folder holding the `.csproj` and the source:

```
csharp-journey/
│
├── CanteenOrderSystem/
│   ├── README.md
│   ├── CanteenOrderSystem.sln
│   └── CanteenOrderSystem/
│       ├── CanteenOrderSystem.csproj
│       └── Program.cs
│
├── LuckyNumberGame/
├── CinemaTicketBookingSystem/
├── GameCharacterManagementSystem/
├── MiniGameAndUtility Center/
│
├── .gitignore
└── README.md
```

## 🚀 Running a Project

**With Visual Studio** — open the project's `.sln` file and press `F5`.

**With the .NET CLI:**

```bash
git clone https://github.com/yasinkocakdev/csharp-journey.git
cd csharp-journey/CanteenOrderSystem
dotnet run --project CanteenOrderSystem
```

> Requires the [.NET SDK](https://dotnet.microsoft.com/download).
> Swap the folder name to run any of the other four.

## 🧭 Learning Path

| Stage | Topics | Where it was practised | Status |
|:---|:---|:---|:---:|
| **1. Fundamentals** | Variables, operators, `if`/`else`, `switch-case` | Canteen | ✅ |
| **2. Loops** | `for`, `while`, `do-while`, nested loops | Canteen, Lucky Number, Cinema | ✅ |
| **3. Arrays** | One-dimensional and multidimensional | Lucky Number, Cinema | ✅ |
| **4. Built-in classes** | `Random`, `Math`, `DateTime` | Lucky Number, Cinema | ✅ |
| **5. Methods** | Parameters, return values, `out`, overloading | Game Character, Mini Center | ✅ |
| **6. OOP** | Classes, constructors, properties, inheritance | Game Character | ✅ |
| **7. Data structures & files** | `Stack`, reading and writing files | Mini Center | ✅ |
| **8. Advanced OOP** | Interfaces, abstract classes, polymorphism | — | 🔜 |
| **9. Backend** | ASP.NET Core, Web API, databases | — | 🔜 |

## 🛠️ Built With

| Tool | Purpose |
|:---|:---|
| **C#** | Language |
| **.NET** | Runtime and SDK |
| **Visual Studio 2022** | IDE |
| **Git & GitHub** | Version control |

## 👤 Author

**Yasin Koçak** — [@yasinkocakdev](https://github.com/yasinkocakdev)

> These are learning projects, written to practise concepts rather than to ship.
> Feedback and suggestions are welcome.
