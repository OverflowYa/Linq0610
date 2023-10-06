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
            List<int> numbers = new List<int> { 123, 45, 678, 90, 123, 45, 678, 90 };

            var result = numbers
                .Where(n => n > 0)
                .Select(n => n % 10) 
                .Distinct() 
                .ToList();

            foreach (var digit in result)
            {
                Console.WriteLine(digit);
            }
        }
    }
}