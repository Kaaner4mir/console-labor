class Menu
{
    public static void MainMenu()
    {
        var mainMenuItems = new (string text, ConsoleColor Color)[]
       {
            ( " << 🏦 Main Menu >>\n", ConsoleColor.Gray),

            ( "💰 1. Balance Inquiry Money", ConsoleColor.Yellow),
            ( "💶 2. Withdraw Money", ConsoleColor.Blue),
            ( "🫳 3. Deposit Money", ConsoleColor.DarkYellow),
            ( "💸 4. Money Transfer", ConsoleColor.Green),
            ( "📃 5. Bill Payment", ConsoleColor.White),
            ( "🔚 6. Exit", ConsoleColor.Magenta),
       };

        foreach (var item in mainMenuItems)
        {
            ConsoleManager.WriteColored(item.text, item.Color);
        }
    }
}