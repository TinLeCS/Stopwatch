using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Stopwatch
{
    class Stopwatch
    {
        private static int hour = 0;
        private static int min = 0;
        private static int sec = 0;
        public static void Run()
        {
            Timer t = new Timer(Update, null, 0, 1000);
            if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                t.Change(Timeout.Infinite, Timeout.Infinite);

            Console.ReadLine();
        }

        private static void Update(Object o)
        {
            Console.Clear();
            sec++;
            if (sec == 60)
            {
                sec = 0;
                min++;
            }
            if (min == 60)
            {
                min = 0;
                hour++;
            }

            // Display the watch when this method got called.
            Console.WriteLine($"{hour.ToString("00")}:{min.ToString("00")}:{sec.ToString("00")}");
            Console.WriteLine("Press ESC to stop");
            // Force a garbage collection to occur for this demo.
            GC.Collect();
        }
    }
}
