using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Classes
{
    public class Desk : Furniture
    {
        private int drawers;
        private int pullStyle;
        private int pullColor;
        private int color;
        private int depth;
        private int width;

        public Desk()
        {
            this.drawers = 0;
            this.pullStyle = 0;
            this.pullColor = 0;
            this.color = 0;
            this.depth = 0;
            this.width = 0;
        }
        public Desk(int drawers, int pullStyle, int pullColor, int color, int depth, int width)
        {
            this.drawers = drawers;
            this.pullStyle = pullStyle;
            this.pullColor = pullColor;
            this.color = color;
            this.depth = depth;
            this.width = width;
        }
        public int Drawers
        {
            get { return drawers; }
            set { drawers = value; }
        }
        public int PullStyle
        {
            get { return pullStyle; }
            set { pullStyle = value; }
        }
        public int PullColor
        {
            get { return pullColor; }
            set { pullColor = value; }
        }
        public int Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Depth
        {
            get { return depth; }
            set { depth = value; }
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
    }
}

//enum pullsColor(none, black, silver, crome, brushedcrome)
//enum pullsStyle(none, contemporary, cscape, jazz, bar)