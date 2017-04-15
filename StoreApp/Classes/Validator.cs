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
        public static FurnitureEnums.FurnitureEnums.UserFurnChoice ParseFurnChoice(string s)
        {
            switch (s.ToLower())
            {
                case "d":
                case "de":
                case "des":
                case "desk":
                case "desks":
                    {
                        return FurnitureEnums.FurnitureEnums.UserFurnChoice.DESK;
                    }
                case "f":
                case "fi":
                case "fil":
                case "file":
                case "files":
                case "file ":
                    {
                        return FurnitureEnums.FurnitureEnums.UserFurnChoice.FILES;
                    }
                case "s":
                case "se":
                case "sea":
                case "seat":
                case "seat ":
                case "seati":
                case "seatin":
                case "seating":
                case "seatign":
                case "seeting":
                    {
                        return FurnitureEnums.FurnitureEnums.UserFurnChoice.SEATING;
                    }
                case "t":
                case "ta":
                case "tab":
                case "tabl":
                case "table":
                case "tabels":
                case "tables":
                case "table ":
                    {
                        return FurnitureEnums.FurnitureEnums.UserFurnChoice.TABLES;
                    }
                default:
                    {
                        return FurnitureEnums.FurnitureEnums.UserFurnChoice.NOT_RECOGNIZED;
                    }
            }
        }

        public static FurnitureEnums.FurnitureEnums.UserDeskChoice ParseDeskChoice(string s)
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
                        return FurnitureEnums.FurnitureEnums.UserDeskChoice.ANSWER;
                    }
                case "o":
                case "ol":
                case "olo":
                case "olgy":
                case "olgy ":
                    {
                        return FurnitureEnums.FurnitureEnums.UserDeskChoice.OLOGY;
                    }
                case "f":
                case "fr":
                case "fra":
                case "fram":
                case "frame":
                case "frame ":
                    {
                        return FurnitureEnums.FurnitureEnums.UserDeskChoice.FRAME;
                    }
                case "c":
                case "cs":
                case "csc":
                case "csca":
                case "cscap":
                case "escapes":
                case "escape ":
                    {
                        return FurnitureEnums.FurnitureEnums.UserDeskChoice.CSCAPE;
                    }
                case "n":
                case "no":
                    {
                        return FurnitureEnums.FurnitureEnums.UserDeskChoice.NO;
                    }
                default:
                    {
                        return FurnitureEnums.FurnitureEnums.UserDeskChoice.NOT_RECOGNIZED;
                    }
            }
        }

        public static FurnitureEnums.FurnitureEnums.UserFilesChoice ParseFilesChoice(string s)
        {
            switch (s.ToLower())
            {
                case "s":
                case "st":
                case "sto":
                case "stor":
                case "stora":
                case "storag":
                case "storage":
                    {
                        return FurnitureEnums.FurnitureEnums.UserFilesChoice.STORAGE;
                    }
                case "p":
                case "pe":
                case "pede":
                case "pedes":
                case "pedest":
                case "pedesta":
                case "pedestal":
                    {
                        return FurnitureEnums.FurnitureEnums.UserFilesChoice.PEDESTAL;
                    }
                case "t":
                case "to":
                case "tow":
                case "towe":
                case "tower":
                case "tower ":
                    {
                        return FurnitureEnums.FurnitureEnums.UserFilesChoice.TOWER;
                    }
                default:
                    {
                        return FurnitureEnums.FurnitureEnums.UserFilesChoice.NOT_RECOGNIZED;
                    }
            }
        }

        public static FurnitureEnums.FurnitureEnums.UserSeatChoice ParseSeatChoice(string s)
        {
            switch (s.ToLower())
            {
                case "l":
                case "le":
                case "lea":
                case "leap":
                case "leap ":
                    {
                        return FurnitureEnums.FurnitureEnums.UserSeatChoice.LEAP;
                    }
                case "s":
                case "se":
                case "sen":
                case "sens":
                case "senso":
                case "sensor":
                case "sensors":
                    {
                        return FurnitureEnums.FurnitureEnums.UserSeatChoice.SENSOR;
                    }
                case "o":
                case "ob":
                case "obi":
                case "obi ":
                    {
                        return FurnitureEnums.FurnitureEnums.UserSeatChoice.OBI;
                    }
                case "n":
                case "no":
                case "nob":
                case "nobe":
                case "no be":
                case "nobe ":
                    {
                        return FurnitureEnums.FurnitureEnums.UserSeatChoice.NOBE;
                    }
                case "g":
                case "ge":
                case "ges":
                case "gest":
                case "gestu":
                case "gestur":
                case "gesture":
                    {
                        return FurnitureEnums.FurnitureEnums.UserSeatChoice.GESTURE;
                    }
                default:
                    {
                        return FurnitureEnums.FurnitureEnums.UserSeatChoice.NOT_RECOGNIZED;
                    }
            }
        }

        public static FurnitureEnums.FurnitureEnums.UserTablesChoice ParseTablesChoice(string s)
        {
            switch (s.ToLower())
            {
                case "p":
                case "po":
                case "pot":
                case "potr":
                case "potre":
                case "potrer":
                case "potrero":
                    {
                        return FurnitureEnums.FurnitureEnums.UserTablesChoice.POTRERO;
                    }
                case "b":
                case "ba":
                case "bal":
                case "ball":
                case "balle":
                case "ballet":
                case "balet":
                    {
                        return FurnitureEnums.FurnitureEnums.UserTablesChoice.BALLET;
                    }
                case "g":
                case "gl":
                case "gla":
                case "glas":
                case "glass":
                case "glass ":
                    {
                        return FurnitureEnums.FurnitureEnums.UserTablesChoice.GLASS;
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
                        return FurnitureEnums.FurnitureEnums.UserTablesChoice.UNIVERSAL;
                    }
                default:
                    {
                        return FurnitureEnums.FurnitureEnums.UserTablesChoice.NOT_RECOGNIZED;
                    }
            }
        }

        public static FurnitureEnums.FurnitureEnums.color ParseColorChoice(string s)
        {
            switch (s.ToLower())
            {
                case "bla":
                case "blac":
                case "black":
                    {
                        return FurnitureEnums.FurnitureEnums.color.black;
                    }
                case "blu":
                case "blue":
                    {
                        return FurnitureEnums.FurnitureEnums.color.blue;
                    }
                case "g":
                case "gr":
                case "gre":
                case "gree":
                case "green":
                    {
                        return FurnitureEnums.FurnitureEnums.color.green;
                    }
                case "o":
                case "or":
                case "ora":
                case "oran":
                case "orang":
                case "orange":
                    {
                        return FurnitureEnums.FurnitureEnums.color.orange;
                    }
                case "p":
                case "pi":
                case "pin":
                case "pink":
                case "victoriasecret":
                    {
                        return FurnitureEnums.FurnitureEnums.color.pink;
                    }
                case "w":
                case "wh":
                case "whi":
                case "whit":
                case "white":
                    {
                        return FurnitureEnums.FurnitureEnums.color.white;
                    }
                default:
                    {
                        return FurnitureEnums.FurnitureEnums.color.NOT_RECOGNIZED;
                    }
            }
        }

        public static FurnitureEnums.FurnitureEnums.DeskCenterDrawer ParseCenterDrawer(string s)
        {
            switch (s.ToLower())
            {
                case "y":
                case "ye":
                case "yes":
                    {
                        return FurnitureEnums.FurnitureEnums.DeskCenterDrawer.YES;
                    }
                case "n":
                case "no":
                    {
                        return FurnitureEnums.FurnitureEnums.DeskCenterDrawer.NO;
                    }
                default:
                    {
                        return FurnitureEnums.FurnitureEnums.DeskCenterDrawer.NOT_RECOGNIZED;
                    }
            }
        }

        public static FurnitureEnums.FurnitureEnums.DeskDepth ParseDeskDept(string s)
        {
            switch (s.ToLower())
            {
                case "24":
                    {
                        return FurnitureEnums.FurnitureEnums.DeskDepth._24;
                    }
                case "36":
                    {
                        return FurnitureEnums.FurnitureEnums.DeskDepth._36;
                    }
                default:
                    {
                        return FurnitureEnums.FurnitureEnums.DeskDepth.NOT_RECOGNIZED;
                    }
            }
        }

        public static FurnitureEnums.FurnitureEnums.DeskWidth ParseDeskWidth(string s)
        {
            switch (s.ToLower())
            {
                case "48":
                    {
                        return FurnitureEnums.FurnitureEnums.DeskWidth._48;
                    }
                case "60":
                    {
                        return FurnitureEnums.FurnitureEnums.DeskWidth._60;
                    }
                default:
                    {
                        return FurnitureEnums.FurnitureEnums.DeskWidth.NOT_RECOGNIZED;
                    }
            }
        }

        public static FurnitureEnums.FurnitureEnums.pullsStyle ParsePullsStyle(string s)
        {
            switch (s.ToLower()) 
            {
                case "b":
                case "ba":
                case "bar":
                {
                    return FurnitureEnums.FurnitureEnums.pullsStyle.bar;
                }
                case "co":
                case "con":
                case "cont":
                case "conte":
                case "contem":
                case "contemp":
                case "contempo":
                case "contempor":
                case "contempora":
                case "contemporar":
                case "contemporary":
                {
                    return FurnitureEnums.FurnitureEnums.pullsStyle.contemporary;
                }
                case "cs":
                case "csc":
                case "csca":
                case "casap":
                case "casape":
                {
                    return FurnitureEnums.FurnitureEnums.pullsStyle.cscape;
                }
                case "j":
                case "ja":
                case "jazz":
                case "jaz":
                {
                    return FurnitureEnums.FurnitureEnums.pullsStyle.jazz;
                }
                default:
                {
                    return FurnitureEnums.FurnitureEnums.pullsStyle.NOT_RECOGNIZED;
                }
            }
        }

        public static FurnitureEnums.FurnitureEnums.pullsColor ParsePullsColor(string s)
        {
            switch (s.ToLower()) //black, brushed, chrome, silver,
            {
                case "bl":
                case "bla":
                case "blac":
                case "black":
                    {
                        return FurnitureEnums.FurnitureEnums.pullsColor.black;
                    }
                case "br":
                case "bru":
                case "brus":
                case "brush":
                case "brushe":
                case "brushed":
                    {
                        return FurnitureEnums.FurnitureEnums.pullsColor.brushed;
                    }
                case "c":
                case "ch":
                case "chr":
                case "chro":
                case "chrom":
                case "chrome":
                    {
                        return FurnitureEnums.FurnitureEnums.pullsColor.chrome;
                    }
                case "s":
                case "si":
                case "sil":
                case "silv":
                case "silvr":
                case "silver":

                    {
                        return FurnitureEnums.FurnitureEnums.pullsColor.silver;
                    }
                default:
                    {
                        return FurnitureEnums.FurnitureEnums.pullsColor.NOT_RECOGNIZED;
                    }
            }
        }
    }
}
