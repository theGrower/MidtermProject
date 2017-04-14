using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApp.Classes;
using StoreApp.FurnitureEnums;

namespace StoreApp.Methods
{
    enum pullsColor { black, brushed, chrome, silver }
    enum pullsStyle { bar, contemporary, cscape, jazz }
    enum legStyle { cscape, frameone, ology, tbase, unimas }
    enum color { black, blue, green, orange, pink, white }
    enum material { laminate, wood }
    enum fileType { pedestal, storage, tower }

    class UserDeskChoice
    {
        static void UserDeskiChoice() //these may need to be objects in the as they'll create the client's furniture && add to cart
        {
            string userDeskChoice = null;
            userDeskChoice = Console.ReadLine();
            if (Validator.ParceDeskChoice(userDeskChoice) == Classes.UserDeskChoice.ANSWER)
            {
                Console.Clear();
                Console.WriteLine("Our Answer desk has a few customizations. It can have a center drawere or not,");
                Console.WriteLine("selection of pull choices, desk color, and size.");
                Console.WriteLine("Your color choices are black, blue, green, orange, pink, white.");
                Console.Write("Please choose a color: ");
                var deskColor = Console.ReadLine();
                Console.WriteLine("Your pull style choices are bar, contemporary, cscape, jazz.");
                Console.WriteLine("Your pull color choices are black, brushed, chrome, silver");
                Console.Write("Please choose a pull style: ");
                var deskPullStyle = Console.ReadLine();
                Console.Write("Please choose a pull color: ");
                var deskPullColor = Console.ReadLine();
                Console.WriteLine("Would you like a center drawer? yes or no");
                var drawers = Console.ReadLine();
                Console.WriteLine("What depth size would you like? 24 or 30");
                var depth = Console.ReadLine();
                Console.WriteLine("What width size would you like? 48 or 60 ");
                var width = Console.ReadLine();
                //go through Drawers, depth, width like above and get the user's choice with a var VariableName = COnsole.Read....
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
