using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _106._Queues
{
    internal class Order
    {
        public int OrderId { get; set; }
        public int OrderQuantity { get; set; }

        public string BranchSource { get; set; }

        public Order(int id, int OrderQuantity, string BranchesID)
        {
            this.OrderId = id;
            this.OrderQuantity = OrderQuantity;
            this.BranchSource = BranchesID;
        }

        public void ProcessOrder()
        {
            Console.WriteLine($"Order ID {OrderId} with amount {OrderQuantity} from {BranchSource} added into the process");
        }
    }
}
