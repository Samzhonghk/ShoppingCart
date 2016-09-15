using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCart.Service;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            Cashier cashier = new Cashier();
            cashier.DisplayProducts();
            cashier.AskToBuy();
            Console.ReadKey();
        }
    }
}
