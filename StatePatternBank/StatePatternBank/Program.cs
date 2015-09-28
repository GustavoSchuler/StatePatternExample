using System;

namespace StatePatternBank
{

    class MainApp
    {

        static void Main()
        {
            Account account = new Account("Jimmy John Johnson");

            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);

            account.PayInterest();

            account.Withdraw(2000.00);
            account.Withdraw(1100.00);

            Console.ReadKey();
        }

    }

}
