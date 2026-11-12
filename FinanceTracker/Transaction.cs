using System;

namespace FinanceTracker
{
    public enum TransactionType
    {
        Income,  
        Expense  
    }

    public class Transaction
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Title { get; set; }
        public double Amount { get; set; }
        public TransactionType Type { get; set; }
        public string Category { get; set; }
        public DateTimeOffset Date { get; set; } = DateTimeOffset.Now;

        
        public string AmountFormatted => Type == TransactionType.Income
            ? $"+{Amount:F2} €"
            : $"-{Amount:F2} €";

        public string ColorHex => Type == TransactionType.Income ? "#2ECC71" : "#E74C3C";

        public string DateFormatted => Date.ToString("dd.MM.yyyy HH:mm");

    }
}