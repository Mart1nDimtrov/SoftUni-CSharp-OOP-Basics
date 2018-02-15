using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<BankAccount> bankAccounts = new List<BankAccount>();

            while (command != "End")
            {
                string[] commandArgs = command
                                        .Split(new char[] { ' ' } , StringSplitOptions.RemoveEmptyEntries)
                                        .ToArray();

                if (commandArgs[0] == "Create")
                {
                    Create(int.Parse(commandArgs[1]), ref bankAccounts);
                } else if (commandArgs[0] == "Withdraw")
                {
                    Withdraw(int.Parse(commandArgs[1]), Decimal.Parse(commandArgs[2]), ref bankAccounts);
                }
                else if (commandArgs[0] == "Deposit")
                {
                    Deposit(int.Parse(commandArgs[1]), Decimal.Parse(commandArgs[2]), ref bankAccounts);
                }
                else if (commandArgs[0] == "Print")
                {
                    Print(int.Parse(commandArgs[1]), ref bankAccounts);
                }

                command = Console.ReadLine();

            }

        }


        public static void Create(int id, ref List<BankAccount> bankAccounts)
        {
            BankAccount bankAcc = bankAccounts.Where(b => b.Id == id)
                                    .FirstOrDefault();
            if (bankAcc != null)
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                BankAccount bankAccNew = new BankAccount();
                bankAccNew.Id = id;
                bankAccounts.Add(bankAccNew);
            }
        }

        public static void Withdraw(int id, decimal amount, ref List<BankAccount> bankAccounts)
        {
            BankAccount bankAcc = bankAccounts.Where(b => b.Id == id)
                                    .FirstOrDefault();
            if (bankAcc == null)
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                if (bankAcc.Balance - amount >= 0)
                {
                    bankAcc.Withdraw(amount);
                }
                else
                {
                    Console.WriteLine("Insufficient balance");
                }
            }
        }
        public static void Deposit(int id, decimal amount, ref List<BankAccount> bankAccounts)
        {
            BankAccount bankAcc = bankAccounts.Where(b => b.Id == id)
                                   .FirstOrDefault();
            if (bankAcc == null)
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                bankAcc.Deposit(amount);
            }
        }

        public static void Print(int id, ref List<BankAccount> bankAccounts)
        {
            BankAccount bankAcc = bankAccounts.Where(b => b.Id == id)
                                               .FirstOrDefault();
            if (bankAcc == null)
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                Console.WriteLine(bankAcc);
            }
           
        }
    }
}
