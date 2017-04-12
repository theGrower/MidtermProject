using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Classes
{
    class Files : Furniture
    {
        private int LateralOrVertical;
        private int Tower;
        private int PullStyle;
        private int PullColor;

        public Files()
        {
            this.LateralOrVertical = 0;
            this.Tower = 0;
            this.PullStyle = 0;
            this.PullColor = 0;
        }

        public int lateralOrVertical
        {
            get { return lateralOrVertical; }
            set { lateralOrVertical = value; }
        }
        public int tower
        {
            get { return tower; }
            set { tower = value; }
        }
        public int pullStyle
        {
            get { return pullStyle; }
            set { pullStyle = value; }
        }
        public int pullColor
        {
            get { return pullColor; }
            set { pullColor = value; }
        }
    }
}

