using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Person_Class.Models
{
    public class Person
    {
        private string name;
        private int age;
        private List<BankAccount> accounts;

        public Person (string name, int age)
        {
            this.name = name;
            this.age = age;
            this.accounts = new List<BankAccount>();
        }

        public Person(string name, int age, List<BankAccount> accounts)
        {
            this.name = name;
            this.age = age;
            this.accounts = accounts;
        }

        public decimal GetBalance()
        {
            return accounts.Select(a => a.Balance).Sum();
        }

    }
}
