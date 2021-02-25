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
            Task<int> pow = Task<int>.Run(() =>
            {
                return 2; 
            }).ContinueWith((Task<int> result) =>
            {
                return result.Result * 2; 
            }).ContinueWith((Task<int> result) =>
            {
                return result.Result * 2; 
            }).ContinueWith((Task<int> result) =>
            {
                return result.Result * 2; 
            });
            Console.WriteLine($"2 power 4 = {pow.Result}");

        }
    }
}
