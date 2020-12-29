using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_2
{
    public class UserService
    {
        private readonly IPrinter _printService;
        public double Balance { get; set; } = 0;

        public UserService(IPrinter printer)
        {
            _printService = printer;
        }

        public void Add(string quantity)
        {
            if(double.Parse(quantity) > 0) {

                this.Balance += Math.Round(double.Parse(quantity), 2);
                _printService.Print($"You are successfully top up user account");
            } else
            {
                _printService.Print("Top up is failed");
            }
        }

        public void ShowBalance()
        {
            _printService.Print($"User balance is: {this.Balance}Eur");
        }
    }
}
