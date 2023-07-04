using Aula01.Entities;
namespace Aula01
{
    class Programs
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(80010, "Itaú", 100.00, 500.00);
            Console.WriteLine(account.Balance.ToString("F2"));
        }
    }
}
