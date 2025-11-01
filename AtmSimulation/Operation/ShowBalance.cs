class ShowBalance
{
    public static void ListAccount()
    {
        foreach (var item in Data._accounts)
        {
            ConsoleManager.WriteColored($"🔑 Account ID   : {item.AccountId}", ConsoleColor.Yellow);
            ConsoleManager.WriteColored($"🏷️ Account Name : {item.AccountName}", ConsoleColor.White);
            ConsoleManager.WriteColored($"🏦 Branch       : {item.Branch}", ConsoleColor.Blue);
            ConsoleManager.WriteColored($"🗓️ Opening Date : {item.OpeningDate}", ConsoleColor.Cyan);
            ConsoleManager.WriteColored($"💱 Currency     : {item.Currency}", ConsoleColor.Gray);
            ConsoleManager.WriteColored($"🪙 Balance      : {item.Currency}{item.Balance}", ConsoleColor.Green);

            ConsoleManager.WriteColored(new string('-', 40));
        }
    }

    public static void ListForeignAccount()
    {
        foreach (var item in Data._foreignaccounts)
        {
            ConsoleManager.WriteColored($"🔑 Account ID   : {item.AccountId}", ConsoleColor.Yellow);
            ConsoleManager.WriteColored($"🏦 Branch       : {item.Branch}", ConsoleColor.Blue);
            ConsoleManager.WriteColored($"💱 Currency     : {item.Currency}", ConsoleColor.Gray);

            ConsoleManager.WriteColored(new string('-', 40));
        }
    }
}