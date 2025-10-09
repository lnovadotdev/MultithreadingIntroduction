using System;
using System.Threading;

namespace ThreadExample
{
    internal class Task2
    {
        public Task2()
        {
            for (int i = 0; i < 5; i++)
            {
                Task2ThreadInfo threadInfo = new Task2ThreadInfo(i);
            }
        }
    }

    class Task2ThreadInfo
    {
        int index;

        public Task2ThreadInfo(int index)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread t = new Thread(new ThreadStart(Counting));
                t.Name = "Thread " + index;
                this.index = index;
                t.Start();
            }
        }

        public void Counting()
        {
            while (true)
            {
                Console.WriteLine(index);
                Thread.Sleep((int)((index + 1) * 0.5));
            }
        }
    }
}
