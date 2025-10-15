class Menu
{
    public static void MainMenu()
    {
        ConsoleManager.WriteColored($" < 🏧 Main Menu >\n", ConsoleColor.Cyan);

        ConsoleManager.WriteColored($"1. Display account details",ConsoleColor.White);
        ConsoleManager.WriteColored($"2. Cash withdrawal",ConsoleColor.Yellow);
        ConsoleManager.WriteColored($"3. Cash deposit",ConsoleColor.DarkYellow);
        ConsoleManager.WriteColored($"4. Cash deposit",ConsoleColor.Green);
        ConsoleManager.WriteColored($"5. Transfer funds",ConsoleColor.Red);
        ConsoleManager.WriteColored($"6. Bill payment",ConsoleColor.DarkRed);
        ConsoleManager.WriteColored($"7. Change Password",ConsoleColor.DarkBlue);
        ConsoleManager.WriteColored($"8. Account statement",ConsoleColor.Magenta);
    }
}
