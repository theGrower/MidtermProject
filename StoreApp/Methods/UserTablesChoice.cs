﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApp.Classes;

namespace StoreApp.Methods
{
    class UserTablesChoice
    {
        static void UserTablesiChoice() //these may need to be objects in the as they'll create the client's furniture && add to cart
        {
            string userTablesChoice = null;
            userTablesChoice = Console.ReadLine();
            if (Validator.ParceTablesChoice(userTablesChoice) == Classes.UserTablesChoice.BALLET)
            {
                // go through Desks options
                Console.Clear();
            }
            else if (Validator.ParceTablesChoice(userTablesChoice) == Classes.UserTablesChoice.GLASS)
            {
                // go through FIles options
                Console.Clear();
            }
            else if (Validator.ParceTablesChoice(userTablesChoice) == Classes.UserTablesChoice.POTRERO)
            {
                // go through seating options
                Console.Clear();
            }
            else if (Validator.ParceTablesChoice(userTablesChoice) == Classes.UserTablesChoice.UNIVERSAL)
            {
                // go through seating options
                Console.Clear();
            }
            else if (Validator.ParceTablesChoice(userTablesChoice) == Classes.UserTablesChoice.NOT_RECOGNIZED)
            {
                Console.Write("Invalid Entry, please try again: ");
                UserTablesiChoice();
            }
        }
    }
}