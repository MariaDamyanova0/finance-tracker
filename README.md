# Finance Tracker (UWP Desktop App)

A clean and responsive personal finance tracking desktop application built with **C#**, **XAML**, and **UWP (Universal Windows Platform)**. Designed to help users monitor their daily income, expenses, and overall balance in real time (EUR currency).

## Features
- **Real-Time Budget Summary:** Automatically calculates Total Balance, Total Income, and Total Expenses.
- **Transaction Management:** Add new transactions with category selection (Salary, Food, Bills/Rent, Transport, Entertainment, Other) and delete existing entries.
- **Visual Indicators:** Color-coded amounts (green for income, red for expenses) for quick readability.
- **Reactive UI:** Built with `ObservableCollection<T>` and `x:Bind` for instant interface updates without manual refreshes.
- **Input Validation:** Prevents invalid or empty entries using built-in validation dialogs.

## Tech Stack
- **Language:** C#
- **UI Markup:** XAML (Fluent Design principles)
- **Framework:** Universal Windows Platform (UWP) / .NET
- **Data Handling:** LINQ, `ObservableCollection<T>`

## Screenshots
<img width="1206" height="939" alt="main+view" src="https://github.com/user-attachments/assets/15e0f803-2117-4880-8a46-25dcaa864854" />


## How to Run
1. Clone or download this repository.
2. Open `FinanceTracker.sln` in **Visual Studio** (with the *Universal Windows Platform development* workload installed).
3. Select **x86** or **x64** and **Local Machine**, then press **F5** to build and run.
