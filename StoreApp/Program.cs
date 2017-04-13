using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApp.Classes;
using StoreApp.FurnitureEnums;
using System.IO;


namespace StoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateArrays(); // this method is broken 
            Cart cart = new Classes.Cart();
            Greeting();
            UserFurnChoice();
            Console.Read();
        }

        static void Greeting()
        {
            Console.WriteLine("Hello! Thank you for visiting our furniture store! Our store offers office furniture designed with you in mind.");
            Console.WriteLine("We have a selection of desks, files, seating, and tables to meet your office needs.");
            Console.WriteLine("Let's get started! Please type the catagory you would like to expore first: \"desks\", \"files\", \"seating\", or \"table\": ");
        }
        
        static void ReturnText() //figure out how to return to various steps in the process... 
        {
            Console.WriteLine("");
        }

        static void UserFurnChoice() //these may need to be objects in the as they'll create the client's furniture && add to cart
        {
            string userFurnChoice = null;
            userFurnChoice = Console.ReadLine();
            if (Validator.ParceFurnChoice(userFurnChoice) == Classes.UserFurnChoice.DESK)
            {
                // go through Desks options
                Console.Clear();
            }
            else if (Validator.ParceFurnChoice(userFurnChoice) == Classes.UserFurnChoice.FILES)
            {
                // go through FIles options
                Console.Clear();
            }
            else if (Validator.ParceFurnChoice(userFurnChoice) == Classes.UserFurnChoice.SEATING)
            {
                // go through seating options
                Console.Clear();
            }
            else if (Validator.ParceFurnChoice(userFurnChoice) == Classes.UserFurnChoice.TABLES)
            {
                // go through tables options
                Console.Clear();
            }
            else if (Validator.ParceFurnChoice(userFurnChoice) == Classes.UserFurnChoice.NOT_RECOGNIZED)
            {
                Console.Write("Invalid Entry, please try again: ");
                UserFurnChoice();
            }
        }

        static void UserDeskChoice() //these may need to be objects in the as they'll create the client's furniture && add to cart
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
                UserFilesChoice();
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
                UserFilesChoice();
            }
        }

        static List<Furniture> CreateArrays()
        {
            StreamReader furnitureText = null;
            List<Furniture> productList = new List<Furniture>();
            string[] columns = null;
            string row = null;
            
            furnitureText = new StreamReader(new FileStream((@"C:\Git\MidtermProject\Furniture.txt"), FileMode.Open, FileAccess.Read));
            while (furnitureText.Peek() !=1)
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
            furnitureText.Close();
        }

        static void DesksChoice()
        {
            var Desks = new List<string>();
            Console.WriteLine("You've chosen to explore our desks! Here is a list of our customizable desks.");
            foreach (var desk in Desks)
            {
                Console.WriteLine("put the list elements here {0} {1} {2} {3}");
                //will need validator for choices, then go though choices.... 
                //return to all tables, or all furniutre

            }
        }

        static void FilesChoice()
        {
            var Files = new List<string>();

            Console.WriteLine("You've chosen to explore our Files! Here is a list of our customizable Files.");
            foreach (var file in Files)
            {
                Console.WriteLine("put the list elements here {0} {1} {2} {3}");
                //will need validator for choices, then go though choices.... 
                //return to all tables, or all furniutre

            }
        }

        static void SeatingChoice()
        {
            var Seating = new List<string>();

            Console.WriteLine("You've chosen to explore our seating! Here is a list of our customizable seating.");
            foreach (var seating in Seating)
            {
                Console.WriteLine("put the list elements here {0} {1} {2} {3}");
                //will need validator for choices, then go though choices.... 
                //return to all tables, or all furniutre

            }
        }

        static void TablesChoice()
        {
            var Tables = new List<string>();

            Console.WriteLine("You've chosen to explore our tables! Here is a list of our customizable tables.");
            foreach (var tables in Tables)
            {
                Console.WriteLine("put the list elements here {0} {1} {2} {3}");
                //will need validator for choices, then go though choices.... 
                //return to all tables, or all furniutre
            }
        }

    }
}
