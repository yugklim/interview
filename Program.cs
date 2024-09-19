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

        }

        static Transaction X(Transaction t)
        {
            switch (t.Type)
            {
                case 0:
                    {
                        t.DoSomething1();
                        return t;
                    }
                case 1:
                    {
                        t.DoSomething2();
                        return t;
                    }
                case 2:
                    {
                        t.DoSomething3();
                        return t;
                    }
                case 3:
                    {
                        t.DoSomething4();
                        return t;
                    }
                case 4:
                    {
                        t.DoSomething5();
                        return t;
                    }
                default:
                    {
                        return null;
                    }
            }
        }
    }
}
