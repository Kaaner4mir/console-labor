class Menu
{
    public static void MainMenu()
    {
        var mainMenuItems = new (MainMenuOption Option, string Text, ConsoleColor Color)[]
        {
            (0, " ----- 🧮 Elementary Mathematics -----\n", ConsoleColor.Cyan),
            (MainMenuOption.Addition, " 1. Addition", ConsoleColor.Yellow),
            (MainMenuOption.Subtraction, " 2. Subtraction", ConsoleColor.DarkYellow),
            (MainMenuOption.Multiplication, " 3. Multiplication", ConsoleColor.Red),
            (MainMenuOption.Division, " 4. Division\n", ConsoleColor.DarkRed),

            (0, " ----- 🔢 Advanced Mathematics -----\n", ConsoleColor.Cyan),
            (MainMenuOption.Exponentiation, " 5. Exponentiation", ConsoleColor.Green),
            (MainMenuOption.Root, " 6. Root", ConsoleColor.DarkGreen),
            (MainMenuOption.Factorial, " 7. Factorial", ConsoleColor.Blue),
            (MainMenuOption.Modulo, " 8. Modulo", ConsoleColor.DarkBlue),
            (MainMenuOption.Logarithm, " 9. Logarithm", ConsoleColor.Magenta),
            (MainMenuOption.Trigonometry, "10. Trigonometry\n", ConsoleColor.DarkMagenta),

            (0, " ----- 💾 Memory Operations -----\n", ConsoleColor.Cyan),
            (MainMenuOption.MemoryOperations, "11. Memory Operations", ConsoleColor.Gray),
            (MainMenuOption.Exit, "12. Exit", ConsoleColor.White)
        };
        DisplayMenu(mainMenuItems);
    }

    public static void TrigonometryMenu()
    {
        var trigonometryMenuItems = new (TrigonometryOption Option, string Text, ConsoleColor Color)[]
       {
            (0, " ----- 📐 Trigonometry -----\n", ConsoleColor.Cyan),
            (TrigonometryOption.Sine, " 1. Sine", ConsoleColor.Yellow),
            (TrigonometryOption.Cosine, " 2. Cosine", ConsoleColor.Red),
            (TrigonometryOption.Tangent, " 3. Tangent", ConsoleColor.Cyan),
            (TrigonometryOption.Cotangent, " 4. Cotangent", ConsoleColor.Blue),
            (TrigonometryOption.Secant, " 5. Secant", ConsoleColor.Magenta),
            (TrigonometryOption.Cosecant, " 6. Cosecant", ConsoleColor.White),
       };
        DisplayMenu(trigonometryMenuItems);
    }

    public static void MemoryMenu()
    {
        var memoryMenuItems = new (MemoryOption Option, string Text, ConsoleColor Color)[]
      {
            (0, " ----- 💾 Memory Operations -----\n", ConsoleColor.Cyan),
            (MemoryOption.MemoryAdd, " 1. Memory Add", ConsoleColor.White),
            (MemoryOption.MemorySubtract, " 2. Memory Subtract", ConsoleColor.Magenta),
            (MemoryOption.MemoryRecall, " 3. Memory Recall", ConsoleColor.Red),
            (MemoryOption.MemoryClear, " 4. Memory Clear", ConsoleColor.Blue),
      };
        DisplayMenu(memoryMenuItems);
    }

    private static void DisplayMenu<T>(params (T Option, string Text, ConsoleColor Color)[] menuItems)
    {
        foreach (var item in menuItems)
        {
            ConsoleManager.WriteColored(item.Text, item.Color);
        }
    }
}