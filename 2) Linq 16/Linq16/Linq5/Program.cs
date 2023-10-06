using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -2, 5, -10, 7, 3, -1, 0, 8 };

            var positiveNumbers = numbers.Where(n => n > 0);

            foreach (var number in positiveNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}