using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_2
{
    public class Shop
    {
        public void List()
        {
            if(Cup.Quantity > 0)
            {
                Console.WriteLine($"Product name: {Cup.Name} Quantity: {Cup.Quantity} Price: {Cup.Price}Eur");
            }
            if (Candy.Quantity > 0)
            {
                Console.WriteLine($"Product name: {Candy.Name} Quantity: {Candy.Quantity} Price: {Candy.Price}Eur");
            }
            if (Book.Quantity > 0)
            {
                Console.WriteLine($"Product name: {Book.Name} Quantity: {Book.Quantity} Price: {Book.Price}Eur");
            }
        }

        public void Buy(string product, string quantity, User user)
        {
            if(product == "cup")
            {
                if (int.Parse(quantity) <= Cup.Quantity && int.Parse(quantity) > 0 && user.Balance >= (Cup.Price * double.Parse(quantity)))
                {
                    
                    Cup.Quantity = Cup.Quantity - int.Parse(quantity);
                    user.Balance -= (Cup.Price * double.Parse(quantity));
                    user.Balance = Math.Round(user.Balance, 2);
                    Console.WriteLine($"You are successfully bought a {Cup.Name}, quantity: {quantity}!");
                }
                else if (user.Balance < (Cup.Price * double.Parse(quantity)))
                {
                    Console.WriteLine("Sorry, you don't have such money!");
                }
                else
                {
                    Console.WriteLine("Sorry, we don't have such quantity on stock!");
                }
            }
            else if (product == "candy")
            {
                if (int.Parse(quantity) <= Candy.Quantity && int.Parse(quantity) > 0 && user.Balance >= (Candy.Price * double.Parse(quantity)))
                {
                    Candy.Quantity = Candy.Quantity - int.Parse(quantity);
                    user.Balance -= (Candy.Price * double.Parse(quantity));
                    user.Balance = Math.Round(user.Balance, 2);
                    Console.WriteLine($"You are successfully bought a {Candy.Name}, quantity: {quantity}!");
                }
                else if (user.Balance < (Candy.Price * double.Parse(quantity)))
                {
                    Console.WriteLine("Sorry, you don't have such money!");
                }
                else
                {
                    Console.WriteLine("Sorry, we don't have such quantity on stock!");
                }
            }
            else if (product == "book")
            {
                if (int.Parse(quantity) <= Book.Quantity && int.Parse(quantity) > 0 && user.Balance >= (Book.Price * double.Parse(quantity)))
                {
                    Book.Quantity = Book.Quantity - int.Parse(quantity);
                    user.Balance -= (Book.Price * double.Parse(quantity));
                    user.Balance = Math.Round(user.Balance, 2);
                    Console.WriteLine($"You are successfully bought a {Book.Name}, quantity: {quantity}!");
                }
                else if (user.Balance < (Book.Price * double.Parse(quantity)))
                {
                    Console.WriteLine("Sorry, you don't have such money!");
                }
                else
                {
                    Console.WriteLine("Sorry, we don't have such quantity on stock!");
                }
            }
            else
            {
                Console.WriteLine("Buy process is not successfully!");
            }
        }

        public void Add(string product, string quantity)
        {
            if (product == "cup")
            {
                if (int.Parse(quantity) >= 0)
                {
                    Cup.Quantity = Cup.Quantity + int.Parse(quantity);
                    Console.WriteLine($"You are successfully added a {Cup.Name}, quantity: {quantity}!");
                }
                else
                {
                    Console.WriteLine("Sorry, You can't add negative quantity");
                }
            }
            else if (product == "candy")
            {
                if (int.Parse(quantity) >= 0)
                {
                    Candy.Quantity = Candy.Quantity + int.Parse(quantity);
                    Console.WriteLine($"You are successfully added a {Candy.Name}, quantity: {quantity}!");
                }
                else
                {
                    Console.WriteLine("Sorry, You can't add negative quantity");
                }
            }
            else if (product == "book")
            {
                if (int.Parse(quantity) >= 0)
                {
                    Book.Quantity = Book.Quantity + int.Parse(quantity);
                    Console.WriteLine($"You are successfully added a {Book.Name}, quantity: {quantity}!");
                }
                else
                {
                    Console.WriteLine("Sorry, You can't add negative quantity");
                }
            }
            else
            {
                Console.WriteLine("Add process is not successfully!");
            }

        }
    }
}
