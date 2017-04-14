using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApp.Classes;

namespace StoreApp.Methods
{
    class UserDeskChoice
    {
        static void UserDeskiChoice() //these may need to be objects in the as they'll create the client's furniture && add to cart
        {
            string userDeskChoice = null;
            userDeskChoice = Console.ReadLine();
            if (Validator.ParceDeskChoice(userDeskChoice) == Classes.UserDeskChoice.ANSWER)
            {
                // go through Desks options
                Console.Clear();
            }
            else if (Validator.ParceDeskChoice(userDeskChoice) == Classes.UserDeskChoice.CSCAPE)
            {
                // go through FIles options
                Console.Clear();
            }
            else if (Validator.ParceDeskChoice(userDeskChoice) == Classes.UserDeskChoice.FRAME)
            {
                // go through seating options
                Console.Clear();
            }
            else if (Validator.ParceDeskChoice(userDeskChoice) == Classes.UserDeskChoice.OLOGY)
            {
                // go through tables options
                Console.Clear();
            }
            else if (Validator.ParceDeskChoice(userDeskChoice) == Classes.UserDeskChoice.NOT_RECOGNIZED)
            {
                Console.Write("Invalid Entry, please try again: ");
                UserDeskiChoice();
            }
        }
    }
}
