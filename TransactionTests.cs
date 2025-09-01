using System;

namespace interview
{
    /// <summary>
    /// Simple test class to validate Transaction functionality
    /// Note: In a real project, you would use a proper testing framework like xUnit or NUnit
    /// </summary>
    public static class TransactionTests
    {
        public static void RunAllTests()
        {
            Console.WriteLine("Running Transaction Tests...\n");
            
            TestSaleTransaction();
            TestAuthorizationTransaction();
            TestReversalTransaction();
            
            Console.WriteLine("All tests completed successfully!");
        }

        private static void TestSaleTransaction()
        {
            Console.WriteLine("Testing Sale Transaction:");
            var transaction = new Transaction(TransactionType.Sale) { Amount = 100.0 };
            var result = transaction.CalculateAmount();
            var expected = 101.0; // 100 + (100 * 0.01)
            
            Assert(result == expected, $"Sale calculation failed. Expected: {expected}, Got: {result}");
            Console.WriteLine($"✓ Sale transaction calculated correctly: {result}");
        }

        private static void TestAuthorizationTransaction()
        {
            Console.WriteLine("Testing Authorization Transaction:");
            var transaction = new Transaction(TransactionType.Authorization) { AuthorizationAmount = 200.0 };
            var result = transaction.CalculateAmount();
            var expected = 202.0; // 200 + (200 * 0.01)
            
            Assert(result == expected, $"Authorization calculation failed. Expected: {expected}, Got: {result}");
            Console.WriteLine($"✓ Authorization transaction calculated correctly: {result}");
        }

        private static void TestReversalTransaction()
        {
            Console.WriteLine("Testing Reversal Transaction:");
            var transaction = new Transaction(TransactionType.Reversal) 
            { 
                Amount = 50.0, 
                AuthorizationAmount = 100.0, 
                ReversalAmount = 25.0 
            };
            var result = transaction.CalculateAmount();
            var expected = 175.0; // 100 + 50 + 25 (preserving original logic)
            
            Assert(result == expected, $"Reversal calculation failed. Expected: {expected}, Got: {result}");
            Console.WriteLine($"✓ Reversal transaction calculated correctly: {result}");
        }

        private static void Assert(bool condition, string message)
        {
            if (!condition)
            {
                throw new Exception($"Test failed: {message}");
            }
        }
    }
}