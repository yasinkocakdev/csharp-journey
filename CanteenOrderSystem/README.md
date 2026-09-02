\---

## ✨ What It Does

The program greets the user by name, shows a product menu, and keeps accepting items until
the user is done. It then totals the order, works out which discount band applies, and
prints a final bill with the item count.

## 💸 Discount Bands

|Order total|Discount|Final amount|
|-|:-:|-|
|0 – 250 TL|—|Full price|
|250 – 500 TL|**5%**|95% of total|
|Over 500 TL|**10%**|90% of total|

## 🧠 Concepts Practised

|Concept|Where it appears|
|-|-|
|`string`, `int`, `double`|User name, quantities, prices|
|Arithmetic operators|Line totals, discount, final bill|
|`if` / `else`|Choosing the discount band|
|`switch-case`|Menu and product selection|
|`while` loop|Keeping the order open for more items|
|`Console` I/O|Reading input, printing the bill|

## 🗺️ Possible Improvements

* \[ ] Reject invalid product codes instead of accepting them
* \[ ] Remove an item from a running order
* \[ ] Write the receipt to a text file
* \[ ] Load the product list from a file rather than hard-coding it

## 🚀 Running It

**Visual Studio** — open `CanteenOrderSystem.sln` and press `F5`.

**.NET CLI** — from the repository root:

```bash
cd "CanteenOrderSystem"
dotnet run --project "CanteenOrderSystem"
```

## 📁 Files

```
CanteenOrderSystem/
├── README.md
├── CanteenOrderSystem.sln
└── CanteenOrderSystem/
    ├── CanteenOrderSystem.csproj
    └── Program.cs
```

