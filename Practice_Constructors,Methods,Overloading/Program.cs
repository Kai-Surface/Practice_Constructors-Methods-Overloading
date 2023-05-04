using System;

namespace Practice_Constructors_Methods_Overloading
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Car info:");
            Car defaultCar = new Car();
            Car makeModelCar = new Car("Toyota", "Rav4");
            Car fullCar = new Car("Hyundai", "Sonata", "2010", 100000);
            Console.WriteLine(defaultCar);
            Console.WriteLine(makeModelCar);
            Console.WriteLine(fullCar);

            Console.WriteLine();

            Console.WriteLine("Bank info:");

            BankAccount account = new BankAccount("12345", "Will Cram", 20);
            Console.WriteLine(account);
            account.Deposit(500);
            Console.WriteLine(account);
            account.Deposit(-15000);
            Console.WriteLine(account);
            account.Withdraw(300);
            Console.WriteLine(account);
            account.Withdraw(-500);
            Console.WriteLine(account);
        }
    }
}