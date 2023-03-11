using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice__19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Бурганов", "Эмиль", "Эдуардович", "1234567890412340", 0);
            account.TopUpAccount = 1000;
            account.TopUpAccount = 4000;
            account.WithdrawMoneyFromAccount = -1000;


            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(new BankAccount("Бурганов", "Эмиль", "Эдуардович", "12345678901234567890", 10));
            bankAccounts.Add(new BankAccount("Осипов", "Эмиль", "Эдуардович", "12345678901234567890", 2000));
            bankAccounts.Add(new BankAccount("Петров", "Эмиль", "Эдуардович", "12345678901234567890", 100));
            bankAccounts.Add(new BankAccount("Алексеев", "Эмиль", "Эдуардович", "12345678901234567890", 5000));
            bankAccounts.Add(new BankAccount("Климов", "Эмиль", "Эдуардович", "123456789041234567890", 90000));

            Console.WriteLine("\nДо сортировки:");
            foreach (BankAccount bankAccount in bankAccounts)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine(bankAccount.Info);
            }

            bankAccounts.Sort((f, s) => string.Compare(f.FullName, s.FullName));

            Console.WriteLine("\nПосле сортировки по алфавиту:");
            foreach (BankAccount bankAccount in bankAccounts)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine(bankAccount.FullName);
            }

            double min = 10;
            double max = 1000;

            Console.WriteLine("\nПосле сортировки по балансу:");
            foreach (BankAccount bankAccount in bankAccounts)
                if (bankAccount.Balance >= min && bankAccount.Balance <= max)
                    Console.WriteLine($"У {bankAccount.FullName} баланс = {bankAccount.Balance}");

            Console.ReadLine();
        }
    }
}
