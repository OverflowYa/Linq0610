using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_45
{
    internal class Program
    {
        static void Main()
        {
            int L1 = 3;
            int L2 = 4;
            string[] A = { "123", "ABC", "456", "DEF" };
            string[] B = { "7890", "GHIJ", "KLMN", "OPQR" };

            var result = A.Where(s => s.Length == L1).Concat(B.Where(s => s.Length == L2)).OrderByDescending(s => s);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
