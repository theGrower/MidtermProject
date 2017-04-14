using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApp.Classes;

namespace StoreApp.Methods
{
    class UserFurnChoice
    {
        static void UserFurniChoice() //these may need to be objects in the as they'll create the client's furniture && add to cart
        {
            string userFurnChoice = null;
            userFurnChoice = Console.ReadLine();
            if (Validator.ParceFurnChoice(userFurnChoice) == Classes.UserFurnChoice.DESK)
            {
                Console.Clear();
                var productList = File.ReadAllLines(@"C:\Git\MidtermProject\Furniture.txt").Select(l => l.Split('|')).ToArray();

                Console.WriteLine("You've chosen to explore our desks! Here is a list of our desks.");
                Console.WriteLine("Our {0} desk costs ${1}.", productList[0][1], productList[0][2]);
                Console.WriteLine("Description: {0}", productList[0][3]);
                Console.WriteLine("Our {0} desk costs ${1}.", productList[1][1], productList[1][2]);
                Console.WriteLine("Description: {0}", productList[1][3]);
                Console.WriteLine("Our {0} desk costs ${1}.", productList[2][1], productList[2][2]);
                Console.WriteLine("Description: {0}", productList[2][3]);
                Console.WriteLine("Our {0} desk costs ${1}.", productList[3][1], productList[3][2]);
                Console.WriteLine("Description: {0}", productList[3][3]);
                Console.Write("Would you like to purchase one of these desks? (y/n): ");
            }
            else if (Validator.ParceFurnChoice(userFurnChoice) == Classes.UserFurnChoice.FILES)
            {
                // go through FIles options
                Console.Clear();
            }
            else if (Validator.ParceFurnChoice(userFurnChoice) == Classes.UserFurnChoice.SEATING)
            {
                // go through seating options
                Console.Clear();
            }
            else if (Validator.ParceFurnChoice(userFurnChoice) == Classes.UserFurnChoice.TABLES)
            {
                // go through tables options
                Console.Clear();
            }
            else if (Validator.ParceFurnChoice(userFurnChoice) == Classes.UserFurnChoice.NOT_RECOGNIZED)
            {
                Console.Write("Invalid Entry, please try again: ");
                UserFurniChoice();
            }
        }

    }
}
