using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Classes
{
    public class Seating : Furniture
    {
        private int adjSeatHeight;
        private int adjSeatDepth;
        private int adjArms;
        private int castersOrGlides;
        private int vbs;
        private int color;

        public Seating()
        {
            this.adjSeatHeight = 0;
            this.adjSeatDepth = 0;
            this.adjArms = 0;
            this.castersOrGlides = 0;
            this.vbs = 0;
            this.color = 0;
        }

        public Seating(int adjSeatHeight, int adjSeatDepth, int adjArms, int castersOrGlides, int vbs, int color)
        {
            this.adjSeatHeight = adjSeatHeight;
            this.adjSeatDepth = adjSeatDepth;
            this.adjArms = adjArms;
            this.castersOrGlides = castersOrGlides;
            this.vbs = vbs;
            this.color = color;
        }
        public int AdjSeatHeight
        {
            get { return adjSeatHeight; }
            set { adjSeatHeight = value; }
        }
        public int AdjSeatDepth
        {
            get { return adjSeatDepth; }
            set { adjSeatDepth = value; }
        }
        public int AdjArms
        {
            get { return adjArms; }
            set { adjArms = value; }
        }
        public int CastersOrGlides
        {
            get { return castersOrGlides; }
            set { castersOrGlides = value; }
        }
        public int Vbs
        {
            get { return vbs; }
            set { vbs = value; }
        }
        public int Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}
