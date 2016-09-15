using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCart.Repository;
using ShoppingCart.Model;

namespace ShoppingCart.Service
{
    public class Cashier
    {
        //Declare sum quantity of items
        int sumCar1Quantity, sumCar2Quantity, sumComputer3Quantity, sumComputer4Quantity, sumComputer5Quantity, sumFurniture6Quantity, sumFurniture7Quantity, sumSport8Quantity, sumSport9Quantity, sumSport10Quantity;
        decimal totalSum;

        Dictionary<int, decimal> dicCart = new Dictionary<int, decimal>();
        
        int quantity;
        List<GeneralProduct> listPro;
        
        RepositoryOperation rep = new RepositoryOperation();
        public void DisplayProducts()
        {
            
            rep.GetProducts();
        }

        List<int> idList = new List<int>();
        List<int> idListRemoveDuplicate = new List<int>();
        List<int> quantityList = new List<int>();
        //List<Cart> cart = new List<Cart>();
        #region
        public void AskToBuy()
        {

            while (true)
            {
                try
                {
                    Console.WriteLine("Please select the ID of the product that you like to purshase");
                    int inputId = Convert.ToInt32(Console.ReadLine());

                    if (inputId < 1 || inputId > 10)
                    {
                        Console.WriteLine("Sorry we do not have the ID, Plz reselect!");
                        continue;
                    }
                    else
                    {
                        idList.Add(inputId);
                    }
                    
                    
                    idListRemoveDuplicate = idList.Distinct().ToList();

                    listPro = rep.SaveProducts();
                    foreach (var item in listPro)
                    {
                        if (inputId == item.ID)
                        {
                            switch (inputId)
                            {
                                case 1:
                                case 2: var car = (Car)item;
                                    Console.WriteLine("Product ID: {0}", car.ID);
                                    Console.WriteLine("Product Name: {0}", car.Name);
                                    Console.WriteLine("Product Price: {0}", car.Price);
                                    Console.WriteLine("Product Color: {0}", car.Color);
                                    Console.WriteLine("Product Brand: {0} \n", car.Brand);
                                    break;

                                case 3:
                                case 4:
                                case 5: var cp = (Computer)item;
                                    Console.WriteLine("Product ID: {0}", cp.ID);
                                    Console.WriteLine("Product Name: {0}", cp.Name);
                                    Console.WriteLine("Product Price: {0}", cp.Price);
                                    Console.WriteLine("Product Memory: {0}", cp.Memory);
                                    Console.WriteLine("Product HardDrive: {0} \n", cp.HardDrive);
                                    break;

                                case 6:
                                case 7: var fn = (Furniture)item;
                                    Console.WriteLine("Product ID: {0}", fn.ID);
                                    Console.WriteLine("Product Name: {0}", fn.Name);
                                    Console.WriteLine("Product Price: {0}", fn.Price);
                                    Console.WriteLine("Product Material: {0}", fn.Material);
                                    Console.WriteLine("Product Function: {0} \n", fn.Function);
                                    break;

                                case 8:
                                case 9:
                                case 10: var se = (SportEquipment)item;
                                    Console.WriteLine("Product ID: {0}", se.ID);
                                    Console.WriteLine("Product Name: {0}", se.Name);
                                    Console.WriteLine("Product Price: {0}", se.Price);
                                    Console.WriteLine("Product Material: {0}", se.Material);
                                    Console.WriteLine("Product Type: {0} \n", se.Type);
                                    break;
                                default:
                                    break;
                            }

                        }

                    }


                    Console.WriteLine("How many of it do you like to purchase?");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    if (quantity <= 0)
                    {
                        Console.WriteLine("Sorry! You can not select this quantity!");
                        continue;
                    }
                    //dicCart.Add(inputId, quantity);
                    Store(inputId, quantity);
                    //quantityList.Add(quantity);
                    //cart.QuantityCollect.Add(quantity);
                    DisplayCartList();

                    //Ask for keep shopping or not
                    Console.WriteLine("1.Continue to go shopping.  2.Exit to pay and get receipt");
                    var option = Console.ReadLine();
                    if (option == "1")
                    {

                    }
                    else
                    {
                        Receipt();
                        break;
                    }
                    
                }
                catch
                {
                    Console.WriteLine("Sorry! You have put the wrong key \n");
                }

            }
        }
        #endregion

