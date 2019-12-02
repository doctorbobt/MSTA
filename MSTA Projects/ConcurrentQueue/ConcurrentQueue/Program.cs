using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConcurrentQueue
{
    class Program
    {
        static ConcurrentQueue<string> queue = new ConcurrentQueue<string>();
        static void PlaceOrders()
        {
            for (int i = 1; i <= 1000; i++)
            {
                Thread.Sleep(250);
                String order = String.Format("Order {0}", i);
                queue.Enqueue(order);
                Console.WriteLine("Added {0}", order);
            }
        }
        static void ProcessOrders()
        {
            string order = string.Empty;
            while (true)
            {
                //continue indefinitely
                Thread.Sleep(2000);
                if (queue.TryDequeue(out order))
                {
                    Console.WriteLine("Processed {0}", order);
                }
            }
        }
        static void Main(string[] args)
        {
            var taskPlaceOrders = Task.Run(() => PlaceOrders());
            Task.Run(() => ProcessOrders());
            Task.Run(() => ProcessOrders());
            Task.Run(() => ProcessOrders());
            taskPlaceOrders.Wait();
            Console.WriteLine("Press ENTER to finish");
            Console.ReadLine();
        }
    }
}
