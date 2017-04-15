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
        private double price;
        private string description;

        public Furniture()
        {
            this.type = null;
            this.name = null;
            this.price = 0;
            this.description = null;
        }

        public Furniture(string type, string name, double price, string descriptions)
        {
            this.type = type;
            this.name = name;
            this.price = price;
            this.description = description;
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
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
