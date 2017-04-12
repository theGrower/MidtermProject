using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Classes
{
    class Desk
    {
        public class Desking : Furniture
        {
            private int drawers;
            private int pullStyle;
            private int pullsColor;
            private int color;
            private int depth;
            private int width;

        }
        public Desk()
        {
            this.Drawers = 0;
            this.PullStyle = 0;
            this.PullColor = 0;
            this.Color = 0;
            this.Depth = 0;
            this.Width = 0;
        }
        public int Drawers
        {
            get { return Drawers; }
            set { Drawers = value; }
        }
        public int PullStyle
        {
            get { return PullStyle; }
            set { PullStyle = value; }
        }
        public int PullColor
        {
            get { return PullColor; }
            set { PullColor = value; }
        }
        public int Color
        {
            get { return Color; }
            set { Color = value; }
        }
        public int Depth
        {
            get { return Depth; }
            set { Depth = value; }
        }
        public int Width
        {
            get { return Width; }
            set { Width = value; }
        }
    }
}
