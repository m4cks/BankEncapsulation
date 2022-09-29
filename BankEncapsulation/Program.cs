using System;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            Console.WriteLine($"Current account balance: {account.GetBalance()}");
            double deposit = 0;
            while(true)
            {
                Console.WriteLine("Make a deposit by typing a number!");
                try
                {
                    deposit = Int32.Parse(Console.ReadLine());
                } catch
                {
                    Console.WriteLine("If you don't want to type a valid number format, I'm just gonna close the program! Ha!");
                    break;
                }
                account.Deposit(deposit);
                Console.WriteLine($"Nice! Your new account balance is: {account.GetBalance()}");
            }
        }
    }
}
