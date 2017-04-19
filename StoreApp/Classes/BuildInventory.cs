using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApp.Classes;
using StoreApp.FurnitureEnums;
using System.IO;

namespace StoreApp.Classes
{
    public class BuildInventory
    {
        public List<Furniture> PullInventory(List<Furniture> furnitureList)
        {
            List<Furniture> userOrder = new List<Furniture>(); //this is the clients orders
            StreamReader furnitureText;
            string[] columns;
            string row;
            furnitureText = new StreamReader(new FileStream((@"../../../Furniture.txt"), FileMode.Open, FileAccess.Read));
            //furnitureText = new StreamReader(new FileStream((@"C:\Users\ghouck\Documents\GitHub\MidtermProject\Furniture.txt"), FileMode.Open, FileAccess.Read));
            while (furnitureText.Peek() != -1)
            {
                row = furnitureText.ReadLine();
                columns = row.Split('|');
                Furniture furniture = new Furniture();
                furniture.Type = columns[0];
                furniture.Name = columns[1];
                furniture.Price = double.Parse(columns[2]);
                furniture.Description = columns[3];
                furnitureList.Add(furniture);
            }
            return furnitureList;
        }
    }
}
