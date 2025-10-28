class Menu
{
    public static void MainMenu()
    {
        var mainMenuItems = new (string text, ConsoleColor Color)[]
       {
            ( " << 🔲 Main Menu >>\n", ConsoleColor.Cyan),

            ( "📏 1. Perimeter Calculation", ConsoleColor.White),
            ( "📐 2. Area Calculation", ConsoleColor.Red),
            ( "🧊 3. Volume Calculation", ConsoleColor.Blue),
            ( "🔚 4. Exit", ConsoleColor.Magenta),
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

    public static void AreaMenu()
    {
        var mainMenuItems = new (string text, ConsoleColor Color)[]
       {
            ( " << 📐 Area Calculation >>\n", ConsoleColor.Cyan),

            ( " 1. Cube Calculation", ConsoleColor.White),
            ( " 2. Rectangular Prism Calculation", ConsoleColor.DarkYellow),
            ( " 3. Cylinder Calculation", ConsoleColor.Red),
            ( " 4. Sphere Calculation", ConsoleColor.Green),
            ( " 5. Cone Calculation", ConsoleColor.Blue),
            ( " 6. Pyramid Calculation", ConsoleColor.Magenta),
       };

        foreach (var item in mainMenuItems)
        {
            ConsoleManager.WriteColored(item.text, item.Color);
        }
    }

        public static void VolumeMenu()
        {
            var volumeMenuItems = new (string text, ConsoleColor Color)[]
            {
            ( " << 🧊 Volume Calculation >>\n", ConsoleColor.Cyan),

            ( " 1. Cube", ConsoleColor.White),
            ( " 2. Rectangular Prism", ConsoleColor.DarkYellow),
            ( " 3. Cylinder", ConsoleColor.Green),
            ( " 4. Sphere", ConsoleColor.Red),
            ( " 5. Cone", ConsoleColor.Blue),
            ( " 6. Square Pyramid", ConsoleColor.Magenta),
            };

            foreach (var item in volumeMenuItems)
            {
                ConsoleManager.WriteColored(item.text, item.Color);
            }
        }
}