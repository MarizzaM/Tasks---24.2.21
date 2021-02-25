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
            //10 THREADS

            List<Thread> ten_treads = new List<Thread>();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            ThreadPool.QueueUserWorkItem((o) =>
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write($"Thread #{i}\n");
                }
            }, null);

            Console.WriteLine("The total time elapsed using 10 threads from ThreadPool is: {0} ms\n", stopwatch.Elapsed.TotalMilliseconds);
            stopwatch.Stop();

            // 10 TASKS

            stopwatch.Reset();
            stopwatch.Start();

            var ten_tasks = new Task[10];

            for (int i = 0; i < ten_tasks.Length; i++)
            {
                ten_tasks[i] = Task.Run(() =>
                {
                    Console.WriteLine($"Task #{Task.CurrentId}");
                });
            }

            for (int i = 0; i < ten_tasks.Length; i++)
            {
                Task.WaitAll(ten_tasks);
            }
            Console.WriteLine("The total time elapsed using 10 tasks is: {0} ms", stopwatch.Elapsed.TotalMilliseconds);
            stopwatch.Stop();
        }
    }
}



