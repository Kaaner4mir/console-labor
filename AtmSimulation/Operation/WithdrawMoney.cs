class WithdrawMoney
{
    public static void Withdraw()
    {
        Console.Clear();
        ShowBalance.ListAccount();

        int id = ConsoleManager.GetInput<int>("👉 Enter the ID of the account from which you want to withdraw money: ");
        var account = Data._accounts.FirstOrDefault(x => x.AccountId == id);

        if (account == null)
        {
            ConsoleManager.WriteColored("\n❓ Account not found", ConsoleColor.Yellow);
            return;
        }

        decimal withdrawAmount = ConsoleManager.GetInput<decimal>("\n👉 Please enter the amount you wish to withdraw: ");

        if (withdrawAmount < 10)
        {
            ConsoleManager.WriteColored("\n❗ You can withdraw at least €10 of the amount you want to withdraw!", ConsoleColor.Yellow);
            return;
        }

        if (withdrawAmount > account.Balance)
        {
            ConsoleManager.WriteColored("\n❗ Insufficient balance!", ConsoleColor.Yellow);
            return;
        }

        account.Balance -= withdrawAmount;

        string type = "Withdrawal";
        decimal amount = withdrawAmount;

        ConsoleManager.WriteColored($"\n💰 The withdrawal was successful. New Balance: {account.Currency}{account.Balance}", ConsoleColor.Green);

        Logger.AddLog(type,amount);
    }
}