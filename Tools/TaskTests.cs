using System.Security.Cryptography;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;

/* 
    https://projecteuler.net/problem=1  */


namespace NetEuler
{
    static class TaskTests
    {
        public static void Solve()
        {
            Thread.CurrentThread.Name = "Main";

            // Create a task and supply a user delegate by using a lambda expression. 
            Task taskA = new Task(() => {for (int i = 0; i < 100000000; i++) { }});
            // Start the task.
            Stopwatch sw = new Stopwatch();
            sw.Start();
            taskA.Start();

            // Output a message from the calling thread.
            Console.WriteLine("Hello from thread '{0}'.",
                          Thread.CurrentThread.Name);
            taskA.Wait();
            sw.Stop();
            Console.WriteLine("Time Elapsed: {0:n0} minutes {1:n0} seconds {2:n0} milliseconds", sw.Elapsed.Minutes, sw.Elapsed.Seconds, sw.Elapsed.Milliseconds);

        }
    }
}