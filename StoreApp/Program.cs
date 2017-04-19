using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApp.Classes;
using StoreApp.FurnitureEnums;
using System.IO;


namespace StoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string yesNo = null;
            do
            {
                Greeting.Hello();
                Order.Ordering();

                Console.Write(" Would you like to start a new order? (y/n): ");
                yesNo = Console.ReadLine();
                Console.Clear();
            }
            while (yesNo.ToLower() == "y");
            Console.Read();
        }
    }
}
