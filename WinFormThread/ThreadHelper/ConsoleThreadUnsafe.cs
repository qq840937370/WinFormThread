using System;
using System.Threading;

namespace ConsoleThreadUnsafe
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread threadA = new Thread(ThreadMethod); //执行的必须是无返回值的方法 
            threadA.Name = "1";
            Thread threadB = new Thread(ThreadMethod); //执行的必须是无返回值的方法 
            threadB.Name = "2";
            threadA.Start();
            threadB.Start();
            Console.ReadKey();
        }
        public static void ThreadMethod(object parameter)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("我是:{0},我循环{1}次", Thread.CurrentThread.Name, i);
                Thread.Sleep(300);
            }
        }
    }
}
