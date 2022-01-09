using System.Linq;
using System.Diagnostics;
using System;

namespace NetEuler
{
    class Program
    {
        /// <summary>
        /// Main
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            //MagnetParse.Solve();
            LargeSum.Solve();

            sw.Stop();
            Console.WriteLine("Time Elapsed: {0:n0} minutes {1:n0} seconds {2:n0} milliseconds", sw.Elapsed.Minutes, sw.Elapsed.Seconds, sw.Elapsed.Milliseconds);

            // sw.Restart();
            // for (int i = 0; i < 100000000; i++) { }
            // sw.Stop();
            // Console.WriteLine("Time Elapsed: {0:n0} minutes {1:n0} seconds {2:n0} milliseconds", sw.Elapsed.Minutes, sw.Elapsed.Seconds, sw.Elapsed.Milliseconds);
        }

        private void logic()
        {
            bool a, b, c;

            a = c = true;
            b = !a && !c ? true : false;
            Console.WriteLine("a=c=true: b={0}", b);

            a = true;
            c = false;
            b = !a && !c ? true : false;
            Console.WriteLine("a true c false: b={0}", b);

            a = c = false;
            b = !a && !c ? true : false;
            Console.WriteLine("a=c=false: b={0}", b);
            //LatticePaths.Solve();
        }
    }
}
