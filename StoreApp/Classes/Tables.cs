using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Classes
{
    class Tables : Furniture
    {
        private int material;
        private int color;
        private int legStyle;
        private int length;
        private int width;

        public Tables()
        {
            this.material = 0;
            this.color = 0;
            this.legStyle = 0;
            this.length = 0;
            this.width = 0;
        }
        public Tables(int material, int color, int legStyle, int length, int width)
        {
            this.material = material;
            this.color = color;
            this.legStyle = legStyle;
            this.length = length;
            this.width = width;
        }
        public int Material
        {
            get { return material; }
            set { material = value; }
        }
        public int Color
        {
            get { return color; }
            set { color = value; }
        }
        public int LegStyle
        {
            get { return legStyle; }
            set { legStyle = value; }
        }
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

    }

}
//enum(unimas, ology, tbase, cscape, frameone)

