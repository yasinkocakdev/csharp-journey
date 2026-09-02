\---

## 🎮 How It Plays

|Step|What happens|
|:-:|-|
|1|The program picks a secret number between 1 and 100|
|2|The player enters a guess|
|3|The program replies whether the target is higher or lower|
|4|Numbers already tried are flagged, so no attempt is wasted|
|5|Winning within 7 tries earns a score and a prize|
|6|The player can start a new round without restarting the program|

## ✨ What It Does

Beyond the basic guessing loop, the game keeps a **history array** of every guess, detects
repeats, and calculates a score that depends on how few attempts were needed.

## 🧠 Concepts Practised

|Concept|Where it appears|
|-|-|
|`Random`|Generating the secret number|
|Arrays|Storing the guess history|
|`while` / `do-while`|Main game loop and the replay prompt|
|`for`|Scanning previous guesses for repeats|
|`char`|Reading the yes/no replay answer|
|`float`, `decimal`|Score and prize calculation|
|`if` / `else`|Higher / lower comparison|

## 🗺️ Possible Improvements

* \[ ] Difficulty levels that change the range and attempt count
* \[ ] A high-score table that survives between runs
* \[ ] Coloured console feedback for hot and cold guesses

## 🚀 Running It

**Visual Studio** — open `LuckyNumberGame.sln` and press `F5`.

**.NET CLI** — from the repository root:

```bash
cd "LuckyNumberGame"
dotnet run --project "LuckyNumberGame"
```

## 📁 Files

```
LuckyNumberGame/
├── README.md
├── LuckyNumberGame.sln
└── LuckyNumberGame/
    ├── LuckyNumberGame.csproj
    └── Program.cs
```

\---



