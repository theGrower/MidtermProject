using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApp.Classes;
using StoreApp.FurnitureEnums;

namespace StoreApp.Classes
{

    class Validator
    {
        public static FurnitureEnums.FurnitureEnums.AllFurnObjects ParseFurnObjects(string s)
        {
            {
                switch (s.ToLower())
                {
                    case "a":
                    case "an":
                    case "ans":
                    case "asnw":
                    case "answe":
                    case "answer":
                        {
                            return FurnitureEnums.FurnitureEnums.AllFurnObjects.ANSWER;
                        }
                    case "o":
                    case "ol":
                    case "olo":
                    case "olog":
                    case "ology ":
                        {
                            return FurnitureEnums.FurnitureEnums.AllFurnObjects.OLOGY;
                        }
                    case "f":
                    case "fr":
                    case "fra":
                    case "fram":
                    case "frame":
                    case "frame ":
                        {
                            return FurnitureEnums.FurnitureEnums.AllFurnObjects.FRAME_1;
                        }
                    case "c":
                    case "cs":
                    case "csc":
                    case "csca":
                    case "cscap":
                    case "escapes":
                    case "escape ":
                        {
                            return FurnitureEnums.FurnitureEnums.AllFurnObjects.CSCAPE;
                        }
                    case "s":
                    case "st":
                    case "sto":
                    case "stor":
                    case "stora":
                    case "storag":
                    case "storage":
                        {
                            return FurnitureEnums.FurnitureEnums.AllFurnObjects.STORAGE;
                        }
                    case "p":
                    case "pe":
                    case "pede":
                    case "pedes":
                    case "pedest":
                    case "pedesta":
                    case "pedestal":
                        {
                            return FurnitureEnums.FurnitureEnums.AllFurnObjects.PEDESTAL;
                        }
                    case "t":
                    case "to":
                    case "tow":
                    case "towe":
                    case "tower":
                    case "tower ":
                        {
                            return FurnitureEnums.FurnitureEnums.AllFurnObjects.TOWER;
                        }
                    case "l":
                    case "le":
                    case "lea":
                    case "leap":
                    case "leap ":
                        {
                            return FurnitureEnums.FurnitureEnums.AllFurnObjects.LEAP;
                        }
                    case "se":
                    case "sen":
                    case "sens":
                    case "senso":
                    case "sensor":
                    case "sensors":
                        {
                            return FurnitureEnums.FurnitureEnums.AllFurnObjects.SENSOR;
                        }
                    case "co":
                    case "cob":
                    case "cobi":
                        {
                            return FurnitureEnums.FurnitureEnums.AllFurnObjects.COBI;
                        }
                    case "n":
                    case "no":
                    case "nob":
                    case "nobe":
                    case "no be":
                    case "nobe ":
                        {
                            return FurnitureEnums.FurnitureEnums.AllFurnObjects.NOBE;
                        }
                    case "g":
                    case "ge":
                    case "ges":
                    case "gest":
                    case "gestu":
                    case "gestur":
                    case "gesture":
                        {
                            return FurnitureEnums.FurnitureEnums.AllFurnObjects.GESTURE;
                        }
                    case "po":
                    case "pot":
                    case "potr":
                    case "potre":
                    case "potrer":
                    case "potrero":
                        {
                            return FurnitureEnums.FurnitureEnums.AllFurnObjects.POTRERO;
                        }
                    case "b":
                    case "ba":
                    case "bal":
                    case "ball":
                    case "balle":
                    case "ballet":
                    case "balet":
                        {
                            return FurnitureEnums.FurnitureEnums.AllFurnObjects.BALLET;
                        }
                    case "gl":
                    case "gla":
                    case "glas":
                    case "glass":
                    case "glass ":
                        {
                            return FurnitureEnums.FurnitureEnums.AllFurnObjects.GLASS;
                        }
                    case "u":
                    case "un":
                    case "uni":
                    case "univ":
                    case "unive":
                    case "univers":
                    case "universa":
                    case "universal":
                        {
                            return FurnitureEnums.FurnitureEnums.AllFurnObjects.UNIVERSAL;
                        }
                    case "pay":
                        {
                            return FurnitureEnums.FurnitureEnums.AllFurnObjects.PAY;
                        }
                    case "quit":
                        {
                            return FurnitureEnums.FurnitureEnums.AllFurnObjects.QUIT;
                        }
                    default:
                        {
                            return FurnitureEnums.FurnitureEnums.AllFurnObjects.NOT_RECOGNIZED;
                        }

                }
            }
        }

        public static FurnitureEnums.FurnitureEnums.Payments ParsePayment(string s)
        {
            switch (s.ToLower())
            {
                case "cash":
                {
                    return FurnitureEnums.FurnitureEnums.Payments.CASH;
                }
                case "check":
                {
                    return FurnitureEnums.FurnitureEnums.Payments.CHECK;
                }
                case "credit":
                {
                    return FurnitureEnums.FurnitureEnums.Payments.CREDIT;
                }
                default:
                {
                    return FurnitureEnums.FurnitureEnums.Payments.NOT_RECOGNIZED;
                }
            }
        }
    }
}
