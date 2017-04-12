using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Classes
{
    public class Furniture
    {
        private decimal price;
        private string description;
        private int modelNum;

        public Furniture()
        {
            this.price = 0;
            this.description = null;
            this.modelNum = 0;
        }

        public Furniture(decimal price, string descriptions)
        {
            this.price = this.price;
            this.description = this.description;
            this.modelNum = this.modelNum;
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public int ModelNum
        {
            get { return modelNum; }
            set { modelNum = value; }
        }
    }
}
