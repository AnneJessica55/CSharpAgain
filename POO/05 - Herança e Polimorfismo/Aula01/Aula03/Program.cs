using Aula03.Entities;

namespace Aula01
{
    class Programs
    {
        static void Main(string[] args)
        {


            Account acc1 = new Account(1001, "Filipe", 500.00);
            Account acc2 = new SavingsAccount(1002, "Anna",500.00,0.01);

            acc1.Withdraw(10.00);
            acc2.Withdraw(10.00);

            Console.WriteLine($"Acc1: R$ {acc1.Balance.ToString("F2")}\nAcc2: R${acc2.Balance.ToString("F2")}");




        }
    }
}
