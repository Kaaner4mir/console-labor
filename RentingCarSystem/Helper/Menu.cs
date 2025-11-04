class Menu
{
    public static void MainMenu()
    {
        var mainMenuItems = new (string text, ConsoleColor Color)[]
       {
            ( " << 🛞 Renting Car System >>\n", ConsoleColor.White),

            ( "➕ 1. Rent Vehicle", ConsoleColor.DarkYellow),
            ( "💸 2. Pay Wage", ConsoleColor.Green),
            ( "📝 3. Wage List", ConsoleColor.White),
            ( "📋 4. List Vehicles", ConsoleColor.Cyan),
            ( "🔙 5. Exit", ConsoleColor.Gray),
       };

        foreach (var item in mainMenuItems)
        {
            ConsoleManager.WriteColored(item.text, item.Color);
        }
    }
}