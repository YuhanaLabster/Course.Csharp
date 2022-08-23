using System;
using System.Collections.Generic;
namespace _106._Queues
{
    internal class Program
    {
        public static Queue<int> queue = new Queue<int>();
        public static Order[] ReceiveOrderFromBranch1()
        {
            Order[] orders = new Order[]
            {
                new Order(1,5,"Branch 1"),
                new Order(2,4,"Branch 1"),
                new Order(6,10,"Branch 1"),
            };
            return orders;
        }
        public static Order[] ReceiveOrderFromBranch2()
        {
            Order[] orders = new Order[]
            {
                new Order(3,5,"Branch 2"),
                new Order(4,4,"Branch 2"),
                new Order(5,10,"Branch 2"),
            };
            return orders;
        }

        public static Queue<Order> ordersQueue = new Queue<Order>();

        static void Main(string[] args)
        {
            //AddElements(1,2,3);
            //DequeueAll();
            //DirectRemoveElements();
            //ViewElements();

            /*  Scenario    : 
                * We have two order list two branches (ReceiveOrderFromBranch1) and ReceiveOrderFromBranch2()
                * Imagine both brances are not sending the order at the same time (in this case ReceiveOrderFromBranch1() did send the Order first
                * We need to process Orders from two branches.
             
                Steps       :
                * We need to create list of Order[] ReceiveOrderFromBranch1() and Order[] ReceiveOrderFromBranch2()
                * We need to create Queue<Order> ordersQueue = new Queue<Order>() as the data container for both branches.
                * We need to create function to add all values into ordersQueue called AddOrderFromBranches()
                * We need to create function AddValuesToordersQueue() to sort and parse the value into the ProcessOrder() so it can be added into the process
             * 
             */
            AddOrderFromBranches();
            AddValuesToordersQueue();
        }
        public static void AddElements(params int[] number)
        {
            foreach (int item in number)
            {
            queue.Enqueue(item);
            Console.WriteLine($"{item} added to Queue");
            }
        }

        public static void ViewElements()
        {
            if (queue.Count != 0)
            {
                Console.WriteLine($"Element found : {queue.Peek()}") ;
            }
            else
            {
                Console.WriteLine("empty elements");
            }
        }

        public static void DirectRemoveElements()
        {
            // if we remove before adding the element, it will get exception "System.InvalidOperationException: 'Queue empty."
            int item = queue.Dequeue();
            Console.WriteLine($"{item} being removed");
        }

        public static void DequeueAll()
        {
            while(queue.Count > 0)
            {
                Console.WriteLine($"{queue.Dequeue()} was removed");
                Console.WriteLine($"{queue.Count} current que ");
            }
        }

        public static void AddOrderFromBranches()
        {
            foreach(Order ORDR in ReceiveOrderFromBranch1())
            {
                ordersQueue.Enqueue(ORDR);
            }
            foreach (Order ORDR in ReceiveOrderFromBranch2())
            {
                ordersQueue.Enqueue(ORDR);
            }
        }

        public static void AddValuesToordersQueue()
        {
            while(ordersQueue.Count > 0)
            {
            // remove order at the front of the queue
            // store it in a variable called currentOrder
            Order currentOrder = ordersQueue.Dequeue();
            // process the order
            currentOrder.ProcessOrder();

            }
        }
    }
}
