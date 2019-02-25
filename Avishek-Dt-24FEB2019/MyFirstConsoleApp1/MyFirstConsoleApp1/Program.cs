using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Your Name then newline
            
            Console.WriteLine("Hello, Avishek Mishra!"+Environment.NewLine);
            Console.WriteLine("System Date and Time "+DateTime.Now.ToString("yyyy-MM-ddThh:mm:sszzz") + Environment.NewLine);
            Console.WriteLine("System Day of Week:- "+ DateTime.Now.DayOfWeek + Environment.NewLine);
            //Date and time 
            DateTime dt = new DateTime();
            Console.WriteLine("Date and Time " + dt.ToString("yyyy-MM-ddThh:mm:sszzz") + Environment.NewLine);
            Console.WriteLine("Day of Week:- " + dt.DayOfWeek);
            Console.ReadKey();
        }
    }
}
