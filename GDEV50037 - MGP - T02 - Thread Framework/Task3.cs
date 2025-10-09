using System;
using System.Threading;

namespace ThreadExample
{
    internal class Task3
    {
        public Task3(int highestNumber)
        {
            
        }
    }

    class Task3ThreadInfo
    {
        int min;
        int max;
        int highestNumber;

        public Task3ThreadInfo(int min, int highestNumber)
        {
            
        }

        public void Count()
        {
            while (max <= highestNumber)
            {
                for (int i = min; i <= max; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(10);
                }
                min += 10;
                max += 10;
            }
        }
    }
}
