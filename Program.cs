using System;

namespace BankEncapsulationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();

            Console.WriteLine("Would you like to make a deposit, get balance, or both?\n");
            Console.WriteLine("Please enter: \n");
            Console.WriteLine("1 for Deposit\n");
            Console.WriteLine("2 for Balance\n");
            Console.WriteLine("3 for Both: Deposit and Balance\n");
            Console.WriteLine("Enter choice: ");
            var choice = int.Parse(Console.ReadLine());

            if(choice == 1)
            {
                Console.WriteLine("Please enter your deposit amount: ");
                var amount = decimal.Parse(Console.ReadLine());

                account.Deposit(amount);
            }

            if(choice == 2)
            {
                Console.WriteLine($"Your balance is: {account.GetBalance()}");
            }

            if(choice == 3)
            {
                Console.WriteLine("Please enter your deposit amount: ");
                var amount = decimal.Parse(Console.ReadLine());

                account.Deposit(amount);

                Console.WriteLine($"Your balance is: {account.GetBalance()}");
            }
        }
    }
}
