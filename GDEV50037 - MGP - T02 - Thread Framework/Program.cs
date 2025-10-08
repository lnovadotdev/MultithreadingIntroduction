using System;
using System.Threading;

namespace ThreadExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                1. Create a thread with no parameters 
                    a. Thread thread = new Thread(new ThreadStart(function_name);

                2. Create a thread with generic parameters
                    a. Thread thread = new Thread(new ParameterizedThreadStart(function_name_with_object_parameters));

                3. Create a thread with parameters using lambda/delegates. This is an anonymous function and hard to debug
                    a. Thread thread = new Thread(() => { func(); });  

                4. Start a thread
                    a. thread.Start()

                5. Pause the current thread (context sensitive) untill another thread has finished
                    a. thread.Join();
            */

            //thread examples
            Threads exampleThreads = new Threads();

            //Uncomment the task you want to run. 
            //Task1 task1 = new Task1();
            //Task2 task2 = new Task2();
            //Task3 task3 = new Task3(100);
            //Task4WithOutThreads task4WithoutThreads = new Task4WithOutThreads(10000);
            //Task4WithThreads task4withThreads = new Task4WithThreads(10000, 5);
        }
    }
}
