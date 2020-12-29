using System;
using System.Collections.Generic;

namespace Shop_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //var _printService = new ConsolePrinter();
            //var _readService = new ConsoleReader();

            var _printService = new FilePrinter();
            var _readService = new FileReader("read.txt");

            var _shopService = new ShopService(_printService);
            var _userService = new UserService(_printService);

            _printService.Print("Please enter an action - List, Buy, Add");
            _printService.Print("Example: Add Candy 5");
            _printService.Print("Enter to end program: \"stop\"");

            List<string> lines = _readService.Read();

            foreach (var line in lines)
            {
                string action = line;

                action = action.ToLower();
                string[] data = action.Split(" ");

                while (data[0] != "stop")
                {
                    try
                    {
                        switch (data[0])
                        {
                            case "list":
                                _shopService.List();
                                break;
                            case "buy":
                                _shopService.Buy(data[1], data[2], _userService);
                                break;
                            case "add":
                                _shopService.Add(data[1], data[2]);
                                break;
                            case "topup":
                                _userService.Add(data[1]);
                                break;
                            case "show":
                                if (data[1] == "balance")
                                {
                                    _userService.ShowBalance();
                                }
                                else
                                {
                                    _printService.Print("There is no such command");
                                }
                                break;
                            default:
                                _printService.Print("There is no such command");
                                break;
                        }
                    }
                    catch (Exception)
                    {
                        _printService.Print("There is no such command");
                    }
                    if (lines.Count > 1)
                    {
                        break;
                    }
                    else
                    {
                        lines = _readService.Read();
                        action = lines[0];
                        data = action.Split(" ");
                    }
                }
            }
        }
    }
}
