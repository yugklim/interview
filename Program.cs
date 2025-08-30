using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transaction tr = new Transaction("Sale");
            double amount = X(tr);
            amount = 5.1;
        }

        static double X(Transaction t)
        {
            return t.CalculateAmnt() ?? 0;
        }
    }
}
