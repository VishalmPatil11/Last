using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Net_Mini_Project.Controller
{
    class LoginController
    {
        public static void UserLogin()
        {
            //MyDbContext myDbContext = new MyDbContext();
            //Console.Write("Enter userName: ");
            //var userName = Console.ReadLine().ToLower();


            //Console.Write("Enter password: ");
            //var password = Console.ReadLine().ToLower();

            //Console.Write("Enter Role: ");
            //var role = Console.ReadLine();

            //bool isFound = false;
            //User user1 = null;
            ////User user1 = new User();

            //foreach (User user in myDbContext.users)
            //{
            //    if (user.UserName == userName && user.Password == password && user.Role == role)
            //    {
            //        user1 = user;
            //        isFound = true;
            //        Console.WriteLine("Login successful");
            //    }

            //}

            //if (isFound == false)
            //{
            //    Console.WriteLine("Invalid credentials");
            //}
            //if (user1 != null)
            //{

            //    if (user1.Role == "User")
            //    {
            //        AirpodController.FetchAirpodData(myDbContext, user1);
            //    }

            //}
            MyDbContext myDbContext = new MyDbContext();
            Console.Write("Enter userName: ");
            var userName = Console.ReadLine().ToLower();


            Console.Write("Enter password: ");
            var password = Console.ReadLine().ToLower();

            Console.Write("Enter Role: ");
            var role = Console.ReadLine();
           // var users = myDbContext.users.ToList();
           
            bool isfound = false;
            User user1 = null;
            foreach (User user in myDbContext.users)
            {
                //  if (user.Username == username && user.Password == password && user.Role == role)
                if (user.UserName == userName && user.Password == password)
                {
                    Console.WriteLine(user.UserName + " " + user.Role + " " + user.Password);
                    isfound = true;
                    user1 = user;
                    Console.WriteLine("login succesfully");
                    Console.WriteLine("Hello 1");
                    Console.WriteLine(user1.UserName+" "+user1.Role+" "+user1.Password);
                    break;
                }

            }
            if (isfound == false)
            {
                Console.WriteLine("Incorrect Credentials....");
            }
            Console.WriteLine("Hello 2");
            if (user1 != null)
            {
                Console.WriteLine("Hello 3");
                Console.WriteLine(user1.UserName + " " + user1.Role + " " + user1.Password);
                if (user1.Role == "User")
                {
                    Console.WriteLine("Hello 4");
                    Console.WriteLine(user1.UserName + " " + user1.Role + " " + user1.Password);
                    //AirpodController.FetchAirpodData(myDbContext, user1);
                    //AirpodController.FetchAirpodData(myDbContext, user1);
                    Console.WriteLine("Hello 5");
                }

            }
        }

        public static void AdminLogin()
        {
            MyDbContext myDbContext = new MyDbContext();
            Console.Write("Enter userName: ");
            var userName = Console.ReadLine().ToLower();


            Console.Write("Enter password: ");
            var password = Console.ReadLine().ToLower();

            bool isFound = false;

            foreach (User user in myDbContext.users)
            {
                if (user.UserName == userName && user.Password == password)
                {
                    isFound = true;
                    Console.WriteLine("Login successful");
                }

            }

            if (isFound == false)
            {
                Console.WriteLine("Invalid credentials");
            }
        }
    }
}
