using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApp.Classes;

namespace StoreApp.Methods
{
    class UserSeatChoice
    {
        static void UserSeatiChoice() //these may need to be objects in the as they'll create the client's furniture && add to cart
        {
            string userSeatChoice = null;
            userSeatChoice = Console.ReadLine();
            if (Validator.ParceSeatChoice(userSeatChoice) == Classes.UserSeatChoice.GESTURE)
            {
                // go through Desks options
                Console.Clear();
            }
            else if (Validator.ParceSeatChoice(userSeatChoice) == Classes.UserSeatChoice.LEAP)
            {
                // go through FIles options
                Console.Clear();
            }
            else if (Validator.ParceSeatChoice(userSeatChoice) == Classes.UserSeatChoice.NOBE)
            {
                // go through seating options
                Console.Clear();
            }
            else if (Validator.ParceSeatChoice(userSeatChoice) == Classes.UserSeatChoice.OBI)
            {
                // go through seating options
                Console.Clear();
            }
            else if (Validator.ParceSeatChoice(userSeatChoice) == Classes.UserSeatChoice.SENSOR)
            {
                // go through seating options
                Console.Clear();
            }
            else if (Validator.ParceSeatChoice(userSeatChoice) == Classes.UserSeatChoice.NOT_RECOGNIZED)
            {
                Console.Write("Invalid Entry, please try again: ");
                UserSeatiChoice();
            }
        }
    }
}
