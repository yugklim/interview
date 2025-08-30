using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview
{
    public class Transaction
    {
        public Transaction(string v)
        {
            Type = v;
        }

        public string Type { get; }

        public double Amnt { get; set; }

        public double AuthrsationAmnt { get; set; }

        public double ReversalAmnt { get; set; }

        public double? CalculateAmnt() 
        {
            switch (Type)
            {
                case "Sale":
                    return Amnt + Amnt * 0.01;
                case "Authorization":
                    return AuthrsationAmnt + AuthrsationAmnt * 0.01;
                case "Reversal":
                    return AuthrsationAmnt + Amnt+ ReversalAmnt;
                default:
                    return null;
            }
        }
    }

}
