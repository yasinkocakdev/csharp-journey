\---

## 🪑 The Seat Map

The hall is **5 rows × 6 seats = 30 seats**, held in a two-dimensional array and drawn with
nested loops.

|Symbol|Meaning|
|:-:|-|
|`\[O]`|Available|
|`\[X]`|Reserved|

## ✨ What It Does

The seat map is redrawn after every booking, so the user always sees the current state.
Attempting to book a taken seat is rejected. Each booking is stamped with the date and time.

## 💸 Group Discount

> Booking \*\*more than 3 tickets\*\* in one transaction applies a \*\*10% discount\*\* to the total.

## 🧠 Concepts Practised

|Concept|Where it appears|
|-|-|
|Multidimensional arrays|The 5×6 seat grid|
|Nested loops|Drawing the seat map row by row|
|`bool`|Seat availability state|
|`byte`|Row and seat numbers|
|`Math`|Rounding the discounted total|
|`DateTime`|Booking timestamp|
|Console colours|Distinguishing free from reserved seats|

## 🗺️ Possible Improvements

* \[ ] Cancel an existing reservation
* \[ ] More than one screening time
* \[ ] Different prices per row
* \[ ] Keep bookings between runs

## 🚀 Running It

**Visual Studio** — open `CinemaTicketBookingSystem.sln` and press `F5`.

**.NET CLI** — from the repository root:

```bash
cd "CinemaTicketBookingSystem"
dotnet run --project "CinemaTicketBookingSystem"
```

## 📁 Files

```
CinemaTicketBookingSystem/
├── README.md
├── CinemaTicketBookingSystem.sln
└── CinemaTicketBookingSystem/
    ├── CinemaTicketBookingSystem.csproj
    └── Program.cs
```

\---



