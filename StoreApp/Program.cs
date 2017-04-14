using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApp.Classes;
using StoreApp.FurnitureEnums;
using System.IO;
using StoreApp.Methods;


namespace StoreApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Cart cart = new Classes.Cart();
            Greeting();
            UserFurnChoice();
            Console.Read();
        }

        static void Greeting()
        {
            Console.WriteLine("Hello! Thank you for visiting our furniture store! Our store offers office furniture designed with you in mind.");
            Console.WriteLine("We have a selection of desks, files, seating, and tables to meet your office needs. Let's get started! ");
        }

        static void ReturnText() //figure out how to return to various steps in the process... 
        {
            Console.WriteLine("");
        }

        static void UserFurnChoice() //these may need to be objects in the as they'll create the client's furniture && add to cart
        {
            Console.Write("Please type the catagory you would like to expore: \"desks\", \"files\", \"seating\", or \"table\": ");
            string userFurnChoice = null;
            userFurnChoice = Console.ReadLine();
            if (Validator.ParceFurnChoice(userFurnChoice) == Classes.UserFurnChoice.DESK)
            {
                UserDeskChoice();
                //Console.Clear();
                //var productList = File.ReadAllLines(@"C:\Git\MidtermProject\Furniture.txt").Select(l => l.Split('|')).ToArray();
                //Console.WriteLine("You've chosen to explore our desks! Here is a list of our desk selections.");
                //Console.WriteLine("Our {0} desk costs ${1}.", productList[0][1], productList[0][2]);
                //Console.WriteLine("Description: {0}", productList[0][3]);
                //Console.WriteLine("");
                //Console.WriteLine("Our {0} desk costs ${1}.", productList[1][1], productList[1][2]);
                //Console.WriteLine("Description: {0}", productList[1][3]);
                //Console.WriteLine("");
                //Console.WriteLine("Our {0} desk costs ${1}.", productList[2][1], productList[2][2]);
                //Console.WriteLine("Description: {0}", productList[2][3]);
                //Console.WriteLine("");
                //Console.WriteLine("Our {0} desk costs ${1}.", productList[3][1], productList[3][2]);
                //Console.WriteLine("Description: {0}", productList[3][3]);
                //Console.WriteLine("");
                //Console.Write("If you would like to purchase one of these desks simply type in the desk name, or \"no\" to go back: ");
                
            }
            else if (Validator.ParceFurnChoice(userFurnChoice) == Classes.UserFurnChoice.FILES)
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
            else if (Validator.ParceFurnChoice(userFurnChoice) == Classes.UserFurnChoice.SEATING)
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
            else if (Validator.ParceFurnChoice(userFurnChoice) == Classes.UserFurnChoice.TABLES)
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
            else if (Validator.ParceFurnChoice(userFurnChoice) == Classes.UserFurnChoice.NOT_RECOGNIZED)
            {
                Console.WriteLine("Invalid Entry, please try again.");
                UserFurnChoice();
            }
        }

        static void UserDeskChoice() //these may need to be objects in the as they'll create the client's furniture && add to cart
        {
            Console.Clear();
            var productList = File.ReadAllLines(@"C:\Git\MidtermProject\Furniture.txt").Select(l => l.Split('|')).ToArray();
            Console.WriteLine("You've chosen to explore our desks! Here is a list of our desk selections.");
            Console.WriteLine("Our {0} desk costs ${1}.", productList[0][1], productList[0][2]);
            Console.WriteLine("Description: {0}", productList[0][3]);
            Console.WriteLine("");
            Console.WriteLine("Our {0} desk costs ${1}.", productList[1][1], productList[1][2]);
            Console.WriteLine("Description: {0}", productList[1][3]);
            Console.WriteLine("");
            Console.WriteLine("Our {0} desk costs ${1}.", productList[2][1], productList[2][2]);
            Console.WriteLine("Description: {0}", productList[2][3]);
            Console.WriteLine("");
            Console.WriteLine("Our {0} desk costs ${1}.", productList[3][1], productList[3][2]);
            Console.WriteLine("Description: {0}", productList[3][3]);
            Console.WriteLine("");
            Console.Write("If you would like to purchase one of these desks simply type in the desk name, or \"no\" to go back: ");

            string userDeskChoice = Console.ReadLine();
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
            else if (Validator.ParceDeskChoice(userDeskChoice) == Classes.UserDeskChoice.NO)
            {
                Console.Clear();
                UserFurnChoice();
            }
            else if (Validator.ParceDeskChoice(userDeskChoice) == Classes.UserDeskChoice.NOT_RECOGNIZED)
            {
                Console.Write("Invalid Entry, please try again: ");
                UserDeskChoice();
            }
        }

        static void UserFilesChoice() //these may need to be objects in the as they'll create the client's furniture && add to cart
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
                UserFilesChoice();
            }
        }

        static void UserSeatChoice() //these may need to be objects in the as they'll create the client's furniture && add to cart
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
                UserSeatChoice();
            }
        }

        static void UserTablesChoice() //these may need to be objects in the as they'll create the client's furniture && add to cart
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
                UserTablesChoice();
            }
        }

        static List<Furniture> CreateArrays() //no longer using
        {
            //try
            //{
            StreamReader furnitureText;
            List<Furniture> productList = new List<Furniture>();
            string[] columns;
            string row;

            furnitureText = new StreamReader(new FileStream((@"C:\Git\MidtermProject\Furniture.txt"), FileMode.Open, FileAccess.Read));
            while (furnitureText.Peek() != -1)
            {
                row = furnitureText.ReadLine();
                columns = row.Split('|'); //still not working
                Furniture furniture = new Furniture();
                furniture.Type = columns[0];
                furniture.Name = columns[1];
                furniture.Price = decimal.Parse(columns[2]);
                furniture.Description = columns[3];
                productList.Add(furniture);
            }
            return productList;
            //}
            //finally
            //{
            //    furnitureText.Close();
            //}
        }
    }
}
