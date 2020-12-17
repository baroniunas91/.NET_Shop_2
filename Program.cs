using System;

namespace Shop_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an action - List, Buy, Add");
            Console.WriteLine("Example: Add Candy 5");
            Console.WriteLine("Enter to end program: \"stop\"");
            string action = Console.ReadLine();
            string[] data = action.Split(" ");
            var user = new User();

            while (data[0] != "stop")
            {
                var shop = new Shop();
                if(data[0] == "List")
                {
                    shop.List();
                }
                else if (data[0] == "Buy")
                {
                    try
                    {
                        shop.Buy(data[1], data[2], user);
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("There is no such command");
                    }
                }
                else if (data[0] == "Add")
                {
                    try
                    {
                        shop.Add(data[1], data[2]);
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("There is no such command");
                    }
                }
                else if (data[0] == "Topup")
                {
                    try
                    {
                        user.Add(data[1]);
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("There is no such command");
                    }
                }
                else if (data[0] == "Show" && data[1] == "Balance")
                {
                    try
                    {
                        user.ShowBalance();
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("There is no such command");
                    }
                }
                else
                {
                    Console.WriteLine("There is no such command");
                }
                action = Console.ReadLine();
                data = action.Split(" ");
            }


        }
    }
}
