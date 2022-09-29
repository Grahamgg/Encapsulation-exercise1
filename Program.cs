using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var acc = new BankAccount();
            var bal = acc.GetBalance();
            

            Console.WriteLine("How much do you want to deposit");
            var depositAmount = double.Parse(Console.ReadLine());
            
            Console.WriteLine($"Your account balance is now {bal + depositAmount}");
            

        }
    }
}
