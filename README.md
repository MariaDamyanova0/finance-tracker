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

## Download & Install (Windows 10/11)
You can install and run the packaged application directly without opening Visual Studio:
1. Go to the [Releases](https://github.com/MariaDamyanova0/finance-tracker/releases) page and download `FinanceTracker-v1.0-Windows.zip`.
2. Extract the `.zip` archive to a folder.
3. Right-click on **`Install.ps1`** and select **Run with PowerShell** (follow the on-screen prompts to install the local developer certificate and app package).
4. Launch **Finance Tracker** from the Windows Start Menu.

## Run from Source
1. Clone or download this repository.
2. Open `FinanceTracker.sln` in **Visual Studio** (with the *Universal Windows Platform development* workload installed).
3. Select **x64** and **Local Machine**, then press **F5** to build and run.
