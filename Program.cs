using System;

namespace interview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Run tests to validate functionality
            TransactionTests.RunAllTests();
            Console.WriteLine();
            
            // Demonstrate usage
            Console.WriteLine("Demonstration of Transaction Usage:");
            Console.WriteLine("==================================");
            
            DemonstrateTransaction(TransactionType.Sale, amount: 100.0);
            DemonstrateTransaction(TransactionType.Authorization, authorizationAmount: 250.0);
            DemonstrateTransaction(TransactionType.Reversal, amount: 50.0, authorizationAmount: 100.0, reversalAmount: 30.0);
        }

        static void DemonstrateTransaction(TransactionType type, double amount = 0, double authorizationAmount = 0, double reversalAmount = 0)
        {
            Transaction transaction = new Transaction(type)
            {
                Amount = amount,
                AuthorizationAmount = authorizationAmount,
                ReversalAmount = reversalAmount
            };
            
            double calculatedAmount = CalculateTransactionAmount(transaction);
            Console.WriteLine($"Transaction Type: {transaction.Type}");
            Console.WriteLine($"Calculated Amount: {calculatedAmount:C}");
            Console.WriteLine();
        }

        static double CalculateTransactionAmount(Transaction transaction)
        {
            return transaction.CalculateAmount() ?? 0;
        }
    }
}
