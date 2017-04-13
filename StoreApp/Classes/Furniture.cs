using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Classes
{
    public class Furniture
    {
        private string type;
        private string name;
        private decimal price;
        private string description;
        private int modelNum;

        public Furniture()
        {
            this.type = null;
            this.name = null;
            this.price = 0;
            this.description = null;
            this.modelNum = 0;
        }

        public Furniture(string type, string name, decimal price, string descriptions)
        {
            this.type = type;
            this.name = name;
            this.price = price;
            this.description = description;
            this.modelNum = modelNum;
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
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
