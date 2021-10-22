using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork6
{
    public enum AccountType 
    {
        savings = 1,
        checking,
        current
    };

    class BankAccount
    {   
        public static int number = Int32.Parse(Console.ReadLine());
        public static int balance = Int32.Parse(Console.ReadLine());
        public static int n = Int32.Parse(Console.ReadLine());

        public static void DataAccess()
        {
            var type = (AccountType)n;
            Console.WriteLine(number + " " + balance + " " + type);
        }

        public static void Withdraw()
        {
            int money = Int32.Parse(Console.ReadLine());
            if (money > balance)
            {
                Console.WriteLine("На счёте недостаточно средств");
            }
            else
            {
                balance = balance - money;
            }
            DataAccess();
        }
        public static void ToDeposit()
        {
            int money = Int32.Parse(Console.ReadLine());
            balance = balance + money;
            DataAccess();
        }


        static void Main(string[] args)
        {
            Console.WriteLine("7.1");
            Console.WriteLine("Ваш номер счёта, баланс, тип");
            DataAccess();
            Console.ReadKey();

        }
    }
}
