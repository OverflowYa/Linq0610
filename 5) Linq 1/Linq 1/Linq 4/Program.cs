using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Client> clients = new List<Client>
        {
            new Client { Code = 134, Year = 2001, Month = 1, Duration = 2 },
            new Client { Code = 256, Year = 2005, Month = 2, Duration = 1 },
            new Client { Code = 376, Year = 2013, Month = 3, Duration = 3 },
            new Client { Code = 476, Year = 2016, Month = 4, Duration = 1 },
            new Client { Code = 556, Year = 2021, Month = 5, Duration = 2 },
        };

            
            var minDurationClient = clients.OrderBy(c => c.Duration).Last();

            
            Console.WriteLine($"Продолжительность: {minDurationClient.Duration} часов, Год: {minDurationClient.Year}, Месяц: {minDurationClient.Month}");
        }

    }

    class Client
    {
        public int Code { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Duration { get; set; }
    }
    
}