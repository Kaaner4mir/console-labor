class Menu
{
    public static void MainMenu()
    {
        Console.Clear();

        var mainMenuItems = new (string text, ConsoleColor Color)[]
        {
            ( " ----- ☎️ Main Menu -----\n", ConsoleColor.Cyan),

            ( " 1. Listing Persons", ConsoleColor.White),
            ( " 2. Add Person", ConsoleColor.Yellow),
            ( " 3. Update Person", ConsoleColor.Red),
            ( " 4. Delete Person", ConsoleColor.Green),
            ( " 5. Search Person", ConsoleColor.Magenta),
            ( " 6. Exit", ConsoleColor.Blue),
        };

        foreach (var item in mainMenuItems)
        {
            ConsoleManager.WriteColored(item.text, item.Color);
        }
    }

    public static void UpdateMenu()
    {
        Console.Clear();

        var mainMenuItems = new (string text, ConsoleColor Color)[]
        {
            ( " 1. Update first Name", ConsoleColor.White),
            ( " 2. Update last Name", ConsoleColor.Yellow),
            ( " 3. Update Phone Number", ConsoleColor.Red),
            ( " 4. Update Notes", ConsoleColor.Green),
        };

        foreach (var item in mainMenuItems)
        {
            ConsoleManager.WriteColored(item.text, item.Color);
        }
    }

}