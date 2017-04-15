using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApp.Classes;

namespace StoreApp.Methods
{
    class TablesChoice
    {
        public static void UserTablesChoice()
        {
            string userTablesChoice = null;
            userTablesChoice = Console.ReadLine();
            if (Validator.ParseTablesChoice(userTablesChoice) == StoreApp.FurnitureEnums.FurnitureEnums.UserTablesChoice.BALLET)
            {
                // go through Desks options
                Console.Clear();
            }
            else if (Validator.ParseTablesChoice(userTablesChoice) == StoreApp.FurnitureEnums.FurnitureEnums.UserTablesChoice.GLASS)
            {
                // go through FIles options
                Console.Clear();
            }
            else if (Validator.ParseTablesChoice(userTablesChoice) == StoreApp.FurnitureEnums.FurnitureEnums.UserTablesChoice.POTRERO)
            {
                // go through seating options
                Console.Clear();
            }
            else if (Validator.ParseTablesChoice(userTablesChoice) == StoreApp.FurnitureEnums.FurnitureEnums.UserTablesChoice.UNIVERSAL)
            {
                // go through seating options
                Console.Clear();
            }
            else if (Validator.ParseTablesChoice(userTablesChoice) == StoreApp.FurnitureEnums.FurnitureEnums.UserTablesChoice.NOT_RECOGNIZED)
            {
                Console.Write("Invalid Entry, please try again: ");
                UserTablesChoice();
            }
        }
    }
}
