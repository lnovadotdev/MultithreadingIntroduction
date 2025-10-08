using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Timers;

namespace ThreadExample
{
    internal class Task4WithOutThreads
    {
        List<int> primes = new List<int>();
        int numbers = 1;

        Timer timer;

        public Task4WithOutThreads(double time)
        {
            timer = new Timer(time);
            timer.Elapsed += Stop;
            timer.Start();

            while (timer.Enabled)
            {
                //solve here
            }

            //Console.WriteLine("Primers found = ");

            foreach (int i in primes)
            {
                //Console.WriteLine(i);
            }

            Console.WriteLine("Number of primes found = " + primes.Count);

            Console.ReadLine();
        }

        void Stop(Object source, ElapsedEventArgs e)
        {
            timer.Stop();
        }

        public void CheckIfPrime(int numToCheck)
        {
        }
    }
}
