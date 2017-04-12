using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Classes
{
    class Files : Furniture
    {
        private int fileType;
        private int tower;
        private int pullStyle;
        private int pullColor;

        public Files()
        {
            this.fileType = 0;
            this.tower = 0;
            this.pullStyle = 0;
            this.pullColor = 0;
        }
          public Files(int fileType, int pullStyle, int pullColor, int tower)
        {
            this.fileType = fileType;
            this.pullStyle = pullStyle;
            this.pullColor = pullColor;
            this.tower = tower;
        }
        
        public int FileType
        {
            get { return fileType; }
            set { fileType = value; }
        }
        public int Tower
        {
            get { return tower; }
            set { tower = value; }
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
    }
}

