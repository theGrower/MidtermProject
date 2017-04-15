using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApp.Classes;
using StoreApp.FurnitureEnums;
using System.IO;

namespace StoreApp.Methods
{
    class DeskChoice
    {
        public void UserDeskChoice()
        {
            Console.Clear();
            var productList = File.ReadAllLines(@"C:\Git\MidtermProject\Furniture.txt").Select(l => l.Split('|')).ToArray();
            Console.WriteLine("You've chosen to explore our desks! Here is a list of our desk selections.");
            Console.WriteLine();
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
            if (Validator.ParseDeskChoice(userDeskChoice) == FurnitureEnums.FurnitureEnums.UserDeskChoice.ANSWER)
            {
                string deskColor;
                string deskPullsStyle;
                string deskPullsColor;
                string deskDrawer;
                string deskWidth;
                string deskDepth;
                var userDeskColor = FurnitureEnums.FurnitureEnums.color.NOT_RECOGNIZED;
                var userDeskPullsStyle = FurnitureEnums.FurnitureEnums.pullsStyle.NOT_RECOGNIZED;
                var userDeskPullsColor = FurnitureEnums.FurnitureEnums.pullsColor.NOT_RECOGNIZED;
                var userDeskDrawer = FurnitureEnums.FurnitureEnums.DeskCenterDrawer.NOT_RECOGNIZED;
                var userDeskWidth = FurnitureEnums.FurnitureEnums.DeskWidth.NOT_RECOGNIZED;
                var userDeskDepth = FurnitureEnums.FurnitureEnums.DeskDepth.NOT_RECOGNIZED;

                Console.Clear();
                Console.WriteLine("Our Answer desk has a few customizations: desk color, selection of pull choices, center drawer, and size.");
                Console.WriteLine("Your color choices are black, blue, green, orange, pink, white.");
                while (userDeskColor == FurnitureEnums.FurnitureEnums.color.NOT_RECOGNIZED)
                {
                    Console.Write("Please choose a color:  ");
                    deskColor = Console.ReadLine();
                    if (Validator.ParseColorChoice(deskColor) == FurnitureEnums.FurnitureEnums.color.black)
                    {
                        userDeskColor = FurnitureEnums.FurnitureEnums.color.black;
                    }
                    else if (Validator.ParseColorChoice(deskColor) == FurnitureEnums.FurnitureEnums.color.blue)
                    {
                        userDeskColor = FurnitureEnums.FurnitureEnums.color.blue;
                    }
                    else if (Validator.ParseColorChoice(deskColor) == FurnitureEnums.FurnitureEnums.color.green)
                    {
                        userDeskColor = FurnitureEnums.FurnitureEnums.color.green;
                    }
                    else if (Validator.ParseColorChoice(deskColor) == FurnitureEnums.FurnitureEnums.color.pink)
                    {
                        userDeskColor = FurnitureEnums.FurnitureEnums.color.pink;
                    }
                    else if (Validator.ParseColorChoice(deskColor) == FurnitureEnums.FurnitureEnums.color.orange)
                    {
                        userDeskColor = FurnitureEnums.FurnitureEnums.color.orange;
                    }
                    else if (Validator.ParseColorChoice(deskColor) == FurnitureEnums.FurnitureEnums.color.white)
                    {
                        userDeskColor = FurnitureEnums.FurnitureEnums.color.white;
                    }
                    else
                    {
                        Console.WriteLine("Try Again.");
                    }
                }
                
                Console.WriteLine("Your pull style choices are bar, contemporary, cscape, jazz.");
                Console.WriteLine("Your pull color choices are black, brushed, chrome, silver");
                while (userDeskPullsStyle == FurnitureEnums.FurnitureEnums.pullsStyle.NOT_RECOGNIZED)
                {
                    Console.Write("Please choose a pull style: ");
                    deskPullsStyle = Console.ReadLine(); // bar, contemporary, cscape, jazz, NOT_RECOGNIZED 
                    if (Validator.ParsePullsStyle(deskPullsStyle) == FurnitureEnums.FurnitureEnums.pullsStyle.bar)
                    {
                        userDeskPullsStyle = FurnitureEnums.FurnitureEnums.pullsStyle.bar;
                    }
                    else if (Validator.ParsePullsStyle(deskPullsStyle) == FurnitureEnums.FurnitureEnums.pullsStyle.contemporary)
                    {
                        userDeskPullsStyle = FurnitureEnums.FurnitureEnums.pullsStyle.contemporary;
                    }
                    else if (Validator.ParsePullsStyle(deskPullsStyle) == FurnitureEnums.FurnitureEnums.pullsStyle.cscape)
                    {
                        userDeskPullsStyle = FurnitureEnums.FurnitureEnums.pullsStyle.cscape;
                    }
                    else if (Validator.ParsePullsStyle(deskPullsStyle) == FurnitureEnums.FurnitureEnums.pullsStyle.jazz)
                    {
                        userDeskPullsStyle = FurnitureEnums.FurnitureEnums.pullsStyle.cscape;
                    }
                    else
                    {
                        Console.WriteLine("Try Again.");
                    }
                }
                while (userDeskPullsColor == FurnitureEnums.FurnitureEnums.pullsColor.NOT_RECOGNIZED)
                {
                    Console.Write("Please choose a pull color: ");
                    deskPullsColor = Console.ReadLine();
                    if (Validator.ParsePullsColor(deskPullsColor) == FurnitureEnums.FurnitureEnums.pullsColor.black)
                    {
                        userDeskPullsColor = FurnitureEnums.FurnitureEnums.pullsColor.black;
                    }
                    else if (Validator.ParsePullsColor(deskPullsColor) == FurnitureEnums.FurnitureEnums.pullsColor.brushed)
                    {
                        userDeskPullsColor = FurnitureEnums.FurnitureEnums.pullsColor.brushed;
                    }
                    else if(Validator.ParsePullsColor(deskPullsColor) == FurnitureEnums.FurnitureEnums.pullsColor.chrome)
                    {
                        userDeskPullsColor = FurnitureEnums.FurnitureEnums.pullsColor.chrome;
                    }
                    else if(Validator.ParsePullsColor(deskPullsColor) == FurnitureEnums.FurnitureEnums.pullsColor.silver)
                    {
                        userDeskPullsColor = FurnitureEnums.FurnitureEnums.pullsColor.silver;
                    }
                    else
                    {
                        Console.WriteLine("Try Again.");
                    }                    
                }
                while (userDeskDrawer == FurnitureEnums.FurnitureEnums.DeskCenterDrawer.NOT_RECOGNIZED)
                {
                    Console.WriteLine("Would you like a center drawer? yes or no");
                    deskDrawer = Console.ReadLine();
                    if (Validator.ParseCenterDrawer(deskDrawer) == FurnitureEnums.FurnitureEnums.DeskCenterDrawer.YES)
                    {
                        userDeskDrawer = FurnitureEnums.FurnitureEnums.DeskCenterDrawer.YES;
                    }
                    else if (Validator.ParseCenterDrawer(deskDrawer) == FurnitureEnums.FurnitureEnums.DeskCenterDrawer.NO)
                    {
                        userDeskDrawer = FurnitureEnums.FurnitureEnums.DeskCenterDrawer.NO;
                    }
                    else
                    {
                        Console.WriteLine("Try Again.");
                    }
                }
                while (userDeskDepth == FurnitureEnums.FurnitureEnums.DeskDepth.NOT_RECOGNIZED)
                {
                    Console.WriteLine("What depth size would you like? 24 or 30");
                    deskDepth = Console.ReadLine();
                    if (Validator.ParseDeskDept(deskDepth) == FurnitureEnums.FurnitureEnums.DeskDepth._24)
                    {
                        userDeskDepth = FurnitureEnums.FurnitureEnums.DeskDepth._24;
                    }
                    else if (Validator.ParseDeskDept(deskDepth) == FurnitureEnums.FurnitureEnums.DeskDepth._36)
                    {
                        userDeskDepth = FurnitureEnums.FurnitureEnums.DeskDepth._36;
                    }
                    else
                    {
                        Console.WriteLine("Try Again.");
                    }
                }
                while (userDeskWidth == FurnitureEnums.FurnitureEnums.DeskWidth.NOT_RECOGNIZED)
                {
                    Console.WriteLine("What width size would you like? 48 or 60 ");
                    deskWidth = Console.ReadLine();
                    if (Validator.ParseDeskWidth(deskWidth) == FurnitureEnums.FurnitureEnums.DeskWidth._48)
                    {
                        userDeskWidth = FurnitureEnums.FurnitureEnums.DeskWidth._48;
                    }
                    else if (Validator.ParseDeskWidth(deskWidth) == FurnitureEnums.FurnitureEnums.DeskWidth._60)
                    {
                        userDeskWidth = FurnitureEnums.FurnitureEnums.DeskWidth._60;
                    }
                    else
                    {
                        Console.WriteLine("Try Again.");
                    }
                }
                Desk AnswerDesk = new Desk(productList[0][1], decimal.Parse(productList[0][2]), productList[0][3], (int)userDeskDrawer, 
                    (int)userDeskPullsStyle, (int)userDeskPullsColor, (int)userDeskColor, (int)userDeskDepth, (int)userDeskWidth);
                Cart.AddToCart(AnswerDesk);
            }
            else if (Validator.ParseDeskChoice(userDeskChoice) == FurnitureEnums.FurnitureEnums.UserDeskChoice.CSCAPE)
            {
                string deskColor;
                string deskPullsStyle;
                string deskPullsColor;
                string deskDrawer;
                string deskWidth;
                string deskDepth;
                var userDeskColor = FurnitureEnums.FurnitureEnums.color.NOT_RECOGNIZED;
                var userDeskPullsStyle = FurnitureEnums.FurnitureEnums.pullsStyle.NOT_RECOGNIZED;
                var userDeskPullsColor = FurnitureEnums.FurnitureEnums.pullsColor.NOT_RECOGNIZED;
                var userDeskDrawer = FurnitureEnums.FurnitureEnums.DeskCenterDrawer.NOT_RECOGNIZED;
                var userDeskWidth = FurnitureEnums.FurnitureEnums.DeskWidth.NOT_RECOGNIZED;
                var userDeskDepth = FurnitureEnums.FurnitureEnums.DeskDepth.NOT_RECOGNIZED;

                Console.Clear();
                Console.WriteLine("Our Answer desk has a few customizations: desk color, selection of pull choices, center drawer, and size.");
                Console.WriteLine("Your color choices are black, blue, green, orange, pink, white.");
                while (userDeskColor == FurnitureEnums.FurnitureEnums.color.NOT_RECOGNIZED)
                {
                    Console.Write("Please choose a color:  ");
                    deskColor = Console.ReadLine();
                    if (Validator.ParseColorChoice(deskColor) == FurnitureEnums.FurnitureEnums.color.black)
                    {
                        userDeskColor = FurnitureEnums.FurnitureEnums.color.black;
                    }
                    else if (Validator.ParseColorChoice(deskColor) == FurnitureEnums.FurnitureEnums.color.blue)
                    {
                        userDeskColor = FurnitureEnums.FurnitureEnums.color.blue;
                    }
                    else if (Validator.ParseColorChoice(deskColor) == FurnitureEnums.FurnitureEnums.color.green)
                    {
                        userDeskColor = FurnitureEnums.FurnitureEnums.color.green;
                    }
                    else if (Validator.ParseColorChoice(deskColor) == FurnitureEnums.FurnitureEnums.color.pink)
                    {
                        userDeskColor = FurnitureEnums.FurnitureEnums.color.pink;
                    }
                    else if (Validator.ParseColorChoice(deskColor) == FurnitureEnums.FurnitureEnums.color.orange)
                    {
                        userDeskColor = FurnitureEnums.FurnitureEnums.color.orange;
                    }
                    else if (Validator.ParseColorChoice(deskColor) == FurnitureEnums.FurnitureEnums.color.white)
                    {
                        userDeskColor = FurnitureEnums.FurnitureEnums.color.white;
                    }
                    else
                    {
                        Console.WriteLine("Try Again.");
                    }
                }

                Console.WriteLine("Your pull style choices are bar, contemporary, cscape, jazz.");
                Console.WriteLine("Your pull color choices are black, brushed, chrome, silver");
                while (userDeskPullsStyle == FurnitureEnums.FurnitureEnums.pullsStyle.NOT_RECOGNIZED)
                {
                    Console.Write("Please choose a pull style: ");
                    deskPullsStyle = Console.ReadLine(); // bar, contemporary, cscape, jazz, NOT_RECOGNIZED 
                    if (Validator.ParsePullsStyle(deskPullsStyle) == FurnitureEnums.FurnitureEnums.pullsStyle.bar)
                    {
                        userDeskPullsStyle = FurnitureEnums.FurnitureEnums.pullsStyle.bar;
                    }
                    else if (Validator.ParsePullsStyle(deskPullsStyle) == FurnitureEnums.FurnitureEnums.pullsStyle.contemporary)
                    {
                        userDeskPullsStyle = FurnitureEnums.FurnitureEnums.pullsStyle.contemporary;
                    }
                    else if (Validator.ParsePullsStyle(deskPullsStyle) == FurnitureEnums.FurnitureEnums.pullsStyle.cscape)
                    {
                        userDeskPullsStyle = FurnitureEnums.FurnitureEnums.pullsStyle.cscape;
                    }
                    else if (Validator.ParsePullsStyle(deskPullsStyle) == FurnitureEnums.FurnitureEnums.pullsStyle.jazz)
                    {
                        userDeskPullsStyle = FurnitureEnums.FurnitureEnums.pullsStyle.cscape;
                    }
                    else
                    {
                        Console.WriteLine("Try Again.");
                    }
                }
                while (userDeskPullsColor == FurnitureEnums.FurnitureEnums.pullsColor.NOT_RECOGNIZED)
                {
                    Console.Write("Please choose a pull color: ");
                    deskPullsColor = Console.ReadLine();
                    if (Validator.ParsePullsColor(deskPullsColor) == FurnitureEnums.FurnitureEnums.pullsColor.black)
                    {
                        userDeskPullsColor = FurnitureEnums.FurnitureEnums.pullsColor.black;
                    }
                    else if (Validator.ParsePullsColor(deskPullsColor) == FurnitureEnums.FurnitureEnums.pullsColor.brushed)
                    {
                        userDeskPullsColor = FurnitureEnums.FurnitureEnums.pullsColor.brushed;
                    }
                    else if (Validator.ParsePullsColor(deskPullsColor) == FurnitureEnums.FurnitureEnums.pullsColor.chrome)
                    {
                        userDeskPullsColor = FurnitureEnums.FurnitureEnums.pullsColor.chrome;
                    }
                    else if (Validator.ParsePullsColor(deskPullsColor) == FurnitureEnums.FurnitureEnums.pullsColor.silver)
                    {
                        userDeskPullsColor = FurnitureEnums.FurnitureEnums.pullsColor.silver;
                    }
                    else
                    {
                        Console.WriteLine("Try Again.");
                    }
                }
                while (userDeskDrawer == FurnitureEnums.FurnitureEnums.DeskCenterDrawer.NOT_RECOGNIZED)
                {
                    Console.WriteLine("Would you like a center drawer? yes or no");
                    deskDrawer = Console.ReadLine();
                    if (Validator.ParseCenterDrawer(deskDrawer) == FurnitureEnums.FurnitureEnums.DeskCenterDrawer.YES)
                    {
                        userDeskDrawer = FurnitureEnums.FurnitureEnums.DeskCenterDrawer.YES;
                    }
                    else if (Validator.ParseCenterDrawer(deskDrawer) == FurnitureEnums.FurnitureEnums.DeskCenterDrawer.NO)
                    {
                        userDeskDrawer = FurnitureEnums.FurnitureEnums.DeskCenterDrawer.NO;
                    }
                    else
                    {
                        Console.WriteLine("Try Again.");
                    }
                }
                while (userDeskDepth == FurnitureEnums.FurnitureEnums.DeskDepth.NOT_RECOGNIZED)
                {
                    Console.WriteLine("What depth size would you like? 24 or 30");
                    deskDepth = Console.ReadLine();
                    if (Validator.ParseDeskDept(deskDepth) == FurnitureEnums.FurnitureEnums.DeskDepth._24)
                    {
                        userDeskDepth = FurnitureEnums.FurnitureEnums.DeskDepth._24;
                    }
                    else if (Validator.ParseDeskDept(deskDepth) == FurnitureEnums.FurnitureEnums.DeskDepth._36)
                    {
                        userDeskDepth = FurnitureEnums.FurnitureEnums.DeskDepth._36;
                    }
                    else
                    {
                        Console.WriteLine("Try Again.");
                    }
                }
                while (userDeskWidth == FurnitureEnums.FurnitureEnums.DeskWidth.NOT_RECOGNIZED)
                {
                    Console.WriteLine("What width size would you like? 48 or 60 ");
                    deskWidth = Console.ReadLine();
                    if (Validator.ParseDeskWidth(deskWidth) == FurnitureEnums.FurnitureEnums.DeskWidth._48)
                    {
                        userDeskWidth = FurnitureEnums.FurnitureEnums.DeskWidth._48;
                    }
                    else if (Validator.ParseDeskWidth(deskWidth) == FurnitureEnums.FurnitureEnums.DeskWidth._60)
                    {
                        userDeskWidth = FurnitureEnums.FurnitureEnums.DeskWidth._60;
                    }
                    else
                    {
                        Console.WriteLine("Try Again.");
                    }
                }
                Desk CScape = new Desk(productList[0][1], decimal.Parse(productList[0][2]), productList[0][3], (int)userDeskDrawer,
                    (int)userDeskPullsStyle, (int)userDeskPullsColor, (int)userDeskColor, (int)userDeskDepth, (int)userDeskWidth);
            }
            else if (Validator.ParseDeskChoice(userDeskChoice) == FurnitureEnums.FurnitureEnums.UserDeskChoice.FRAME)
            {
                string deskColor;
                string deskPullsStyle;
                string deskPullsColor;
                string deskDrawer;
                string deskWidth;
                string deskDepth;
                var userDeskColor = FurnitureEnums.FurnitureEnums.color.NOT_RECOGNIZED;
                var userDeskPullsStyle = FurnitureEnums.FurnitureEnums.pullsStyle.NOT_RECOGNIZED;
                var userDeskPullsColor = FurnitureEnums.FurnitureEnums.pullsColor.NOT_RECOGNIZED;
                var userDeskDrawer = FurnitureEnums.FurnitureEnums.DeskCenterDrawer.NOT_RECOGNIZED;
                var userDeskWidth = FurnitureEnums.FurnitureEnums.DeskWidth.NOT_RECOGNIZED;
                var userDeskDepth = FurnitureEnums.FurnitureEnums.DeskDepth.NOT_RECOGNIZED;

                Console.Clear();
                Console.WriteLine("Our Answer desk has a few customizations: desk color, selection of pull choices, center drawer, and size.");
                Console.WriteLine("Your color choices are black, blue, green, orange, pink, white.");
                while (userDeskColor == FurnitureEnums.FurnitureEnums.color.NOT_RECOGNIZED)
                {
                    Console.Write("Please choose a color:  ");
                    deskColor = Console.ReadLine();
                    if (Validator.ParseColorChoice(deskColor) == FurnitureEnums.FurnitureEnums.color.black)
                    {
                        userDeskColor = FurnitureEnums.FurnitureEnums.color.black;
                    }
                    else if (Validator.ParseColorChoice(deskColor) == FurnitureEnums.FurnitureEnums.color.blue)
                    {
                        userDeskColor = FurnitureEnums.FurnitureEnums.color.blue;
                    }
                    else if (Validator.ParseColorChoice(deskColor) == FurnitureEnums.FurnitureEnums.color.green)
                    {
                        userDeskColor = FurnitureEnums.FurnitureEnums.color.green;
                    }
                    else if (Validator.ParseColorChoice(deskColor) == FurnitureEnums.FurnitureEnums.color.pink)
                    {
                        userDeskColor = FurnitureEnums.FurnitureEnums.color.pink;
                    }
                    else if (Validator.ParseColorChoice(deskColor) == FurnitureEnums.FurnitureEnums.color.orange)
                    {
                        userDeskColor = FurnitureEnums.FurnitureEnums.color.orange;
                    }
                    else if (Validator.ParseColorChoice(deskColor) == FurnitureEnums.FurnitureEnums.color.white)
                    {
                        userDeskColor = FurnitureEnums.FurnitureEnums.color.white;
                    }
                    else
                    {
                        Console.WriteLine("Try Again.");
                    }
                }

                Console.WriteLine("Your pull style choices are bar, contemporary, cscape, jazz.");
                Console.WriteLine("Your pull color choices are black, brushed, chrome, silver");
                while (userDeskPullsStyle == FurnitureEnums.FurnitureEnums.pullsStyle.NOT_RECOGNIZED)
                {
                    Console.Write("Please choose a pull style: ");
                    deskPullsStyle = Console.ReadLine(); // bar, contemporary, cscape, jazz, NOT_RECOGNIZED 
                    if (Validator.ParsePullsStyle(deskPullsStyle) == FurnitureEnums.FurnitureEnums.pullsStyle.bar)
                    {
                        userDeskPullsStyle = FurnitureEnums.FurnitureEnums.pullsStyle.bar;
                    }
                    else if (Validator.ParsePullsStyle(deskPullsStyle) == FurnitureEnums.FurnitureEnums.pullsStyle.contemporary)
                    {
                        userDeskPullsStyle = FurnitureEnums.FurnitureEnums.pullsStyle.contemporary;
                    }
                    else if (Validator.ParsePullsStyle(deskPullsStyle) == FurnitureEnums.FurnitureEnums.pullsStyle.cscape)
                    {
                        userDeskPullsStyle = FurnitureEnums.FurnitureEnums.pullsStyle.cscape;
                    }
                    else if (Validator.ParsePullsStyle(deskPullsStyle) == FurnitureEnums.FurnitureEnums.pullsStyle.jazz)
                    {
                        userDeskPullsStyle = FurnitureEnums.FurnitureEnums.pullsStyle.cscape;
                    }
                    else
                    {
                        Console.WriteLine("Try Again.");
                    }
                }
                while (userDeskPullsColor == FurnitureEnums.FurnitureEnums.pullsColor.NOT_RECOGNIZED)
                {
                    Console.Write("Please choose a pull color: ");
                    deskPullsColor = Console.ReadLine();
                    if (Validator.ParsePullsColor(deskPullsColor) == FurnitureEnums.FurnitureEnums.pullsColor.black)
                    {
                        userDeskPullsColor = FurnitureEnums.FurnitureEnums.pullsColor.black;
                    }
                    else if (Validator.ParsePullsColor(deskPullsColor) == FurnitureEnums.FurnitureEnums.pullsColor.brushed)
                    {
                        userDeskPullsColor = FurnitureEnums.FurnitureEnums.pullsColor.brushed;
                    }
                    else if (Validator.ParsePullsColor(deskPullsColor) == FurnitureEnums.FurnitureEnums.pullsColor.chrome)
                    {
                        userDeskPullsColor = FurnitureEnums.FurnitureEnums.pullsColor.chrome;
                    }
                    else if (Validator.ParsePullsColor(deskPullsColor) == FurnitureEnums.FurnitureEnums.pullsColor.silver)
                    {
                        userDeskPullsColor = FurnitureEnums.FurnitureEnums.pullsColor.silver;
                    }
                    else
                    {
                        Console.WriteLine("Try Again.");
                    }
                }
                while (userDeskDrawer == FurnitureEnums.FurnitureEnums.DeskCenterDrawer.NOT_RECOGNIZED)
                {
                    Console.WriteLine("Would you like a center drawer? yes or no");
                    deskDrawer = Console.ReadLine();
                    if (Validator.ParseCenterDrawer(deskDrawer) == FurnitureEnums.FurnitureEnums.DeskCenterDrawer.YES)
                    {
                        userDeskDrawer = FurnitureEnums.FurnitureEnums.DeskCenterDrawer.YES;
                    }
                    else if (Validator.ParseCenterDrawer(deskDrawer) == FurnitureEnums.FurnitureEnums.DeskCenterDrawer.NO)
                    {
                        userDeskDrawer = FurnitureEnums.FurnitureEnums.DeskCenterDrawer.NO;
                    }
                    else
                    {
                        Console.WriteLine("Try Again.");
                    }
                }
                while (userDeskDepth == FurnitureEnums.FurnitureEnums.DeskDepth.NOT_RECOGNIZED)
                {
                    Console.WriteLine("What depth size would you like? 24 or 30");
                    deskDepth = Console.ReadLine();
                    if (Validator.ParseDeskDept(deskDepth) == FurnitureEnums.FurnitureEnums.DeskDepth._24)
                    {
                        userDeskDepth = FurnitureEnums.FurnitureEnums.DeskDepth._24;
                    }
                    else if (Validator.ParseDeskDept(deskDepth) == FurnitureEnums.FurnitureEnums.DeskDepth._36)
                    {
                        userDeskDepth = FurnitureEnums.FurnitureEnums.DeskDepth._36;
                    }
                    else
                    {
                        Console.WriteLine("Try Again.");
                    }
                }
                while (userDeskWidth == FurnitureEnums.FurnitureEnums.DeskWidth.NOT_RECOGNIZED)
                {
                    Console.WriteLine("What width size would you like? 48 or 60 ");
                    deskWidth = Console.ReadLine();
                    if (Validator.ParseDeskWidth(deskWidth) == FurnitureEnums.FurnitureEnums.DeskWidth._48)
                    {
                        userDeskWidth = FurnitureEnums.FurnitureEnums.DeskWidth._48;
                    }
                    else if (Validator.ParseDeskWidth(deskWidth) == FurnitureEnums.FurnitureEnums.DeskWidth._60)
                    {
                        userDeskWidth = FurnitureEnums.FurnitureEnums.DeskWidth._60;
                    }
                    else
                    {
                        Console.WriteLine("Try Again.");
                    }
                }
                Desk Frame = new Desk(productList[0][1], decimal.Parse(productList[0][2]), productList[0][3], (int)userDeskDrawer,
                    (int)userDeskPullsStyle, (int)userDeskPullsColor, (int)userDeskColor, (int)userDeskDepth, (int)userDeskWidth);
            }
            else if (Validator.ParseDeskChoice(userDeskChoice) == FurnitureEnums.FurnitureEnums.UserDeskChoice.OLOGY)
            {
                string deskColor;
                string deskPullsStyle;
                string deskPullsColor;
                string deskDrawer;
                string deskWidth;
                string deskDepth;
                var userDeskColor = FurnitureEnums.FurnitureEnums.color.NOT_RECOGNIZED;
                var userDeskPullsStyle = FurnitureEnums.FurnitureEnums.pullsStyle.NOT_RECOGNIZED;
                var userDeskPullsColor = FurnitureEnums.FurnitureEnums.pullsColor.NOT_RECOGNIZED;
                var userDeskDrawer = FurnitureEnums.FurnitureEnums.DeskCenterDrawer.NOT_RECOGNIZED;
                var userDeskWidth = FurnitureEnums.FurnitureEnums.DeskWidth.NOT_RECOGNIZED;
                var userDeskDepth = FurnitureEnums.FurnitureEnums.DeskDepth.NOT_RECOGNIZED;

                Console.Clear();
                Console.WriteLine("Our Answer desk has a few customizations: desk color, selection of pull choices, center drawer, and size.");
                Console.WriteLine("Your color choices are black, blue, green, orange, pink, white.");
                while (userDeskColor == FurnitureEnums.FurnitureEnums.color.NOT_RECOGNIZED)
                {
                    Console.Write("Please choose a color:  ");
                    deskColor = Console.ReadLine();
                    if (Validator.ParseColorChoice(deskColor) == FurnitureEnums.FurnitureEnums.color.black)
                    {
                        userDeskColor = FurnitureEnums.FurnitureEnums.color.black;
                    }
                    else if (Validator.ParseColorChoice(deskColor) == FurnitureEnums.FurnitureEnums.color.blue)
                    {
                        userDeskColor = FurnitureEnums.FurnitureEnums.color.blue;
                    }
                    else if (Validator.ParseColorChoice(deskColor) == FurnitureEnums.FurnitureEnums.color.green)
                    {
                        userDeskColor = FurnitureEnums.FurnitureEnums.color.green;
                    }
                    else if (Validator.ParseColorChoice(deskColor) == FurnitureEnums.FurnitureEnums.color.pink)
                    {
                        userDeskColor = FurnitureEnums.FurnitureEnums.color.pink;
                    }
                    else if (Validator.ParseColorChoice(deskColor) == FurnitureEnums.FurnitureEnums.color.orange)
                    {
                        userDeskColor = FurnitureEnums.FurnitureEnums.color.orange;
                    }
                    else if (Validator.ParseColorChoice(deskColor) == FurnitureEnums.FurnitureEnums.color.white)
                    {
                        userDeskColor = FurnitureEnums.FurnitureEnums.color.white;
                    }
                    else
                    {
                        Console.WriteLine("Try Again.");
                    }
                }

                Console.WriteLine("Your pull style choices are bar, contemporary, cscape, jazz.");
                Console.WriteLine("Your pull color choices are black, brushed, chrome, silver");
                while (userDeskPullsStyle == FurnitureEnums.FurnitureEnums.pullsStyle.NOT_RECOGNIZED)
                {
                    Console.Write("Please choose a pull style: ");
                    deskPullsStyle = Console.ReadLine(); // bar, contemporary, cscape, jazz, NOT_RECOGNIZED 
                    if (Validator.ParsePullsStyle(deskPullsStyle) == FurnitureEnums.FurnitureEnums.pullsStyle.bar)
                    {
                        userDeskPullsStyle = FurnitureEnums.FurnitureEnums.pullsStyle.bar;
                    }
                    else if (Validator.ParsePullsStyle(deskPullsStyle) == FurnitureEnums.FurnitureEnums.pullsStyle.contemporary)
                    {
                        userDeskPullsStyle = FurnitureEnums.FurnitureEnums.pullsStyle.contemporary;
                    }
                    else if (Validator.ParsePullsStyle(deskPullsStyle) == FurnitureEnums.FurnitureEnums.pullsStyle.cscape)
                    {
                        userDeskPullsStyle = FurnitureEnums.FurnitureEnums.pullsStyle.cscape;
                    }
                    else if (Validator.ParsePullsStyle(deskPullsStyle) == FurnitureEnums.FurnitureEnums.pullsStyle.jazz)
                    {
                        userDeskPullsStyle = FurnitureEnums.FurnitureEnums.pullsStyle.cscape;
                    }
                    else
                    {
                        Console.WriteLine("Try Again.");
                    }
                }
                while (userDeskPullsColor == FurnitureEnums.FurnitureEnums.pullsColor.NOT_RECOGNIZED)
                {
                    Console.Write("Please choose a pull color: ");
                    deskPullsColor = Console.ReadLine();
                    if (Validator.ParsePullsColor(deskPullsColor) == FurnitureEnums.FurnitureEnums.pullsColor.black)
                    {
                        userDeskPullsColor = FurnitureEnums.FurnitureEnums.pullsColor.black;
                    }
                    else if (Validator.ParsePullsColor(deskPullsColor) == FurnitureEnums.FurnitureEnums.pullsColor.brushed)
                    {
                        userDeskPullsColor = FurnitureEnums.FurnitureEnums.pullsColor.brushed;
                    }
                    else if (Validator.ParsePullsColor(deskPullsColor) == FurnitureEnums.FurnitureEnums.pullsColor.chrome)
                    {
                        userDeskPullsColor = FurnitureEnums.FurnitureEnums.pullsColor.chrome;
                    }
                    else if (Validator.ParsePullsColor(deskPullsColor) == FurnitureEnums.FurnitureEnums.pullsColor.silver)
                    {
                        userDeskPullsColor = FurnitureEnums.FurnitureEnums.pullsColor.silver;
                    }
                    else
                    {
                        Console.WriteLine("Try Again.");
                    }
                }
                while (userDeskDrawer == FurnitureEnums.FurnitureEnums.DeskCenterDrawer.NOT_RECOGNIZED)
                {
                    Console.WriteLine("Would you like a center drawer? yes or no");
                    deskDrawer = Console.ReadLine();
                    if (Validator.ParseCenterDrawer(deskDrawer) == FurnitureEnums.FurnitureEnums.DeskCenterDrawer.YES)
                    {
                        userDeskDrawer = FurnitureEnums.FurnitureEnums.DeskCenterDrawer.YES;
                    }
                    else if (Validator.ParseCenterDrawer(deskDrawer) == FurnitureEnums.FurnitureEnums.DeskCenterDrawer.NO)
                    {
                        userDeskDrawer = FurnitureEnums.FurnitureEnums.DeskCenterDrawer.NO;
                    }
                    else
                    {
                        Console.WriteLine("Try Again.");
                    }
                }
                while (userDeskDepth == FurnitureEnums.FurnitureEnums.DeskDepth.NOT_RECOGNIZED)
                {
                    Console.WriteLine("What depth size would you like? 24 or 30");
                    deskDepth = Console.ReadLine();
                    if (Validator.ParseDeskDept(deskDepth) == FurnitureEnums.FurnitureEnums.DeskDepth._24)
                    {
                        userDeskDepth = FurnitureEnums.FurnitureEnums.DeskDepth._24;
                    }
                    else if (Validator.ParseDeskDept(deskDepth) == FurnitureEnums.FurnitureEnums.DeskDepth._36)
                    {
                        userDeskDepth = FurnitureEnums.FurnitureEnums.DeskDepth._36;
                    }
                    else
                    {
                        Console.WriteLine("Try Again.");
                    }
                }
                while (userDeskWidth == FurnitureEnums.FurnitureEnums.DeskWidth.NOT_RECOGNIZED)
                {
                    Console.WriteLine("What width size would you like? 48 or 60 ");
                    deskWidth = Console.ReadLine();
                    if (Validator.ParseDeskWidth(deskWidth) == FurnitureEnums.FurnitureEnums.DeskWidth._48)
                    {
                        userDeskWidth = FurnitureEnums.FurnitureEnums.DeskWidth._48;
                    }
                    else if (Validator.ParseDeskWidth(deskWidth) == FurnitureEnums.FurnitureEnums.DeskWidth._60)
                    {
                        userDeskWidth = FurnitureEnums.FurnitureEnums.DeskWidth._60;
                    }
                    else
                    {
                        Console.WriteLine("Try Again.");
                    }
                }
                Desk Ology = new Desk(productList[0][1], decimal.Parse(productList[0][2]), productList[0][3], (int)userDeskDrawer,
                    (int)userDeskPullsStyle, (int)userDeskPullsColor, (int)userDeskColor, (int)userDeskDepth, (int)userDeskWidth);
            }
            else
            {
                Console.Write("Invalid Entry, please try again. Press enter to contniue.");
                Console.ReadLine();
                UserDeskChoice();
            }
        }
    }
}
