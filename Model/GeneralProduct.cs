using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Model
{
    public class GeneralProduct
    {
        public GeneralProduct(int id, string name, decimal price)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
        }

        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set { _name = value; }
        }

        private decimal _price;
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
