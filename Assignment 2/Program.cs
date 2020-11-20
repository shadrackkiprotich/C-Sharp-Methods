using System;

namespace Assignment_2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter your name: ");
            string name=Console.ReadLine();
            Console.WriteLine("Enter the Initial Balance :");
            decimal  number=Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter your account Number:");
            var num = Convert.ToInt32(Console.ReadLine());
            BankAccount();
            
        }
      
    }
    public class BankAccount
    {
        
        public string owner { get; set; }
        public int number { get; set; }
        public decimal balance { get; set; }
        public static string accountNumberSeed = 1234567890;
       
        public void MakeDeposit( decimal number, DateTime date, string note)
        {
            this.owner = name;
            this.number = initialbalance;
            this.number = accountNumberSeed.ToString();
            accountNumberSeed++;

        }
        public void MakeWithdrawal( decimal number, DateTime date, string note)
        {

        }
    }
        

}
