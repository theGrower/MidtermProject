﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApp.Classes;
using System.IO;

namespace StoreApp.Methods
{
    class FurnChoice
    {
        public static void UserFurnChoice() 
        {
            Console.Write("Please type the catagory you would like to expore: \"desks\", \"files\", \"seating\", or \"table\": ");
            string userFurnChoice = null;
            userFurnChoice = Console.ReadLine();
            if (Validator.ParseFurnChoice(userFurnChoice) == FurnitureEnums.FurnitureEnums.UserFurnChoice.DESK)
            {
                DeskChoice.UserDeskChoice();
            }
            else if (Validator.ParseFurnChoice(userFurnChoice) == FurnitureEnums.FurnitureEnums.UserFurnChoice.FILES)
            {
                Console.Clear();
                var productList = File.ReadAllLines(@"C:\Git\MidtermProject\Furniture.txt").Select(l => l.Split('|')).ToArray();
                Console.WriteLine("You've chosen to explore our files! Here is a list of our file selections.");
                Console.WriteLine("Our {0} file costs ${1}.", productList[4][1], productList[4][2]);
                Console.WriteLine("Description: {0}", productList[4][3]);
                Console.WriteLine("Our {0} file costs ${1}.", productList[5][1], productList[5][2]);
                Console.WriteLine("Description: {0}", productList[5][3]);
                Console.WriteLine("Our {0} file costs ${1}.", productList[6][1], productList[6][2]);
                Console.WriteLine("Description: {0}", productList[6][3]);
                Console.Write("Would you like to purchase one of these files? (y/n): ");
            }
            else if (Validator.ParseFurnChoice(userFurnChoice) == FurnitureEnums.FurnitureEnums.UserFurnChoice.SEATING)
            {
                Console.Clear();
                var productList = File.ReadAllLines(@"C:\Git\MidtermProject\Furniture.txt").Select(l => l.Split('|')).ToArray();
                Console.WriteLine("You've chosen to explore our seating! Here is a list of our seating selections.");
                Console.WriteLine("Our {0} seating costs ${1}.", productList[7][1], productList[7][2]);
                Console.WriteLine("Description: {0}", productList[7][3]);
                Console.WriteLine("Our {0} seating costs ${1}.", productList[8][1], productList[8][2]);
                Console.WriteLine("Description: {0}", productList[8][3]);
                Console.WriteLine("Our {0} seating costs ${1}.", productList[9][1], productList[9][2]);
                Console.WriteLine("Description: {0}", productList[9][3]);
                Console.WriteLine("Our {0} seating costs ${1}.", productList[10][1], productList[10][2]);
                Console.WriteLine("Description: {0}", productList[10][3]);
                Console.WriteLine("Our {0} seating costs ${1}.", productList[11][1], productList[11][2]);
                Console.WriteLine("Description: {0}", productList[11][3]);
                Console.Write("Would you like to purchase seating? (y/n): ");
            }
            else if (Validator.ParseFurnChoice(userFurnChoice) == FurnitureEnums.FurnitureEnums.UserFurnChoice.TABLES)
            {
                Console.Clear();
                var productList = File.ReadAllLines(@"C:\Git\MidtermProject\Furniture.txt").Select(l => l.Split('|')).ToArray();
                Console.WriteLine("You've chosen to explore our tables! Here is a list of our table selections.");
                Console.WriteLine("Our {0} table costs ${1}.", productList[12][1], productList[12][2]);
                Console.WriteLine("Description: {0}", productList[12][3]);
                Console.WriteLine("Our {0} table costs ${1}.", productList[13][1], productList[13][2]);
                Console.WriteLine("Description: {0}", productList[13][3]);
                Console.WriteLine("Our {0} table costs ${1}.", productList[14][1], productList[14][2]);
                Console.WriteLine("Description: {0}", productList[14][3]);
                Console.WriteLine("Our {0} table costs ${1}.", productList[15][1], productList[15][2]);
                Console.WriteLine("Description: {0}", productList[15][3]);
                Console.Write("Would you like to purchase one of these tables? (y/n): ");
            }
            else if (Validator.ParseFurnChoice(userFurnChoice) == FurnitureEnums.FurnitureEnums.UserFurnChoice.NOT_RECOGNIZED)
            {
                Console.WriteLine("Invalid Entry, please try again. Press Enter to continue.");
                Console.ReadLine();
                UserFurnChoice();
            }
        }
    }
}