        #region
        public void DisplayCartList()
        {
            //shopping cart list
            Console.WriteLine("--------------------This is your shopping cart products list-------------------- \n");
            foreach (var id in idListRemoveDuplicate)
            {
                foreach (var pro in listPro)
                {
                    if (id == pro.ID)
                    {
                        Console.WriteLine("                                   Product ID: {0}", pro.ID);
                        switch (id)
                        {
                            case 1: Console.WriteLine("                                   Product quantity: {0}", sumCar1Quantity);
                                break;
                            case 2: Console.WriteLine("                                   Product quantity: {0}", sumCar2Quantity);
                                break;
                            case 3: Console.WriteLine("                                   Product quantity: {0}", sumComputer3Quantity);
                                break;
                            case 4: Console.WriteLine("                                   Product quantity: {0}", sumComputer4Quantity);
                                break;
                            case 5: Console.WriteLine("                                   Product quantity: {0}", sumComputer5Quantity);
                                break;
                            case 6: Console.WriteLine("                                   Product quantity: {0}", sumFurniture6Quantity);
                                break;
                            case 7: Console.WriteLine("                                   Product quantity: {0}", sumFurniture7Quantity);
                                break;
                            case 8: Console.WriteLine("                                   Product quantity: {0}", sumSport8Quantity);
                                break;
                            case 9: Console.WriteLine("                                   Product quantity: {0}", sumSport9Quantity);
                                break;
                            case 10: Console.WriteLine("                                   Product quantity: {0}", sumSport10Quantity);
                                break;
                            default:
                                break;
                        }

                        Console.WriteLine("                                   Product Name: {0}", pro.Name);
                        Console.WriteLine("                                   Product Price: {0} \n", pro.Price);
                        switch (id)
                        {
                            case 1: Console.WriteLine("Total Price of {0} {1}: {2} \n", sumCar1Quantity, pro.Name, pro.Price * sumCar1Quantity);
                                //totalSum += pro.Price * quantity;
                                break;
                            case 2: Console.WriteLine("Total Price of {0} {1}: {2} \n", sumCar2Quantity, pro.Name, pro.Price * sumCar2Quantity);
                                //totalSum += pro.Price * quantity;
                                break;
                            case 3: Console.WriteLine("Total Price of {0} {1}: {2} \n", sumComputer3Quantity, pro.Name, pro.Price * sumComputer3Quantity);
                                //totalSum += pro.Price * quantity;
                                break;
                            case 4: Console.WriteLine("Total Price of {0} {1}: {2} \n", sumComputer4Quantity, pro.Name, pro.Price * sumComputer4Quantity);
                                break;
                            case 5: Console.WriteLine("Total Price of {0} {1}: {2} \n", sumComputer5Quantity, pro.Name, pro.Price * sumComputer5Quantity);
                                break;

                            case 6: Console.WriteLine("Total Price of {0} {1}: {2} \n", sumFurniture6Quantity, pro.Name, pro.Price * sumFurniture6Quantity);
                                break;
                            case 7: Console.WriteLine("Total Price of {0} {1}: {2} \n", sumFurniture7Quantity, pro.Name, pro.Price * sumFurniture7Quantity);
                                break;
                            case 8: Console.WriteLine("Total Price of {0} {1}: {2} \n", sumSport8Quantity, pro.Name, pro.Price * sumSport8Quantity);
                                break;
                            case 9: Console.WriteLine("Total Price of {0} {1}: {2} \n", sumSport9Quantity, pro.Name, pro.Price * sumSport9Quantity);
                                break;
                            case 10: Console.WriteLine("Total Price of {0} {1}: {2} \n", sumSport10Quantity, pro.Name, pro.Price * sumSport10Quantity);
                                break;
                            default:
                                break;
                        }
                        
                    }
                }
            }
            var totalPayment = CalculateTotalPayment();
            Console.WriteLine("                                                           TOTAL PAYMENT: {0}", totalPayment);
            Console.WriteLine("--------------------------------------------------------------------------------");
        }
        #endregion

