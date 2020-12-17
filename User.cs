using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_2
{
    public class User
    {
        public double Balance { get; set; } = 0;

        public void Add(string quantity)
        {
            if(double.Parse(quantity) > 0) {

                this.Balance += Math.Round(double.Parse(quantity), 2);
                Console.WriteLine($"You are successfully top up user account");
            } else
            {
                Console.WriteLine("Top up is failed");
            }
        }

        public void ShowBalance()
        {
            Console.WriteLine($"User balance is: {this.Balance}Eur");
        }
    }
}
