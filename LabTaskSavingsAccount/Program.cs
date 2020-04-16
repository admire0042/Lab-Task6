using System;

namespace LabTaskSavingsAccount
{
    class Program
    {
        static void Main(string[] args)
        {
             Account saver1 = new Account();
             Account saver2 = new Account();

             
           

           
           Account.ModifyInterestRate(5);
           saver1.SavingsBalance = 2000m;
           saver2.SavingsBalance = 3000m;

            Console.WriteLine($"Total on Savings Account before modifying is {saver1}");
            Console.WriteLine($"Total on Savings Account before modifying is {saver2}");

        }
    }
}



