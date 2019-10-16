using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro1
{
    public class Account
    {
        int money = 200000;
        public Account(int amount)
        {
            money = amount;
        }

        public void Deposit(int amount)
        {
            money += amount;
            Console.WriteLine("Tong so du ban dang co la "+ money);
        }

        public void Withdraw(int amount)
        {
            money -= amount;
            Console.WriteLine("Tong so du ban dang co la " + money);
        }

        public int Balance()
        {

            Console.WriteLine("Tong so tien ban dang co la " + money);
            return money;
            
        }
    }
}
