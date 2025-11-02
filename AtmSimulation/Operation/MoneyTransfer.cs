class MoneyTransfer
{
    public static void Transfer()
    {
        Console.Clear();
        ShowBalance.ListForeignAccount();

        int recieverId = ConsoleManager.GetInput<int>("\n👉 Enter the ID of the receiving account: ");
        var reieverAccount = Data._foreignaccounts.FirstOrDefault(x => x.AccountId == recieverId);

        if (reieverAccount == null)
        {
            ConsoleManager.WriteColored("\n❓ Account not found", ConsoleColor.Yellow);
            return;
        }

        Console.Clear();
        ShowBalance.ListAccount();

        int senderId = ConsoleManager.GetInput<int>("\n👉 Enter the ID of the sender account: ");
        var senderAccount = Data._accounts.FirstOrDefault(x => x.AccountId == senderId);

        if (senderAccount == null)
        {
            ConsoleManager.WriteColored("\n❓ Account not found", ConsoleColor.Yellow);
            return;
        }

        decimal transferAmount = ConsoleManager.GetInput<decimal>("👉 Please enter the amount you want to transfer: ");

        if (transferAmount < 10)
        {
            ConsoleManager.WriteColored("\n❗ You can transfer at least €10 of the amount you want to transfer!", ConsoleColor.Yellow);
            return;
        }

        if (transferAmount > senderAccount.Balance)
        {
            ConsoleManager.WriteColored("\n❗ Insufficient balance!", ConsoleColor.Yellow);
            return;
        }

        string type = "Transfer";

        senderAccount.Balance -= transferAmount;
        ConsoleManager.WriteColored($"\n💰 The transfer was successful. New Balance: {senderAccount.Currency}{senderAccount.Balance}", ConsoleColor.Green);

        Logger.AddLog(type,transferAmount);
    }
}