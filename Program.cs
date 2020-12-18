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
            action = action.ToLower();
            string[] data = action.Split(" ");
            var user = new User();

            while (data[0] != "stop")
            {
                var shop = new Shop();
                try
                {
                    switch (data[0])
                    {
                        case "list":
                            shop.List();
                            break;
                        case "buy":
                            shop.Buy(data[1], data[2], user);
                            break;
                        case "add":
                            shop.Add(data[1], data[2]);
                            break;
                        case "topup":
                            user.Add(data[1]);
                            break;
                        case "show":
                            if (data[1] == "balance")
                            {
                                user.ShowBalance();
                            } else
                            {
                                Console.WriteLine("There is no such command");
                            }
                            break;
                        default:
                            Console.WriteLine("There is no such command");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("There is no such command");
                }
                //if(data[0] == "list")
                //{
                //    shop.List();
                //}
                //else if (data[0] == "buy")
                //{
                //    try
                //    {
                //        shop.Buy(data[1], data[2], user);
                //    }
                //    catch (Exception)
                //    {

                //        Console.WriteLine("There is no such command");
                //    }
                //}
                //else if (data[0] == "add")
                //{
                //    try
                //    {
                //        shop.Add(data[1], data[2]);
                //    }
                //    catch (Exception)
                //    {

                //        Console.WriteLine("There is no such command");
                //    }
                //}
                //else if (data[0] == "topup")
                //{
                //    try
                //    {
                //        user.Add(data[1]);
                //    }
                //    catch (Exception)
                //    {

                //        Console.WriteLine("There is no such command");
                //    }
                //}
                //else if (data[0] == "show" && data[1] == "balance")
                //{
                //    try
                //    {
                //        user.ShowBalance();
                //    }
                //    catch (Exception)
                //    {

                //        Console.WriteLine("There is no such command");
                //    }
                //}
                //else
                //{
                //    Console.WriteLine("There is no such command");
                //}
                action = Console.ReadLine();
                action = action.ToLower();
                data = action.Split(" ");
            }


        }
    }
}
