using System;

namespace interview
{
    public enum TransactionType
    {
        Sale,
        Authorization,
        Reversal
    }

    public class Transaction
    {
        private const double FeeRate = 0.01; // 1% fee for Sale and Authorization transactions

        public Transaction(TransactionType transactionType)
        {
            Type = transactionType;
        }

        public TransactionType Type { get; }

        public double Amount { get; set; }

        public double AuthorizationAmount { get; set; }

        public double ReversalAmount { get; set; }

        public double? CalculateAmount() 
        {
            switch (Type)
            {
                case TransactionType.Sale:
                    return Amount + Amount * FeeRate;
                case TransactionType.Authorization:
                    return AuthorizationAmount + AuthorizationAmount * FeeRate;
                case TransactionType.Reversal:
                    // Reversal typically should negate amounts, but keeping original logic for compatibility
                    return AuthorizationAmount + Amount + ReversalAmount;
                default:
                    throw new ArgumentException($"Unknown transaction type: {Type}");
            }
        }
    }
}
