using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Please enter a number: ");
            double num = Convert.ToInt32(Console.ReadLine());
            DateTime then = now.AddHours(num);
            Console.WriteLine("time listed in line 1 plus hours you added equates to a datime obj of:\n");
            Console.WriteLine(then);
            
        }
    }
}
