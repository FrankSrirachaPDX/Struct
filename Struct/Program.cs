using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    public struct Number
    {
        public decimal Amount { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            string holder;

            Console.WriteLine("Enter a decimal number!");

            holder = Console.ReadLine();
            number.Amount = Convert.ToDecimal(holder);

            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
