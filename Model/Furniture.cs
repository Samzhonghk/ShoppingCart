using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Model
{
    class Furniture:GeneralProduct
    {
        public Furniture(int id, string name, decimal price, string function, string material):base(id,name,price)
        {
            this.Function = function;
            this.Material = material;
        }

        private string _function;
        public string Function
        {
            get;
            set;
        }

        private string _material;
        public string Material
        {
            get;
            set;
        }


    }
}
