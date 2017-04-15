using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApp.Classes;

namespace StoreApp.Methods
{
    enum pullsColor { black, brushed, chrome, silver }
    enum pullsStyle { bar, contemporary, cscape, jazz }
    enum legStyle { cscape, frameone, ology, tbase, unimas }
    enum color { black, blue, green, orange, pink, white }
    enum material { laminate, wood }
    enum fileType { pedestal, storage, tower }

    // only need color, pull style, pull color 

    class FilesChoice
    {
        public static void UserFilesChoice() //these may need to be objects in the as they'll create the client's furniture && add to cart
        {
            string userFilesChoice = null;
            userFilesChoice = Console.ReadLine();
            if (Validator.ParseFilesChoice(userFilesChoice) == StoreApp.FurnitureEnums.FurnitureEnums.UserFilesChoice.PEDESTAL)
            {
                // go through Desks options
                Console.Clear();
            }
            else if (Validator.ParseFilesChoice(userFilesChoice) == StoreApp.FurnitureEnums.FurnitureEnums.UserFilesChoice.STORAGE)
            {
                // go through FIles options
                Console.Clear();
            }
            else if (Validator.ParseFilesChoice(userFilesChoice) == StoreApp.FurnitureEnums.FurnitureEnums.UserFilesChoice.TOWER)
            {
                // go through seating options
                Console.Clear();
            }
            else if (Validator.ParseFilesChoice(userFilesChoice) == StoreApp.FurnitureEnums.FurnitureEnums.UserFilesChoice.NOT_RECOGNIZED)
            {
                Console.Write("Invalid Entry, please try again: ");
                UserFilesChoice();
            }
        }
    }
}
