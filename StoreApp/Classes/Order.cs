﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApp.Classes;
using StoreApp.FurnitureEnums;
using System.IO;

namespace StoreApp.Classes
{
    public class Order
    {
        public static void Ordering()
        {
            List<Furniture> furnitureList = new List<Furniture>();
            List<Furniture> userOrder = new List<Furniture>();
            BuildInventory b = new BuildInventory();
            foreach (var product in b.PullInventory(furnitureList))
            {
                Console.WriteLine(" {0}, {1}, ${2}, {3}", product.Type, product.Name, product.Price, product.Description);
            }

            var userChoice = FurnitureEnums.FurnitureEnums.AllFurnObjects.NOT_RECOGNIZED.ToString();

            do
            {
                Console.Write(" Please type the name of the product you would like to add to your order, or type \"quit,\" or \"pay\": ");
                userChoice = Console.ReadLine();

                if (Validator.ParseFurnObjects(userChoice) == FurnitureEnums.FurnitureEnums.AllFurnObjects.ANSWER)
                {
                    userOrder.Add(furnitureList[0]);
                    Console.WriteLine(" You've added the Answer desk to your order.");
                }
                else if (Validator.ParseFurnObjects(userChoice) == FurnitureEnums.FurnitureEnums.AllFurnObjects.OLOGY)
                {
                    userOrder.Add(furnitureList[1]);
                    Console.WriteLine(" You've added the Ology desk to your order.");
                }
                else if (Validator.ParseFurnObjects(userChoice) == FurnitureEnums.FurnitureEnums.AllFurnObjects.FRAME_1)
                {
                    userOrder.Add(furnitureList[2]);
                    Console.WriteLine(" You've added the Frame 1 desk to your order.");
                }
                else if (Validator.ParseFurnObjects(userChoice) == FurnitureEnums.FurnitureEnums.AllFurnObjects.CSCAPE)
                {
                    userOrder.Add(furnitureList[3]);
                    Console.WriteLine(" You've added the C:Scape desk to your order.");
                }
                else if (Validator.ParseFurnObjects(userChoice) == FurnitureEnums.FurnitureEnums.AllFurnObjects.STORAGE)
                {
                    userOrder.Add(furnitureList[4]);
                    Console.WriteLine(" You've added the Storage file to your order.");
                }
                else if (Validator.ParseFurnObjects(userChoice) == FurnitureEnums.FurnitureEnums.AllFurnObjects.PEDESTAL)
                {
                    userOrder.Add(furnitureList[5]);
                    Console.WriteLine(" You've added the Pedestal file to your order.");
                }
                else if (Validator.ParseFurnObjects(userChoice) == FurnitureEnums.FurnitureEnums.AllFurnObjects.TOWER)
                {
                    userOrder.Add(furnitureList[6]);
                    Console.WriteLine(" You've added the Tower file to your order.");
                }
                else if (Validator.ParseFurnObjects(userChoice) == FurnitureEnums.FurnitureEnums.AllFurnObjects.LEAP)
                {
                    userOrder.Add(furnitureList[7]);
                    Console.WriteLine(" You've added the Leap chair to your order.");
                }
                else if (Validator.ParseFurnObjects(userChoice) == FurnitureEnums.FurnitureEnums.AllFurnObjects.SENSOR)
                {
                    userOrder.Add(furnitureList[8]);
                    Console.WriteLine(" You've added the Sensor chair to your order.");
                }
                else if (Validator.ParseFurnObjects(userChoice) == FurnitureEnums.FurnitureEnums.AllFurnObjects.COBI)
                {
                    userOrder.Add(furnitureList[9]);
                    Console.WriteLine(" You've added the Cobi chair to your order.");
                }
                else if (Validator.ParseFurnObjects(userChoice) == FurnitureEnums.FurnitureEnums.AllFurnObjects.NOBE)
                {
                    userOrder.Add(furnitureList[10]);
                    Console.WriteLine(" You've added the Nobe chair to your order.");
                }
                else if (Validator.ParseFurnObjects(userChoice) == FurnitureEnums.FurnitureEnums.AllFurnObjects.GESTURE)
                {
                    userOrder.Add(furnitureList[11]);
                    Console.WriteLine(" You've added the Gesture chair to your order.");
                }
                else if (Validator.ParseFurnObjects(userChoice) == FurnitureEnums.FurnitureEnums.AllFurnObjects.POTRERO)
                {
                    userOrder.Add(furnitureList[12]);
                    Console.WriteLine(" You've added the Potrero table to your order.");
                }
                else if (Validator.ParseFurnObjects(userChoice) == FurnitureEnums.FurnitureEnums.AllFurnObjects.BALLET)
                {
                    userOrder.Add(furnitureList[13]);
                    Console.WriteLine(" You've added the Ballet table to your order.");
                }
                else if (Validator.ParseFurnObjects(userChoice) == FurnitureEnums.FurnitureEnums.AllFurnObjects.GLASS)
                {
                    userOrder.Add(furnitureList[14]);
                    Console.WriteLine(" You've added the Glass table to your order.");
                }
                else if (Validator.ParseFurnObjects(userChoice) == FurnitureEnums.FurnitureEnums.AllFurnObjects.UNIVERSAL)
                {
                    userOrder.Add(furnitureList[15]);
                    Console.WriteLine(" You've added the Universal table to your order.");
                }
                else if (Validator.ParseFurnObjects(userChoice) == FurnitureEnums.FurnitureEnums.AllFurnObjects.PAY)
                {
                    Console.Clear();
                    double grandTotal = 0;
                    foreach (var product in userOrder)
                    {
                        grandTotal = grandTotal + product.Price;
                    }
                    Console.WriteLine(" You have the following items in your order:");
                    foreach (var product in userOrder)
                    {
                        Console.WriteLine(" {0} {1}, ${2}", product.Name, product.Type, product.Price);
                    }
                    Console.WriteLine(" Your subtotal for this order is ${0}.", grandTotal);
                    Console.WriteLine(" Tax = ${0}", Math.Round((grandTotal * 0.06), 2));
                    Console.WriteLine(" Grand Total = ${0}", Math.Round((grandTotal + (grandTotal * 0.06)), 2));
                    Console.Write(" How would you like to pay: Credit? Check? Cash?:");
                    string pay = Console.ReadLine();
                    string cardNum;
                    int checkNum;
                    double cash;
                    string expirationDate;
                    int CVV;

                    if (Validator.ParsePayment(pay) == FurnitureEnums.FurnitureEnums.Payments.CREDIT)
                    {
                        Console.Write(" Please enter your card number:");
                        cardNum = Console.ReadLine();
                        Console.Write(" Please enter your expiration date - (mm/yyyy): ");
                        expirationDate = Console.ReadLine();
                        Console.Write(" Please enter your CVV number: ");
                        CVV = int.Parse(Console.ReadLine());
                        Console.WriteLine(" Thank you for your payment");
                        Console.WriteLine(" Here is your reciept:");
                        foreach (var product in userOrder)
                        {
                            Console.WriteLine(" {0} {1}, ${2}", product.Name, product.Type, product.Price);
                        }
                        Console.WriteLine(" Subtotal = ${0}", grandTotal);
                        Console.WriteLine(" Tax = ${0}", Math.Round((grandTotal * 0.06), 2));
                        Console.WriteLine(" Grand Total = ${0}", Math.Round((grandTotal + (grandTotal * 0.06)), 2));
                        Console.WriteLine(" This has been billed to your card number: {0}", cardNum);
                        break;
                    }
                    else if (Validator.ParsePayment(pay) == FurnitureEnums.FurnitureEnums.Payments.CHECK)
                    {
                        Console.Write(" Please enter your check number:");
                        checkNum = int.Parse(Console.ReadLine());
                        Console.WriteLine(" Thank you for your payment");
                        Console.WriteLine(" Here is your reciept:");
                        foreach (var product in userOrder)
                        {
                            Console.WriteLine(" {0} {1}, ${2}", product.Name, product.Type, product.Price);
                        }
                        Console.WriteLine(" Subtotal = ${0}", grandTotal);
                        Console.WriteLine(" Tax = ${0}", Math.Round((grandTotal * 0.06), 2));
                        Console.WriteLine(" Grand Total = ${0}", Math.Round((grandTotal + (grandTotal * 0.06)), 2));
                        Console.WriteLine(" This has been billed to your checking account with check number: {0}", checkNum);
                        break;
                    }
                    else if (Validator.ParsePayment(pay) == FurnitureEnums.FurnitureEnums.Payments.CASH)
                    {
                        Console.Write(" Please enter amount of cash tendered:");
                        cash = double.Parse(Console.ReadLine());
                        Console.WriteLine(" Thank you for your payment");
                        Console.WriteLine(" Here is your reciept:");
                        foreach (var product in userOrder)
                        {
                            Console.WriteLine(" {0} {1}, ${2}", product.Name, product.Type, product.Price);
                        }
                        Console.WriteLine(" Subtotal = ${0}", grandTotal);
                        Console.WriteLine(" Tax = ${0}", Math.Round((grandTotal * 0.06), 2));
                        Console.WriteLine(" Grand Total = ${0}", Math.Round((grandTotal + (grandTotal * 0.06)), 2));
                        Console.WriteLine(" Paid for in cash amount: {0}", cash);
                        Console.WriteLine(" You received ${0} cash back in change.", Math.Round(cash - ((grandTotal + (grandTotal * 0.06))), 2));
                        break;
                    }
                    else
                    {
                        Console.Write(" Try again: ");

                    }

                }
                else if (Validator.ParseFurnObjects(userChoice) == FurnitureEnums.FurnitureEnums.AllFurnObjects.QUIT)
                {
                    userOrder.Clear();
                    break;
                }
                else
                {
                    Console.Write(" Typing error, please try again: ");
                }
            }
            while ((userChoice != FurnitureEnums.FurnitureEnums.AllFurnObjects.PAY.ToString()) ||
                    userChoice != FurnitureEnums.FurnitureEnums.AllFurnObjects.QUIT.ToString());
        }
    }
}
