using Aula02.Entities;

namespace Aula02
{
    class Programs
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Aléx", 0.00);
            BusinessAccount bacc = new BusinessAccount(1002, "Jurema", 80.00, 500.00);
            //UPCASTING
            //Por serem os mesmos, um objeto da superclasse, pode receber outro objeto de uma subclasse
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Cleito", 0.00, 200.00);
            Account acc3 = new SavingsAccount(1004, "Anna", 20.00, 0.01);
            //DOWNCASTING
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.00);
            //BusinessAccount acc5 = (BusinessAccount) acc3; -Essa linha dará erro, pois acc3 é uma instância de SavingAccount, e não BusinessAccount
            /*Uma possível solução para o problema acima, é colocando um if()*/
            if(acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
            }
            if(acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount) acc3; 
                /*
                 Outra forma de escrever
                SavingAccount acc5 = acc3 as SavingAccount;
                 */

            }





            
        }
    }
}
