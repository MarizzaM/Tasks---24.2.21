using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Taks24._02._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter number #1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter number #2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Task<int> t =  Task.FromResult(number1 + number2);

            Console.WriteLine($"{number1} + {number2} = {t.Result}");
        }
    }
}
