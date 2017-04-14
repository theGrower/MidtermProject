using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.FurnitureEnums
{
    class FurnitureEnums
    {
        public enum pullsColor { black, brushed, chrome, silver, NOT_RECOGNIZED }
        public enum pullsStyle { bar, contemporary, cscape, jazz, NOT_RECOGNIZED }
        public enum legStyle { cscape, frameone, ology, tbase, unimas, NOT_RECOGNIZED }
        public enum color { black, blue, green, orange, pink, white, NOT_RECOGNIZED }
        public enum material { laminate, wood, NOT_RECOGNIZED }
        public enum fileType { pedestal, storage, tower, NOT_RECOGNIZED }
        public enum UserFurnChoice { DESK, FILES, SEATING, TABLES, NOT_RECOGNIZED }
        public enum UserDeskChoice { ANSWER, OLOGY, FRAME, CSCAPE, NOT_RECOGNIZED, NO }
        public enum UserFilesChoice { STORAGE, PEDESTAL, TOWER, NOT_RECOGNIZED, NO }
        public enum UserSeatChoice { LEAP, SENSOR, OBI, NOBE, GESTURE, NOT_RECOGNIZED, NO }
        public enum UserTablesChoice { POTRERO, BALLET, GLASS, UNIVERSAL, NOT_RECOGNIZED, NO }

    }
}
