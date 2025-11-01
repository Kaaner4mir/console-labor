class DepositMoney
{
    public static void Deposit()
    {
        Console.Clear();
        ShowBalance.ListAccount();

        int id = ConsoleManager.GetInput<int>("👉 Enter the ID of the account from which you want to deposit money: ");
        var account = Data._accounts.FirstOrDefault(x => x.AccountId == id);

        if (account == null)
        {
            ConsoleManager.WriteColored("\n❓ Account not found", ConsoleColor.Yellow);
            return;
        }

        decimal depositAmount = ConsoleManager.GetInput<decimal>("\n👉 Please enter the amount you wish to withdraw: ");

        if (depositAmount < 10)
        {
            ConsoleManager.WriteColored("\n❗ You can deposit at least €10 of the amount you want to deposit!", ConsoleColor.Yellow);
            return;
        }

        account.Balance += depositAmount;

        string type = "Deposit";
        decimal amount = depositAmount;

        ConsoleManager.WriteColored($"\n💰 The deposit was successful. New Balance: {account.Currency}{account.Balance}", ConsoleColor.Green);

        Logger.AddLog(type, amount);
    }
}