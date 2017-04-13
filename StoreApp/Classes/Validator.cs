using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Classes
{
    public enum UserFurnChoice { DESK, FILES, SEATING, TABLES, NOT_RECOGNIZED }
    public enum UserDeskChoice { ANSWER, OLOGY, FRAME, CSCAPE, NOT_RECOGNIZED }
    public enum UserFilesChoice { STORAGE, PEDESTAL, TOWER, NOT_RECOGNIZED }
    public enum UserSeatChoice { LEAP, SENSOR, OBI, NOBE, GESTURE, NOT_RECOGNIZED }
    public enum UserTablesChoice { POTRERO, BALLET, GLASS, UNIVERSAL, NOT_RECOGNIZED }

    class Validator
    {
        public static UserFurnChoice ParceFurnChoice(string s)
        {
            switch (s.ToLower())
            {
                case "d":
                case "de":
                case "des":
                case "desk":
                case "desk ":
                case "deks":
                    {
                        return UserFurnChoice.DESK;
                    }
                case "f":
                case "fi":
                case "fil":
                case "file":
                case "files":
                case "file ":
                    {
                        return UserFurnChoice.FILES;
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
                        return UserFurnChoice.SEATING;
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
                        return UserFurnChoice.TABLES;
                    }
                default:
                    {
                        return UserFurnChoice.NOT_RECOGNIZED;
                    }
            }
        }

        public static UserDeskChoice ParceDeskChoice(string s)
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
                        return UserDeskChoice.ANSWER;
                    }
                case "o":
                case "ol":
                case "olo":
                case "olgy":
                case "olgy ":
                    {
                        return UserDeskChoice.OLOGY;
                    }
                case "f":
                case "fr":
                case "fra":
                case "fram":
                case "frame":
                case "frame ":
                    {
                        return UserDeskChoice.FRAME;
                    }
                case "c":
                case "cs":
                case "csc":
                case "csca":
                case "cscap":
                case "escapes":
                case "escape ":
                    {
                        return UserDeskChoice.CSCAPE;
                    }
                default:
                    {
                        return UserDeskChoice.NOT_RECOGNIZED;
                    }
            }
        }

        public static UserFilesChoice ParceFilesChoice(string s)
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
                        return UserFilesChoice.STORAGE;
                    }
                case "p":
                case "pe":
                case "pede":
                case "pedes":
                case "pedest":
                case "pedesta":
                case "pedestal":
                    {
                        return UserFilesChoice.PEDESTAL;
                    }
                case "t":
                case "to":
                case "tow":
                case "towe":
                case "tower":
                case "tower ":
                    {
                        return UserFilesChoice.TOWER;
                    }
                default:
                    {
                        return UserFilesChoice.NOT_RECOGNIZED;
                    }
            }
        }
        public static UserSeatChoice ParceSeatChoice(string s)
        {
            switch (s.ToLower())
            { 
                case "l":
                case "le":
                case "lea":
                case "leap":
                case "leap ":
                    {
                        return UserSeatChoice.LEAP;
                    }
                case "s":
                case "se":
                case "sen":
                case "sens":
                case "senso":
                case "sensor":
                case "sensors":
                    {
                        return UserSeatChoice.SENSOR;
                    }
                case "o":
                case "ob":
                case "obi":
                case "obi ":
                    {
                        return UserSeatChoice.OBI;
                    }
                case "n":
                case "no":
                case "nob":
                case "nobe":
                case "no be":
                case "nobe ":
                    {
                        return UserSeatChoice.NOBE;
                    }
                case "g":
                case "ge":
                case "ges":
                case "gest":
                case "gestu":
                case "gestur":
                case "gesture":
                    {
                        return UserSeatChoice.GESTURE;
                    }
                default:
                    {
                        return UserSeatChoice.NOT_RECOGNIZED;
                    }
            }
        }

        public static UserTablesChoice ParceTablesChoice(string s)
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
                        return UserTablesChoice.POTRERO;
                    }
                case "b":
                case "ba":
                case "bal":
                case "ball":
                case "balle":
                case "ballet":
                case "balet":
                    {
                        return UserTablesChoice.BALLET;
                    }
                case "g":
                case "gl":
                case "gla":
                case "glas":
                case "glass":
                case "glass ":
                    {
                        return UserTablesChoice.GLASS;
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
                        return UserTablesChoice.UNIVERSAL;
                    }
                default:
                    {
                        return UserTablesChoice.NOT_RECOGNIZED;
                    }
            }
        }
    }
}
