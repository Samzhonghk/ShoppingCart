using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Model
{
    public class Computer:GeneralProduct
    {
        public Computer(string hardDrive, string memory, int id, string name, decimal price):base(id, name,price)
        {
            this.HardDrive = hardDrive;
            this.Memory = memory;
            this.ID = id;
            this.Name = name;
            this.Price = price;
        }
        private string _hardDrive;
        public string HardDrive
        {
            get { return _hardDrive; }
            set { _hardDrive = value; }
        }

        private string _memory;
        public string Memory
        {
            get { return _memory; }
            set { _memory = value; }
        }

        
    }
}
