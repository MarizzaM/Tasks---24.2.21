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
        static int[] numbers = new int[10];
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
            ParameterizedThreadStart index = new ParameterizedThreadStart(Set10ItemsInArray);
            List<Thread> threadsTo10 = new List<Thread>();
            for (int i = 0; i < 10; i++)
            {
                var t = new Thread(index);
                threadsTo10.Add(t);
                Console.WriteLine($"Thread #{i+1}");
            }
            stopwatch.Stop();



            Stopwatch stopwatch1 = new Stopwatch();

            stopwatch1.Start();

            Console.WriteLine("Time elapsed: {0}", stopwatch1.Elapsed);


            var tasks = new Task[10];
            //AutoResetEvent are = new AutoResetEvent(true);
            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = Task.Run(() =>
                {
                        Console.WriteLine($"Task #{Task.CurrentId}");
                });
            }

            for (int i = 0; i < tasks.Length; i++)
            {
                Task.WaitAll(tasks);
            }
            stopwatch1.Stop();

        }
        static void Set10ItemsInArray(object i)
        {
            for (int index = (int)i; index < ((int)i + 1); index++)
            {
                numbers[index] = 1;
            }
        }
    }
}
