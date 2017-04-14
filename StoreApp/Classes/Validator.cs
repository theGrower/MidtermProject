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
        public static StoreApp.FurnitureEnums.FurnitureEnums.UserFurnChoice ParceFurnChoice(string s)
        {
            switch (s.ToLower())
            {
                case "d":
                case "de":
                case "des":
                case "desk":
                case "desks":
                    {
                        return StoreApp.FurnitureEnums.FurnitureEnums.UserFurnChoice.DESK;
                    }
                case "f":
                case "fi":
                case "fil":
                case "file":
                case "files":
                case "file ":
                    {
                        return StoreApp.FurnitureEnums.FurnitureEnums.UserFurnChoice.FILES;
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
                        return StoreApp.FurnitureEnums.FurnitureEnums.UserFurnChoice.SEATING;
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
                        return StoreApp.FurnitureEnums.FurnitureEnums.UserFurnChoice.TABLES;
                    }
                default:
                    {
                        return StoreApp.FurnitureEnums.FurnitureEnums.UserFurnChoice.NOT_RECOGNIZED;
                    }
            }
        }

        public static StoreApp.FurnitureEnums.FurnitureEnums.UserDeskChoice ParceDeskChoice(string s)
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
                        return StoreApp.FurnitureEnums.FurnitureEnums.UserDeskChoice.ANSWER;
                    }
                case "o":
                case "ol":
                case "olo":
                case "olgy":
                case "olgy ":
                    {
                        return StoreApp.FurnitureEnums.FurnitureEnums.UserDeskChoice.OLOGY;
                    }
                case "f":
                case "fr":
                case "fra":
                case "fram":
                case "frame":
                case "frame ":
                    {
                        return StoreApp.FurnitureEnums.FurnitureEnums.UserDeskChoice.FRAME;
                    }
                case "c":
                case "cs":
                case "csc":
                case "csca":
                case "cscap":
                case "escapes":
                case "escape ":
                    {
                        return StoreApp.FurnitureEnums.FurnitureEnums.UserDeskChoice.CSCAPE;
                    }
                case "n":
                case "no":
                    {
                        return StoreApp.FurnitureEnums.FurnitureEnums.UserDeskChoice.NO;
                    }
                default:
                    {
                        return StoreApp.FurnitureEnums.FurnitureEnums.UserDeskChoice.NOT_RECOGNIZED;
                    }
            }
        }

        public static StoreApp.FurnitureEnums.FurnitureEnums.UserFilesChoice ParceFilesChoice(string s)
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
                        return StoreApp.FurnitureEnums.FurnitureEnums.UserFilesChoice.STORAGE;
                    }
                case "p":
                case "pe":
                case "pede":
                case "pedes":
                case "pedest":
                case "pedesta":
                case "pedestal":
                    {
                        return StoreApp.FurnitureEnums.FurnitureEnums.UserFilesChoice.PEDESTAL;
                    }
                case "t":
                case "to":
                case "tow":
                case "towe":
                case "tower":
                case "tower ":
                    {
                        return StoreApp.FurnitureEnums.FurnitureEnums.UserFilesChoice.TOWER;
                    }
                default:
                    {
                        return StoreApp.FurnitureEnums.FurnitureEnums.UserFilesChoice.NOT_RECOGNIZED;
                    }
            }
        }
        public static StoreApp.FurnitureEnums.FurnitureEnums.UserSeatChoice ParceSeatChoice(string s)
        {
            switch (s.ToLower())
            { 
                case "l":
                case "le":
                case "lea":
                case "leap":
                case "leap ":
                    {
                        return StoreApp.FurnitureEnums.FurnitureEnums.UserSeatChoice.LEAP;
                    }
                case "s":
                case "se":
                case "sen":
                case "sens":
                case "senso":
                case "sensor":
                case "sensors":
                    {
                        return StoreApp.FurnitureEnums.FurnitureEnums.UserSeatChoice.SENSOR;
                    }
                case "o":
                case "ob":
                case "obi":
                case "obi ":
                    {
                        return StoreApp.FurnitureEnums.FurnitureEnums.UserSeatChoice.OBI;
                    }
                case "n":
                case "no":
                case "nob":
                case "nobe":
                case "no be":
                case "nobe ":
                    {
                        return StoreApp.FurnitureEnums.FurnitureEnums.UserSeatChoice.NOBE;
                    }
                case "g":
                case "ge":
                case "ges":
                case "gest":
                case "gestu":
                case "gestur":
                case "gesture":
                    {
                        return StoreApp.FurnitureEnums.FurnitureEnums.UserSeatChoice.GESTURE;
                    }
                default:
                    {
                        return StoreApp.FurnitureEnums.FurnitureEnums.UserSeatChoice.NOT_RECOGNIZED;
                    }
            }
        }

        public static StoreApp.FurnitureEnums.FurnitureEnums.UserTablesChoice ParceTablesChoice(string s)
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
                        return StoreApp.FurnitureEnums.FurnitureEnums.UserTablesChoice.POTRERO;
                    }
                case "b":
                case "ba":
                case "bal":
                case "ball":
                case "balle":
                case "ballet":
                case "balet":
                    {
                        return StoreApp.FurnitureEnums.FurnitureEnums.UserTablesChoice.BALLET;
                    }
                case "g":
                case "gl":
                case "gla":
                case "glas":
                case "glass":
                case "glass ":
                    {
                        return StoreApp.FurnitureEnums.FurnitureEnums.UserTablesChoice.GLASS;
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
                        return StoreApp.FurnitureEnums.FurnitureEnums.UserTablesChoice.UNIVERSAL;
                    }
                default:
                    {
                        return StoreApp.FurnitureEnums.FurnitureEnums.UserTablesChoice.NOT_RECOGNIZED;
                    }
            }
        }

        public static StoreApp.FurnitureEnums.FurnitureEnums.color ParceColorChoice(string s)
        {
            switch (s.ToLower()) 
            {
                case "bla":
                case "blac":
                case "black":
                    {
                        return StoreApp.FurnitureEnums.FurnitureEnums.color.black;
                    }
                case "blu":
                case "blue":
                    {
                        return StoreApp.FurnitureEnums.FurnitureEnums.color.blue;
                    }
                case "g":
                case "gr":
                case "gre":
                case "gree":
                case "green":
                    {
                        return StoreApp.FurnitureEnums.FurnitureEnums.color.green;
                    }
                case "o":
                case "or":
                case "ora":
                case "oran":
                case "orang":
                case "orange":
                    {
                        return StoreApp.FurnitureEnums.FurnitureEnums.color.orange;
                    }
                case "p":
                case "pi":
                case "pin":
                case "pink":
                case "victoriasecret":
                    {
                        return StoreApp.FurnitureEnums.FurnitureEnums.color.pink;
                    }
                case "w":
                case "wh":
                case "whi":
                case "whit":
                case "white":
                    {
                        return StoreApp.FurnitureEnums.FurnitureEnums.color.white;
                    }
                default:
                    {
                        return StoreApp.FurnitureEnums.FurnitureEnums.color.NOT_RECOGNIZED;
                    }
            }
        }
    }
}
