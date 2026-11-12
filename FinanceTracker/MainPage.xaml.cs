using System;
using System.Collections.ObjectModel;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace FinanceTracker
{
    public sealed partial class MainPage : Page
    {
        // ObservableCollection automatically updates the UI when items are added or removed
        public ObservableCollection<Transaction> Transactions { get; set; } = new ObservableCollection<Transaction>();

        public MainPage()
        {
            this.InitializeComponent();

            // Bind the XAML ListView to our collection
            LstTransactions.ItemsSource = Transactions;

            // Add sample transactions on startup
            SeedInitialData();
            UpdateSummary();
        }

        // 1. Add a new transaction
        private void BtnAddTransaction_Click(object sender, RoutedEventArgs e)
        {
            // Title validation
            if (string.IsNullOrWhiteSpace(TxtTitle.Text))
            {
                ShowErrorDialog("Please enter a transaction description or title.");
                return;
            }

            // Amount validation
            if (!double.TryParse(TxtAmount.Text, out double amount) || amount <= 0)
            {
                ShowErrorDialog("Please enter a valid positive amount.");
                return;
            }

            // Determine type (Income or Expense)
            TransactionType type = CmbType.SelectedIndex == 0 ? TransactionType.Income : TransactionType.Expense;

            // Get selected category
            string category = (CmbCategory.SelectedItem as ComboBoxItem)?.Content.ToString() ?? "Other";

            // Create new transaction object
            var newTransaction = new Transaction
            {
                Title = TxtTitle.Text.Trim(),
                Amount = amount,
                Type = type,
                Category = category,
                Date = DateTimeOffset.Now
            };

            // Insert at the top of the collection
            Transactions.Insert(0, newTransaction);

            // Reset form fields
            TxtTitle.Text = string.Empty;
            TxtAmount.Text = string.Empty;
            CmbType.SelectedIndex = 0;
            CmbCategory.SelectedIndex = 0;

            // Update balance summary
            UpdateSummary();
        }

        // 2. Delete a transaction
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag is Transaction transactionToDelete)
            {
                Transactions.Remove(transactionToDelete);
                UpdateSummary();
            }
        }

        // 3. Calculate Balance, Income, and Expenses
        private void UpdateSummary()
        {
            double totalIncome = Transactions
                .Where(t => t.Type == TransactionType.Income)
                .Sum(t => t.Amount);

            double totalExpense = Transactions
                .Where(t => t.Type == TransactionType.Expense)
                .Sum(t => t.Amount);

            double totalBalance = totalIncome - totalExpense;

            // Format values in the UI
            TxtTotalIncome.Text = $"{totalIncome:F2} €";
            TxtTotalExpense.Text = $"{totalExpense:F2} €";
            TxtTotalBalance.Text = $"{totalBalance:F2} €";
        }

        // Initial sample data
        private void SeedInitialData()
        {
            Transactions.Add(new Transaction
            {
                Title = "Monthly Salary",
                Amount = 1500.00,
                Type = TransactionType.Income,
                Category = "Salary",
                Date = DateTimeOffset.Now.AddDays(-2)
            });

            Transactions.Add(new Transaction
            {
                Title = "Supermarket Groceries",
                Amount = 85.40,
                Type = TransactionType.Expense,
                Category = "Food",
                Date = DateTimeOffset.Now.AddDays(-1)
            });
        }

        // Helper dialog for validation errors
        private async void ShowErrorDialog(string message)
        {
            ContentDialog dialog = new ContentDialog
            {
                Title = "Warning",
                Content = message,
                CloseButtonText = "OK"
            };
            await dialog.ShowAsync();
        }
    }
}