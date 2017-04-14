using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApp.Classes;

namespace StoreApp.Methods
{
    class UserFilesChoice
    {
        static void UserFilesiChoice() //these may need to be objects in the as they'll create the client's furniture && add to cart
        {
            string userFilesChoice = null;
            userFilesChoice = Console.ReadLine();
            if (Validator.ParceFilesChoice(userFilesChoice) == Classes.UserFilesChoice.PEDESTAL)
            {
                // go through Desks options
                Console.Clear();
            }
            else if (Validator.ParceFilesChoice(userFilesChoice) == Classes.UserFilesChoice.STORAGE)
            {
                // go through FIles options
                Console.Clear();
            }
            else if (Validator.ParceFilesChoice(userFilesChoice) == Classes.UserFilesChoice.TOWER)
            {
                // go through seating options
                Console.Clear();
            }
            else if (Validator.ParceFilesChoice(userFilesChoice) == Classes.UserFilesChoice.NOT_RECOGNIZED)
            {
                Console.Write("Invalid Entry, please try again: ");
                UserFilesiChoice();
            }
        }
    }
}
