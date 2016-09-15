using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Model
{
    public class SportEquipment:GeneralProduct
    {
        public SportEquipment(int id, string name, decimal price, string brand, string material, string type):base(id, name, price)
        {
            this.Brand = brand;
            this.Material = material;
            this.Type = type;
        }
        //new SportEquipment()
        //   {
        //       IdGuid = 6,
        //       Name = "Treadmill",
        //       Price = 5000,
        //       Brand = "Life Fitness",
        //       Material = "Aluminum Alloy",
        //       Type = "Mechanical Running Machine",
        //   },
        //   new SportEquipment()
        //   {
        //       IdGuid = 7,
        //       Name = "Basketball",
        //       Price = 50,
        //       Brand = "Jordan",
        //       Material = "Rubber",
        //       Type = "Jordan Rubber Basketball",

        private string _brand;
        public string Brand
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

        private string _type;
        public string Type
        {
            get;
            set;
        }
    }
}
