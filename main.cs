/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
using System.Collections.Generic;

class Bank
{
    static Dictionary<string, double> accounts = new Dictionary<string, double>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Welcome Back John Doe");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Exit");
            Console.WriteLine("4. CheckBalance");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Deposit();
                    break;
                case 2:
                    Withdraw();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                case 4:
                    CheckBalance();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void Deposit()
    {
            Console.Write("Enter deposit amount: ");
            double amount = double.Parse(Console.ReadLine());

            Console.WriteLine("Deposit successful!");
    }

    static void Withdraw()
    {
            Console.Write("Enter withdrawal amount: ");
            double amount = double.Parse(Console.ReadLine());
            Console.WriteLine("Withdrawal successful!");
    }
    
    static void CheckBalance()
    {
        
        Console.WriteLine($"Balance: ");
        
    }

}

