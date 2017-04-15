using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Classes
{
    public class Cart
    {
        private List<Furniture> yourCart = new List<Furniture>();

        public void AddToCart(Furniture F)
        {
            yourCart.Add(F);
        }
    }
}
