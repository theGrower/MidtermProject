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

    class UserFilesChoice
    {
        static void UserFilesiChoice() //these may need to be objects in the as they'll create the client's furniture && add to cart
        {
            string userFilesChoice = null;
            userFilesChoice = Console.ReadLine();
            if (Validator.ParceFilesChoice(userFilesChoice) == Classes.UserFilesChoice.PEDESTAL)
            {
                Console.Clear();
                Console.WriteLine("Our Storage file has a few customizations.");
                Console.WriteLine("selection of file color, pull choices and pull color.");
                Console.WriteLine("Your color choices are black, blue, green, orange, pink, white.");
                Console.Write("Please choose a color: ");
                var deskColor = Console.ReadLine();
                Console.WriteLine("Your pull style choices are bar, contemporary, cscape, jazz.");
                Console.WriteLine("Your pull color choices are black, brushed, chrome, silver");
                Console.Write("Please choose a pull style: ");
                var deskPullStyle = Console.ReadLine();
                Console.Write("Please choose a pull color: ");
                var deskPullColor = Console.ReadLine();
                // go through Desks options
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
