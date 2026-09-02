\---

## 📦 The Eight Modules

|#|Module|What it does|
|:-:|-|-|
|1|🧠 Quiz Game|Multiple-choice questions with a running score|
|2|➗ Math Calculator|Add, subtract, multiply, divide|
|3|🎯 Number Guessing|Random target, limited attempts|
|4|🎵 Music Playlist|Browse and select songs|
|5|⚽ Random League|Draws random team matchups|
|6|🍕 Food Order|Pick items and total the bill|
|7|📝 Save Note|Writes user input to a real text file|
|8|📚 Stack Demo|Push, Pop and Peek, shown step by step|

## ✨ What It Does

A single `switch-case` menu routes to one of eight methods and returns to the menu when each
one finishes. Two modules go beyond the console: **Save Note** writes to disk, and
**Stack Demo** shows a real .NET data structure being used rather than described.

## 🧠 Concepts Practised

|Concept|Where it appears|
|-|-|
|Methods|One per module, keeping `Main` short|
|`switch-case`|Routing the main menu|
|Arrays|Quiz questions, playlist, team names|
|`Random`|Guessing game and league draw|
|`Stack`|Push / Pop / Peek demo|
|File operations|Save Note module|
|`while` / `for`|Menu loop and iteration|

## 🗺️ Possible Improvements

* \[ ] Quiz categories and more questions
* \[ ] Read the playlist from a file instead of an array
* \[ ] A Queue demo next to the Stack one
* \[ ] Carry a score across modules

## 🚀 Running It

**Visual Studio** — open `MiniGameAndUtility Center.sln` and press `F5`.

**.NET CLI** — from the repository root:

```bash
cd "MiniGameAndUtility Center"
dotnet run --project "MiniGameAndUtility Center"
```

## 📁 Files

```
MiniGameAndUtility Center/
├── README.md
├── MiniGameAndUtility Center.sln
└── MiniGameAndUtility Center/
    ├── MiniGameAndUtility Center.csproj
    └── Program.cs
```

\---



