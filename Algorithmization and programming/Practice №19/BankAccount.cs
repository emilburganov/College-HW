using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Practice__19
{
    internal class BankAccount
    {
        private string Surname;
        private string Name;
        private string Patronymic;
        private string accountNumber;
        public string AccountNumber
        {
            get
            {
                return accountNumber;
            }
            set
            {
                
                while(value.Length != 20)
                {
                    Console.WriteLine("< 20");
                    value = Console.ReadLine();
                }
                
                accountNumber = value;
            }
        }
        public double Balance;

        public BankAccount(string surname, string name, string patronymic, string accountNumber, double balance)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public string Info
        {
            get
            {
                return $"Полное имя клиента - {FullName} \nНомер счёта - {this.AccountNumber} \nБаланс - {Balance}";
            }
        }
        public string FullName
        {
            get
            {
                return $"{Surname} {Name[0]}.{Patronymic[0]}.";
            }
        }
        public double TopUpAccount
        {
            set
            {
                if (value > 0) Balance += value;
                else
                {
                    Console.WriteLine("\nСумма пополнения не может быть отрицательной!");
                }
            }
        }
        public double WithdrawMoneyFromAccount
        {
            set
            {
                if (value <= Balance && value >= 0) 
                    Balance -= value;
                else if (value < 0) 
                    Console.WriteLine("\nСумма снятия не может быть отрицательной!");
                else
                {
                    Console.WriteLine("\nСумма снятия не может быть больше остатка!");
                }
            }
        }
    }
}
