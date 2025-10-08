using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadExample
{
	/// <summary>
	/// A series of examples
	/// </summary>
	internal class Threads
	{
		public Threads()
		{
			Thread t1 = new Thread(new ThreadStart(Count));
			t1.Name = "T1: ";	

			Thread t2 = new Thread(new ParameterizedThreadStart(Count));
			t2.Name = "T2: ";	

			Thread t3 = new Thread(() => { Count(10); });
			t3.Name = "T3: ";

			t1.Start();
			t2.Start(10);
			t3.Start();

			t1.Join();
			t2.Join();
			t3.Join();

			Thread t4 = new Thread(() => { Count(20); });
			t4.Name = "T4: ";	
			t4.Start();
		}

		void Count()
		{
			for(int i = 0; i < 10; i++)
			{
				Console.WriteLine(Thread.CurrentThread.Name + i);
				Thread.Sleep(100);
			}
		}

		void Count(Object num)
		{
			int nums = (int)num;
			for (int i = 0; i < nums; i++)
			{
				Console.WriteLine(Thread.CurrentThread.Name + i);
				Thread.Sleep(100);
			}
		}

		void Count(int num)
		{
			for (int i = 0; i < num; i++)
			{
				Console.WriteLine(Thread.CurrentThread.Name + i);
				Thread.Sleep(100);
			}
		}
	}


}
