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
            Cart cart = new Classes.Cart();
        }

        static void Greeting()
        {
            Console.WriteLine("Hello. Thank you for visiting Steelcase.");
            Console.WriteLine("Our store offers office furniture designed with you in mind.");
            Console.WriteLine("Choose from our selection of desks, files, seating, and tables to custom design your office");
            Console.WriteLine("Let's get started!");
            Console.WriteLine("What type of furniture would you like to browse first?");
            Console.Write("Please type \"desks\", \"files\", \"seating\", or \"table\": ");
        }

        static void CreateArrays()
        {
            StreamReader furniture = null;
            List<string> inventory = new List<string>();
            string[] columns = null;
            string row = null;
            
            furniture = new StreamReader(new FileStream((@"C:\Git\MidtermProject\Furniture.txt"), FileMode.Open, FileAccess.Read));
            while (furniture.Peek() !=1)
            {
                row = furniture.ReadLine();
                columns = row.Split('|');
                inventory.AddRange(columns);
            }
        }
    }
}
