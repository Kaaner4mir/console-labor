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
            ( "🔔 6. Account Activity", ConsoleColor.Yellow),
            ( "🔚 7. Exit", ConsoleColor.Magenta),
       };

        foreach (var item in mainMenuItems)
        {
            ConsoleManager.WriteColored(item.text, item.Color);
        }
    }

    public static void BillPaymentMenu()
    {
        var mainMenuItems = new (string text, ConsoleColor Color)[]
       {
            ( " <<  Main Menu >>\n", ConsoleColor.Gray),

            ( "⚡ 1. Electricity  €78", ConsoleColor.Yellow),
            ( "💧 2. Water        €49", ConsoleColor.Blue),
            ( "♨️ 3. Gas          €90", ConsoleColor.Green),
            ( "📱 4. Phone Mone   €61", ConsoleColor.White),
            ( "🛜 5. Internet     €120", ConsoleColor.Cyan),
       };

        foreach (var item in mainMenuItems)
        {
            ConsoleManager.WriteColored(item.text, item.Color);
        }
    }
}