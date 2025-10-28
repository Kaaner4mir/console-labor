class Menu
{
    public static void MainMenu()
    {
        var mainMenuItems = new (string text, ConsoleColor Color)[]
       {
            ( " << 🔲 Main Menu >>\n", ConsoleColor.Cyan),

            ( " 1. Perimeter Calculation", ConsoleColor.White),
            ( " 1. Perimeter Calculation", ConsoleColor.White),
            ( " 1. Perimeter Calculation", ConsoleColor.White),
            ( " 1. Perimeter Calculation", ConsoleColor.White),
       };

        foreach (var item in mainMenuItems)
        {
            ConsoleManager.WriteColored(item.text, item.Color);
        }
    }

    public static void PerimeterMenu()
    {
        var mainMenuItems = new (string text, ConsoleColor Color)[]
       {
            ( " << 📏 Perimeter Calculation >>\n", ConsoleColor.Cyan),

            ( " 1. Square Calculation", ConsoleColor.White),
            ( " 2. Rectangle Calculation", ConsoleColor.DarkYellow),
            ( " 3. Triangle Calculation", ConsoleColor.Red),
            ( " 4. Circle Calculation", ConsoleColor.Green),
            ( " 5. Parallelogram Calculation", ConsoleColor.Blue),
            ( " 6. Regular Polygon Calculation", ConsoleColor.Magenta),
       };

        foreach (var item in mainMenuItems)
        {
            ConsoleManager.WriteColored(item.text, item.Color);
        }
    }
}