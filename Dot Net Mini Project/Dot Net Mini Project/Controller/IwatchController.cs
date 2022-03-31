﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Net_Mini_Project.Controller
{
    class IwatchController
    {
        public static void FetchIwatchData(MyDbContext myDbContext, User user)
        {
            Iwatch iwatch = myDbContext.iwatches.Find(user.UserId);
            Console.WriteLine(user.UserName + "        " + iwatch.IwatchName);
        }
        //public static void AddProduct()
        //{
        //    MyDbContext myDbContext = new MyDbContext();
        //    Iwatch iwatch = new Iwatch();

        //    Console.Write("Please Enter the productName: ");
        //    iwatch.ProductName = Console.ReadLine();

        //    Console.Write("Please Enter the Quantity: ");
        //    //Console.ForegroundColor = ConsoleColor.Black;
        //    iwatch.Quantity = Convert.ToInt32(Console.ReadLine());
        //    //Console.ForegroundColor = ConsoleColor.White;

        //    Console.Write("Please Enter Price: ");
        //    iwatch.Price = Convert.ToDecimal(Console.ReadLine());

        //    Console.Write("Please Enter the UserId: ");
        //    iwatch.UserId = Convert.ToInt32(Console.ReadLine());

        //    Console.Write("Please Enter the category: ");
        //    iwatch.Category = Console.ReadLine();

        //    myDbContext.iwatches.Add(iwatch);
        //    myDbContext.SaveChanges();

        //    Console.WriteLine("Product added sucessfully");
        //}

        //public static void FetchProductData()
        //{
        //    MyDbContext myDbContext = new MyDbContext();
        //    Iwatch iwatch = new Iwatch();
        //    Console.WriteLine("ProductName | Quantity | Price");
        //    foreach (var item in myDbContext.iwatches)
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

        //    Iwatch iwatch = myDbContext.iwatches.Find(id);
        //    iwatch.Price = priceUpdated;
        //    myDbContext.iwatches.Update(iwatch);

        //    Console.WriteLine(myDbContext.SaveChanges());

        //    Console.WriteLine("Product updated sucessfully");
        //}

        //public static void RemoveProduct()
        //{
        //    MyDbContext myDbContext = new MyDbContext();
        //    Iwatch iwatch = new Iwatch();
        //    Console.Write("Enter ProductName: ");
        //    iwatch.ProductName = Console.ReadLine();

        //    Console.Write("Please Enter the UserId: ");
        //    iwatch.UserId = Convert.ToInt32(Console.ReadLine());


        //    var removeProductData = myDbContext.iwatches.First(x => x.ProductName == iwatch.ProductName);

        //    myDbContext.iwatches.Remove(removeProductData);

        //    //Console.ForegroundColor = ConsoleColor.White;

        //    myDbContext.iwatches.Remove(removeProductData);
        //    myDbContext.SaveChanges();

        //    Console.WriteLine("product removed sucessfully");

        //}
    }
}

