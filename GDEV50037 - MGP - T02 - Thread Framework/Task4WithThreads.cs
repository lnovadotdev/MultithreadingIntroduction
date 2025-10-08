using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Timers;

namespace ThreadExample
{
    internal class Task4WithThreads
    {
        //we use a concurrent bag to ensure only 1 thread can access it at any point
        //can use a list instead here but isn't as good for threading
        //we will cover concurrent collections later.
        ConcurrentBag<int> primes = new ConcurrentBag<int>();
        System.Timers.Timer timer;
        Thread[] threads;
        int numberOfThreads;
        int number = 2;

        public Task4WithThreads(double time, int numberOfThreads)
        {
            timer = new System.Timers.Timer(time);
            timer.Elapsed += Stop;
            timer.Start();

            //solve here

            //Console.WriteLine("Primes found = ");

            int[] prime = primes.ToArray();
            Array.Sort(prime);

            foreach (int i in prime)
            {
                //Console.WriteLine(i);
            }

            Console.WriteLine("Number of primes found = " + primes.Count);

            Console.ReadLine();
        }

        void Stop(Object source, ElapsedEventArgs e)
        {
            timer.Stop();

            for (int i = 0; i < numberOfThreads; i++)
            {
                threads[i].Abort();
            }
        }

        public void CheckIfPrime()
        {
            while (true)
            {
            }
        }

        int GetNumber()
        {
            //this means only one thread has access to the value at any given time.
            //This helps with the flow of data. don't worry about understanding this yet we will cover it in later weeks.
            //This problem can be "solved" without using the lock but it won't run as well
            lock (this)
            {
                int i = number;
                number++;
                return i;
            }
        }
    }
}