        #region
        public void Receipt()
        {
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("-------------------This is the RECEIPT of your shopping today------------------- \n");
            Console.Write("".PadRight(3));
            Console.Write("Product ID".PadRight(20));
            Console.Write("Product Quantity".PadRight(20));
            Console.Write("Product Name".PadRight(20));
            Console.Write("Product Price".PadRight(20));
            Console.WriteLine();
            foreach (var id in idListRemoveDuplicate)
            {
                foreach (var pro in listPro)
                {
                    if (id == pro.ID)
                    {
                        Console.Write("{0}".PadLeft(8).PadRight(30), pro.ID);
                        switch (id)
                        {
                            case 1: Console.Write("{0}".PadRight(10), sumCar1Quantity);
                                break;
                            case 2: Console.Write("{0}".PadRight(8), sumCar2Quantity);
                                break;
                            case 3: Console.Write("{0}".PadRight(20), sumComputer3Quantity);
                                break;
                            case 4: Console.Write("{0}".PadRight(15), sumComputer4Quantity);
                                break;
                            case 5: Console.Write("{0}".PadRight(20), sumComputer5Quantity);
                                break;
                            case 6: Console.Write("{0}".PadRight(15), sumFurniture6Quantity);
                                break;
                            case 7: Console.Write("{0}".PadRight(13), sumFurniture7Quantity);
                                break;
                            case 8: Console.Write("{0}".PadRight(15).PadLeft(5), sumSport8Quantity);
                                break;
                            case 9: Console.Write("{0}".PadRight(17), sumSport9Quantity);
                                break;
                            case 10: Console.Write("{0}".PadRight(16), sumSport10Quantity);
                                break;
                            default:
                                break;
                        }

                        Console.Write("{0}".PadRight(15), pro.Name);
                        Console.Write("{0} \n \n \n \n", pro.Price);
                        //switch (id)
                        //{
                        //    case 1: Console.WriteLine("Total Price of {0} {1}: {2} \n", sumCar1Quantity, pro.Name, pro.Price * sumCar1Quantity);
                        //        break;
                        //    case 2: Console.WriteLine("Total Price of {0} {1}: {2} \n", sumCar2Quantity, pro.Name, pro.Price * sumCar2Quantity);
                        //        break;
                        //    case 3: Console.WriteLine("Total Price of {0} {1}: {2} \n", sumComputer3Quantity, pro.Name, pro.Price * sumComputer3Quantity);
                        //        break;
                        //    case 4: Console.WriteLine("Total Price of {0} {1}: {2} \n", sumComputer4Quantity, pro.Name, pro.Price * sumComputer4Quantity);
                        //        break;
                        //    case 5: Console.WriteLine("Total Price of {0} {1}: {2} \n", sumComputer5Quantity, pro.Name, pro.Price * sumComputer5Quantity);
                        //        break;

                        //    case 6: Console.WriteLine("Total Price of {0} {1}: {2} \n", sumFurniture6Quantity, pro.Name, pro.Price * sumFurniture6Quantity);
                        //        break;
                        //    case 7: Console.WriteLine("Total Price of {0} {1}: {2} \n", sumFurniture7Quantity, pro.Name, pro.Price * sumFurniture7Quantity);
                        //        break;
                        //    case 8: Console.WriteLine("Total Price of {0} {1}: {2} \n", sumSport8Quantity, pro.Name, pro.Price * sumSport8Quantity);
                        //        break;
                        //    case 9: Console.WriteLine("Total Price of {0} {1}: {2} \n", sumSport9Quantity, pro.Name, pro.Price * sumSport9Quantity);
                        //        break;
                        //    case 10: Console.WriteLine("Total Price of {0} {1}: {2} \n", sumSport10Quantity, pro.Name, pro.Price * sumSport10Quantity);
                        //        break;
                        //    default:
                        //        break;
                        //}

                    }
                }
            }
            Console.WriteLine("                                                           TOTAL PAYMENT: {0}", totalSum);
            Console.WriteLine("\n");
            Console.WriteLine("-----------------Thank you for shopping today! Have a Good day!-----------------");
            Console.WriteLine("                                                          "+ DateTime.Now);
        }
        #endregion

        #region
        public void Store(int userInput, int quantity)
        {

            switch (userInput)
            {
                case 1: sumCar1Quantity += quantity;
                    break;
                case 2: sumCar2Quantity += quantity;
                    break;
                case 3: sumComputer3Quantity += quantity;
                    break;
                case 4: sumComputer4Quantity += quantity;
                    break;
                case 5: sumComputer5Quantity += quantity;
                    break;
                case 6: sumFurniture6Quantity += quantity;
                    break;
                case 7: sumFurniture7Quantity += quantity;
                    break;
                case 8: sumSport8Quantity += quantity;
                    break;
                case 9: sumSport9Quantity += quantity;
                    break;
                case 10: sumSport10Quantity += quantity;
                    break;
                default:
                    break;
            }
        }
        #endregion


        public decimal CalculateTotalPayment()
        {
            totalSum = 7000m * sumCar1Quantity + 10000m * sumCar2Quantity + 2000m * sumComputer3Quantity + 3000m * sumComputer4Quantity + 5000m * sumComputer5Quantity + 12000m * sumFurniture6Quantity + 4000m * sumFurniture7Quantity + 5000m * sumSport8Quantity + 50m * sumSport9Quantity + 100m * sumSport10Quantity;
            return totalSum;
        }
        //public List<Model.GeneralProduct> List { get; set; }
    }
}
