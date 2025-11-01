class ShowLog
{
    public static void Show()
    {
        Console.Clear();

        foreach (var item in Data._logs)
        {
            ConsoleManager.WriteColored($"🔑 Log Id : {item.LogId}", ConsoleColor.Yellow);
            ConsoleManager.WriteColored($"🗓️ Time   : {item.Time}", ConsoleColor.Blue);
            ConsoleManager.WriteColored($"🏷️ Type   : {item.Type}", ConsoleColor.White);
            ConsoleManager.WriteColored($"💰 Amount : {item.TransactionAmount}", ConsoleColor.Green);

            ConsoleManager.WriteColored(new string('-', 40));

        }
    }
}