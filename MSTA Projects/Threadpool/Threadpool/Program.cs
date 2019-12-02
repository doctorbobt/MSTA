using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Threadpool
{
    class Program
    {
        public static void Main()
        {
            // Queue the task.
            // Often you won’t use the ThreadPool class directly. Instead you can use other technologies built on top of it, such as TPL, APM, Event -
            // EAP, TAP, or the new async / await keywords.
            ThreadPool.QueueUserWorkItem(ThreadProc);
            Console.WriteLine("Main thread does some work, then sleeps.");
            Thread.Sleep(1000);

            // If you comment out the call to the Thread.Sleep method, the main thread exits before method runs on the thread pool thread. 
            // The thread pool uses background threads, which do not keep the application running if all foreground threads have terminated. 

            Console.WriteLine("Main thread exits.");

            Console.ReadKey();
        }

        // This thread procedure performs the task. No state object was passed to QueueUserWorkItem, so stateInfo is null.
        static void ThreadProc(Object stateInfo)
        {
            int worker = 0;
            int io = 0;
            ThreadPool.GetAvailableThreads(out worker, out io);

            Console.WriteLine("Hello from the thread pool.");
            Console.WriteLine("Thread pool threads available at startup: ");
            Console.WriteLine("   Worker threads: {0:N0}", worker);
            Console.WriteLine("   Asynchronous I/O threads: {0:N0}", io);
        }
    }
}