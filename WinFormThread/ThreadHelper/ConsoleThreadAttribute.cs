using System;
using System.Threading;

namespace ConsoleThreadAttribute
{
    /*
    * 死锁例子
    * 变量共享 
    */
    class Program
    {
        static void Main(string[] args)
        {
            //获取正在运行的线程
            Thread thread = Thread.CurrentThread;
            //设置线程的名字
            thread.Name = "主线程";
            //获取当前线程的唯一标识符
            int id = thread.ManagedThreadId;
            //获取当前线程的状态
            ThreadState state = thread.ThreadState;
            //获取当前线程的优先级
            ThreadPriority priority = thread.Priority;
            string strMsg = string.Format("Thread ID:{0}\n" + "Thread Name:{1}\n" +
                "Thread State:{2}\n" + "Thread Priority:{3}\n", id, thread.Name,
                state, priority);

            Console.WriteLine(strMsg);

            Console.ReadKey();
        }
    }
}
