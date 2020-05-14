using System;
using System.Threading;

namespace ConsoleThread
{
    class Program
    {
        static void Main(string[] args)
        {

            //Thread t = new Thread(thread2);
            //t.Start();
            new Thread(thread2).Start();
            for (int thread1 = 1; thread1 > 0; thread1++)
            {
                Console.WriteLine("线程1已开启");  // Convert.ToString(thread1)
                Thread.Sleep(1000);
            }
        }

        private static void thread2()
        {
            for (int thread2 = 1; thread2 > 0; thread2++)
            {
                Console.WriteLine("线程2已开启");  // Convert.ToString(thread2)
                Thread.Sleep(1000);
            }
        }
    }
}
