using System;

namespace StopWatch
{
    class Program
    {

        static void Main(string[] args)
        {

            var stopwatch = new StopWatch();

            while (true)
            {
                Console.WriteLine("Enter (S) to start timer (T) to stop timer (Q) to quit: ");
                var input = Console.ReadLine();
                Console.Clear();

                if (input == "S")
                {
                    Console.WriteLine("Started");
                    stopwatch.Start();
                }
                if (input == "T")
                {
                    Console.WriteLine("Stopped");
                    stopwatch.Stop();
                    Console.WriteLine("Time lapsed from start to stop: {0}\nTotal Timespan duration: {1}",stopwatch._lapsedTime, stopwatch._duration);
                    
                }
                if (input == "Q")
                {
                    Console.WriteLine("Duration: {0}", stopwatch._duration);
                    break;
                }

            }

           
        }
    }
}

