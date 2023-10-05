using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBank
{
    public class BankAccount
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private double balance;

        public double Balance
        {
            get { return balance; }
        }
        private bool locked;

        public BankAccount(string name, double balance, bool locked)
        {
            Name = name;
            this.balance = balance;
            this.locked = locked;

        }
        public BankAccount(double balance)
        {
            this.balance = balance;
        }
        public BankAccount(string name, double balance)
        {
            Name = name;
            this.balance = balance;

        }
        public void Deposit(double amount)
        {
            if (locked == true)
            {
                Console.WriteLine("Du kan ikke indsætte penge på en låst konto.");
            }
            else if (locked == false)
            {
                balance += amount;
                Console.WriteLine("Din nye balance er: " + balance);
            }
        }
        public void Withdraw(double amount)
        {
            if (locked == false && balance >= amount)
            {
                balance -= amount;
                Console.WriteLine("Din balance er: " + balance);
            }
            else
            {
                Console.WriteLine("Du kan ikke hæve flere penge end du har");
            }
        }
        public void ChangeLockState()
        {
            locked = !locked;
        
        }
        public override string ToString()
        {
            return "Name: " + name + ", Balance: " + balance;
        }



    }
}
