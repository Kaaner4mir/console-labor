class ExitAction
{
    public static void Exit()
    {
        Console.Clear();
        string act = ConsoleManager.GetInput<string>("Are you sure you want to exit (Y/N): ",ConsoleColor.White);

        string action = act.ToLower();

        if (act == "y")
        {
            Environment.Exit(0);
        }
        else if (act == "n")
        {
            return;
        }

        ConsoleManager.WriteColored("\n❌ The transaction you want to make is invalid! Please try again.", ConsoleColor.Red);
    }
}