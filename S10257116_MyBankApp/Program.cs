using BankAccount;
using System.IO;
using System.Runtime.CompilerServices;


    string[] accounts = File.ReadAllLines("savings_account.csv");
    List<SavingsAccount> sAccList = new();
    for (int i = 1; i < accounts.Length; i++)
    {
        string[] index = accounts[i].Split(',');
        string number = index[0];
        string name = index[1];
        double bal = Convert.ToDouble(index[2]);
        double intrate = Convert.ToDouble(index[3]);
        SavingsAccount account = new(number, name, bal, intrate);
        sAccList.Add(account);
    }
    while (true)
    {
        DisplayMenu();
        int option = Convert.ToInt32(Console.ReadLine());
        if (option == 0)
        {
            break;
        }
        else if (option == 1)
        {
            DisplayAll(sAccList);
        }
        else if (option == 2)
        {
            Console.WriteLine("Account Number: ");
            string accNo = Console.ReadLine();
            Deposit(sAccList, accNo);   
        }

}







static void DisplayMenu()
{
    Console.WriteLine("Menu");
    Console.WriteLine("[1] Display all accounts");
    Console.WriteLine("[2] Deposit");
    Console.WriteLine("[3] Withdraw");
    Console.WriteLine("[0] Exit");
    Console.Write("Enter option: ");
}

static void DisplayAll(List<SavingsAccount> sAccList)
{
    foreach (SavingsAccount account in sAccList)
    {
        Console.WriteLine(account);
    }
}
void Deposit(List<SavingsAccount> sAccList, string accNo)
{
    SavingsAccount? depAcc = Search(sAccList, accNo);

    if (depAcc != null)
    {
        Console.Write("Amount to Deposit: ");
        double depAmount = Convert.ToDouble(Console.ReadLine());
        depAcc.Deposit(depAmount);
        Console.WriteLine($"New balance: ${depAcc.Balance}");
      
    }
    else
    {
        Console.WriteLine("Account not found");
    }
}
static SavingsAccount? Search(List<SavingsAccount> sAccList, string accNo)
{
    
    foreach(SavingsAccount account in sAccList)
    {
        if (accNo == account.AccNo)
        {
            return account;
        }
    }
    return null;
}
