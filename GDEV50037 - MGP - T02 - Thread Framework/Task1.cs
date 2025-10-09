using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ThreadExample
{
    internal class Task1
    {
        public Task1()
        {
            // Start CountUp on a new thread
            Thread countUpThread = new Thread(new ThreadStart(CountUp));
            countUpThread.Start();

            // Run CountDown on the main thread
            CountDown();

            // Wait for CountUp to finish
            countUpThread.Join();
        }

        void CountUp()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(10);
            }
        }

        void CountDown()
        {
            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(10);
            }
        }
    }
}
