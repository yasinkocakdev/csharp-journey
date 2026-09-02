\---

## 🧬 The Two Classes

### 🛡️ Warrior

|Member|Purpose|
|-|-|
|Health, Level, Armor|Core stats|
|`Attack()`|Offensive action|
|`Defend()`|Damage reduction|
|`CalculatePower()`|Derived from armor and level|

### 🔮 Mage

|Member|Purpose|
|-|-|
|Health, Level, Mana|Core stats|
|`CastSpell()`|Consumes mana|
|`CalculatePower()`|Derived from mana and level|

## ✨ What It Does

Characters are created through **constructors**, their stats are exposed through
**properties** with `get` / `set`, and shared behaviour lives in a base class the two types
**inherit** from. `Attack()` exists in more than one form — the same name, different
parameters — which is **method overloading**.

## 🧠 OOP Concepts Practised

|Concept|Where it appears|
|-|-|
|Classes \& objects|`Warrior`, `Mage`|
|Constructors|Creating a character with starting stats|
|Properties (`get` / `set`)|Health, Level, Armor, Mana|
|Methods \& parameters|Attack, Defend, CastSpell|
|Return values|Power calculation|
|Method overloading|Several `Attack()` signatures|
|Inheritance|Shared character behaviour in a base class|

## 🗺️ Possible Improvements

* \[ ] An `Archer` class to prove the base class generalises
* \[ ] A turn-based battle between two characters
* \[ ] An interface for shared abilities
* \[ ] Experience points and levelling up

## 🚀 Running It

**Visual Studio** — open `GameCharacterManagementSystem.sln` and press `F5`.

**.NET CLI** — from the repository root:

```bash
cd "GameCharacterManagementSystem"
dotnet run --project "GameCharacterManagementSystem"
```

## 📁 Files

```
GameCharacterManagementSystem/
├── README.md
├── GameCharacterManagementSystem.sln
└── GameCharacterManagementSystem/
    ├── GameCharacterManagementSystem.csproj
    └── Program.cs
```

\---



