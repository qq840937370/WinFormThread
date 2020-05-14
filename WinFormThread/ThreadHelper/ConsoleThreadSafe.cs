using System;
using System.Threading;

namespace ConsoleThreadSafe
{
    class Program
    {
        private static object obj = new object(); //一般情况下，loke私有的、静态的并且是只读的对象。
        static void Main(string[] args)
        {
            Program pro1 = new Program();  // 改动
            Program pro2 = new Program();  // 改动
            Thread threadA = new Thread(pro1.ThreadMethod); //执行的必须是无返回值的方法 - 改动
            threadA.Name = "1";
            Thread threadB = new Thread(pro2.ThreadMethod); //执行的必须是无返回值的方法 - 改动
            threadB.Name = "2";
            threadA.Start();
            threadB.Start();
            Console.ReadKey();
        }
        public void ThreadMethod(object parameter)
        {
            lock (obj)             // lock全局的私有化静态变量，外部无法对该变量进行访问。
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("我是:{0},我循环{1}次", Thread.CurrentThread.Name, i);
                    Thread.Sleep(300);
                }
            }
        }
    }
}
