using System;
using System.Data;
using BankMiddleLayer;

namespace Bank_System
{ 

    internal class Program
    {
        static void TastFindClient(int ID)
        {
            clsClient client = clsClient.Find(ID);
            if (client != null)
            {
                Console.WriteLine(client.FirstName + " " + client.LastName);
               

                Console.WriteLine(client.AccountBalance);


            }
            else
            {
                Console.WriteLine("No Client With ID Number "+ ID);
            }
        }
        static void TastClientList() 
        {
            DataTable dt =clsClient.GetAllClients();
            foreach (DataRow row in dt.Rows) 
            {

                Console.WriteLine("{0}{1}", row["ClientID"], row["FirstName"]);
            }

        }
        static void TestIsClientExit(int ID)
        {
            if (clsClient.IsClientExit(ID))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        static void TestDeleteClient(int ID)
        {
            if (clsClient.DeleteClient(ID))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        static void TestAddNewClient()
        {
            clsClient client = new clsClient();
            

            client.FirstName = "Ferhat";
            client.LastName = "Soussi";
            client.Email = "Ferhat@gmail.com";
            client.Phone = "";
            client.AccountNumber = "A107";
            client.PinCode = 3333;
            client.AccountBalance = 7500;

            if (client.Save())
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }


        static void TestDeposite(int ID,int Amount)
        {
            clsClient client = clsClient.Find(ID);

            if (client!=null)
            {
                if (client.Deposite(ID, Amount))
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }


        static void TestWithDraw(int ID, int Amount)
        {
            clsClient client = clsClient.Find(ID);

            if (client != null)
            {
                if (client.WithDraw(ID, Amount))
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
        static void TestGetTotalBalances()
        {
            int Totalbalances = clsClient.GetTotalBalances();
            if (Totalbalances!=0)
            {
                Console.WriteLine(Totalbalances);
            }
            else
            {
                Console.WriteLine(" No");
            }
        }
        static void TestUpdateClient(int ID)
        {
            clsClient client = clsClient.Find(ID);

            client.FirstName = "Ferhat";
            client.LastName = "Soussi";
            client.Email = "Ferhat@gmail.com";
            client.Phone = "000000000";
            client.AccountNumber = "A107";
            client.PinCode = 3333;
            client.AccountBalance = 8000;

            if (client.Save())
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }


        static void TastFindUser(int ID)
        {
            clsUser user = clsUser.Find(ID);
            if (user != null)
            {
                Console.WriteLine(user.UserName);
                Console.WriteLine(user.PassWord);
                Console.WriteLine(user.UserID);
                Console.WriteLine(user.Permissions);

            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static void TestAddNewUser()
        {
            clsUser user = new clsUser();
            user.UserName = "User3";
            user.PassWord = "3333";
            user.Permissions = 1;

            if (user.Save())
            {
                Console.WriteLine("Yes");

            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static void TestUpdateUser(int ID)
        {
            clsUser user = clsUser.Find(ID);
            if (user != null)
            { 
            user.UserName = "User4";
            user.PassWord = "4444";
            user.Permissions = 8;
            if (user.Save())
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            }
            else
            {
                Console.WriteLine("Nonooooooo");

            }
        }

        static void TestIsUserExit(int ID)
        {
            if (clsUser.IsUserExit(ID))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static void TestDeleteUser(int ID)
        {
            if (clsUser.IsUserExit(ID))
            {
                if (clsUser.DeleteUser(ID))
                {
                    Console.WriteLine("Done Delete");
                }
                else
                {
                    Console.WriteLine("Not Delete");
                }
            }
            else
            {
                Console.WriteLine("User Not Exit");
            }
        }

        static void TestUsersList()
        {
            DataTable dt = clsUser.GetAllUsers();
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine("{0}{1}{2}{3}", row["UserID"], row["UserName"], row["PassWord"], row["Permissions"]);

            }
           
        }

        static void Main(string[] args)
        {
            //TastFindClient(1);
            //TastFindClient(2);
            //TastClientList();
            //TestIsClientExit(1);
            //TestIsClientExit(2);
            //TestDeleteClient(2);
            //TestAddNewClient();
            //TestUpdateClient(3);
            //TestDeposite(3, -12);
            //TestWithDraw(7,300);
            //TestGetTotalBalances();

            //TastFindUser(9);
            //TestAddNewUser();
            //TestUpdateUser(22)
            //TestIsUserExit(11);
            //TestDeleteUser(33);
            //TestUsersList();



            Console.ReadKey();
        }
    }
}
