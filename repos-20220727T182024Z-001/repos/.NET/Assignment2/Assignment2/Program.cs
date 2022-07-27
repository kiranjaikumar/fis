using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Account
    {
        double accountNo;
        string customerName;
        string accountType;
        string transactionType;
        double amount;
        double balance = 25000;
        public Account(double accountNo, string customerName, string accountType)
        {
            this.accountNo = accountNo;
            this.customerName = customerName;
            this.accountType = accountType;
        }
        public void credit(double amount)
        {
            if (amount > 0)
            {
                this.balance = this.balance + amount;
                this.amount = amount;
                this.transactionType = "Credit";
                Console.WriteLine("Amount: {0} has been credited to your account, Available balance: {1}", amount, balance);
            }
            else
            {
                Console.WriteLine("Please enter valid amount");
            }

        }
        public void debit(double amount)
        {
            if(amount <= 0)
            {
                Console.WriteLine("Please enter valid amount: ");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient fund, available balance: {0}",balance);
            }
            else
            {
                balance = balance - amount;
                this.amount = amount;
                this.transactionType = "Debit";
                Console.WriteLine("Amount: {0} has been debit from your account, available balance: {1} ", amount, balance);
            }

        }
        public void displayBalance()
        {
            Console.WriteLine("Current balnce: {0}",balance);
        }
        public void displayDetails()
        {
            Console.WriteLine("Account Details");
            Console.WriteLine("-----------------");
            Console.WriteLine("Customer name: {0}",customerName);
            Console.WriteLine("Account No: {0}",accountNo);
            Console.WriteLine("Account Type: {0}",accountType);
            Console.WriteLine("Available Balance: {0}",balance);
            Console.WriteLine("Last transaction type: {0}",transactionType);
            Console.WriteLine("Last transaction amount: {0}",amount);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter customer name: ");
            string customerName = Console.ReadLine();
            Console.WriteLine("Enter account no: ");
            double accountNo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter account type: ");
            string accountType = Console.ReadLine();

            Account acc = new Account(accountNo, customerName, accountType);
            double amount;

            int ch;
            do
            {
                
                Console.WriteLine("------------------------");
                Console.WriteLine("Select Operation:\n1. View account balance. \n2. Credit Amount \n3. Withdraw amount \n4. Display all details \n5. Exit");
                Console.WriteLine("------------------------");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        acc.displayBalance();
                        break;
                    case 2:
                        Console.WriteLine("Enter amount to credit:");
                        amount = Convert.ToDouble(Console.ReadLine());
                        acc.credit(amount);
                        break;
                    case 3:
                        Console.WriteLine("Enter amount to debit:");
                       amount = Convert.ToDouble(Console.ReadLine());
                        acc.debit(amount);
                        break;
                    case 4:
                        acc.displayDetails();
                        break;
                    default:
                        Console.WriteLine("Wrong Cgoice");
                        break;
                }
            } while (ch != 5);

        }
    }
}
