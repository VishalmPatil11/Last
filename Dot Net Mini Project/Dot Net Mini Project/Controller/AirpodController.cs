using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Net_Mini_Project.Controller
{
    class AirpodController
    {
        public static void FetchAirpodData(MyDbContext myDbContext, User user)
        {
            Airpod airpod = myDbContext.airpods.Find(user.UserId);
            Console.WriteLine(user.UserId);
            Console.WriteLine(user.UserName);
            Console.WriteLine(airpod.AirpodId);
            Console.WriteLine(user.UserName + "        " + airpod.AirpodName);
        }
        public static void AddProduct()
        {
            MyDbContext myDbContext = new MyDbContext();
            Airpod airpod = new Airpod();

            Console.Write("Please Enter the productName: ");
            airpod.AirpodName = Console.ReadLine();

            Console.Write("Please Enter the Quantity: ");
            //Console.ForegroundColor = ConsoleColor.Black;
            airpod.Quantity = Convert.ToInt32(Console.ReadLine());
            //Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Please Enter Price: ");
            airpod.Price = Convert.ToDecimal(Console.ReadLine());

            //Console.Write("please enter the userid: ");
            //airpod.user.UserId = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Please Enter the category: ");
            //airpod.Category = Console.ReadLine();

            myDbContext.airpods.Add(airpod);
            myDbContext.SaveChanges();

            Console.WriteLine("Product added sucessfully");
        }

        //public static void FetchProductData()
        //{
        //    MyDbContext myDbContext = new MyDbContext();
        //    Airpod airpod = new Airpod();
        //    Console.WriteLine("ProductName | Quantity | Price");
        //    foreach (var item in myDbContext.airpods)
        //    {
        //        Console.WriteLine(item.ProductName + "   " + item.Quantity + "      " + item.Price);
        //    }
        //}

        //public static void UpdateProduct()
        //{
        //    Console.WriteLine("Enter Product ID: ");
        //    int id = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Updated Price: ");
        //    int priceUpdated = Convert.ToInt32(Console.ReadLine());

        //    MyDbContext myDbContext = new MyDbContext();

        //    Airpod airpod = myDbContext.airpods.Find(id);
        //    airpod.Price = priceUpdated;
        //    myDbContext.airpods.Update(airpod);

        //    Console.WriteLine(myDbContext.SaveChanges());

        //    Console.WriteLine("Product updated sucessfully");
        //}

        //public static void RemoveProduct()
        //{
        //    MyDbContext myDbContext = new MyDbContext();
        //    Airpod airpod = new Airpod();
        //    Console.Write("Enter ProductName: ");
        //    airpod.ProductName = Console.ReadLine();

        //    Console.Write("Please Enter the UserId: ");
        //    airpod.UserId = Convert.ToInt32(Console.ReadLine());


        //    var removeProductData = myDbContext.airpods.First(x => x.ProductName == airpod.ProductName);

        //    myDbContext.airpods.Remove(removeProductData);

        //    //Console.ForegroundColor = ConsoleColor.White;

        //    myDbContext.airpods.Remove(removeProductData);
        //    myDbContext.SaveChanges();

        //    Console.WriteLine("product removed sucessfully");

        //}
    }
}
