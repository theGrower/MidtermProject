using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApp.Classes;
using StoreApp.FurnitureEnums;
using System.IO;
using StoreApp.Methods;


namespace StoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Desk AnswerDesk = new Desk();
            Cart cart = new Cart();
            Greeting();
            FurnChoice.UserFurnChoice();
            Console.Read();
        }

        static void Greeting()
        {
            Console.WriteLine("Hello! Thank you for visiting our furniture store! Our store offers office furniture designed with you in mind.");
            Console.WriteLine("We have a selection of desks, files, seating, and tables to meet your office needs. Let's get started! ");
        }

        static void ReturnText() //figure out how to return to various steps in the process... 
        {
            Console.WriteLine("");
        }

        static List<Furniture> CreateArrays() //no longer using
        {
            //try
            //{
            StreamReader furnitureText;
            List<Furniture> productList = new List<Furniture>();
            string[] columns;
            string row;

            furnitureText = new StreamReader(new FileStream((@"C:\Git\MidtermProject\Furniture.txt"), FileMode.Open, FileAccess.Read));
            while (furnitureText.Peek() != -1)
            {
                row = furnitureText.ReadLine();
                columns = row.Split('|'); //still not working
                Furniture furniture = new Furniture();
                furniture.Type = columns[0];
                furniture.Name = columns[1];
                furniture.Price = decimal.Parse(columns[2]);
                furniture.Description = columns[3];
                productList.Add(furniture);
            }
            return productList;
            //}
            //finally
            //{
            //    furnitureText.Close();
            //}
        }
    }
}
