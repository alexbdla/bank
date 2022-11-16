using Bank.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Account acc = new Account(1001, "Alex", 0.0);
        BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);


        // UPCASTING

        Account acc1 = bacc;
        Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
        Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

        // DOWNCASTING
        //BusinessAccount acc4 = acc2;
        BusinessAccount acc4 = (BusinessAccount)acc2;
        acc4.Loan(100.0);

        // A instrução abaixo gerará um erro em tempo de compilação:
        //BusinessAccount acc5 = (BusinessAccount)acc3;
        if (acc3 is BusinessAccount)
        {
            //BusinessAccount acc5 = (BusinessAccount)acc3;
            BusinessAccount acc5 = acc3 as BusinessAccount;
            acc5.Loan(200.0);
            Console.WriteLine("Loan!");
        }

        if (acc3 is SavingsAccount)
        {
            SavingsAccount acc5 = (SavingsAccount)acc3;
            acc5.UpdateBalance();
            Console.WriteLine("Update!");
        }


        Account acc6 = new Account(1005, "Alex", 500.0);
        Account acc7 = new SavingsAccount(1006, "Anna", 500.0, 1);
        Account acc8 = new BusinessAccount(1007, "Pedro", 500.0, 1000);

        acc6.Withdraw(10.0);
        acc7.Withdraw(10.0);
        acc8.Withdraw(10.0);

        Console.WriteLine(acc6.Balance);
        Console.WriteLine(acc7.Balance);
        Console.WriteLine(acc8.Balance);



    }
}