using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Model
{
    public class Car: GeneralProduct
    {
        public Car(string brand, string color, bool isSecondHand, int id, string name, decimal price): base(id,name,price)
        {
            this.Brand = brand;
            this.Color = color;
            this.IsSecondHand = isSecondHand;
        }

        private string _brand;
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        private string _color;
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        private bool _isSecondHand;
        public bool IsSecondHand
        {
            get { return _isSecondHand; }
            set
            {
                _isSecondHand = value;
            }
        }
    }
}
