using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCart.Model;

namespace ShoppingCart.Repository
{
    public class RepositoryOperation
    {
        public RepositoryOperation()
        {
            SaveProducts();
        }

        List<GeneralProduct> listProduct = new List<GeneralProduct>();


        #region
        public List<GeneralProduct> SaveProducts()
        {
            listProduct = new List<GeneralProduct>(){
            new Car("Nissan Tiida", "Red", true, 1, "Nissan Tiida 2005", 7000m),
            new Car("Nissan Skyline", "Silver", false, 2, "Nissan Skyline 2010", 10000m),
            new Computer("500G", "10G", 3, "IPad", 2000m),
            new Computer("1T", "50GB", 4, "MacBook Air", 3000m),
            new Computer("2T", "200GB", 5, "Acer", 5000m),
            new Furniture(6, "Heavy Rocker", 12000m, "Massage", "Silver"),
            new Furniture(7, "Muscle trainer", 4000m, "lighter", "Rock"),
            new SportEquipment(8, "Treadmill", 5000m, "Life Fitness", "Aluminum Alloy", "Mechanical Running Machine"),
            new SportEquipment(9, "Basketball", 50m, "Jordan", "Rubber", "Jordan Rubber Basketball"),
            new SportEquipment(10, "football", 100m, "City Fitness", "Rubber", "Worldwide Football")
            
        };
            return listProduct;
       }
        #endregion

        #region
        public void GetProducts()
        {
            Console.WriteLine("--------------------------------The List of PRODUCTS---------------------------- \n");
            foreach (var item in listProduct)
            {
                //Console.WriteLine("--------The List of Products--------");
                Console.WriteLine("                          Product ID: {0}" ,item.ID);
                Console.WriteLine("                          Product Name: {0}", item.Name);
                Console.WriteLine("                          Product Price: {0}\n", item.Price);
                Console.WriteLine("-------------------------------------------------------------------------------- \n");
            }
        }
        #endregion
    }
}
