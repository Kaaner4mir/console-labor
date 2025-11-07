class List
{
    public static void ListingCar()
    {
        foreach (var item in Data.cars)
        {
            ConsoleManager.WriteColored($"🔑 Vehicle ID    : {item.VehicleId}", ConsoleColor.Yellow);
            ConsoleManager.WriteColored($"🏷️ Vehicle Brand : {item.Brand}", ConsoleColor.White);
            ConsoleManager.WriteColored($"🗂️ Vehicle Model : {item.Model}", ConsoleColor.DarkYellow);
            ConsoleManager.WriteColored($"📅 Year          : {item.Year}", ConsoleColor.Blue);
            ConsoleManager.WriteColored($"🎨 Color         : {item.Color}", ConsoleColor.Magenta);
            ConsoleManager.WriteColored($"🔋 HP            : {item.HP}", ConsoleColor.Green);

            ConsoleManager.WriteColored(new string('-', 40));
        }
    }

    public static void ListingBus()
    {
        foreach (var item in Data.buses)
        {
            ConsoleManager.WriteColored($"🔑 Vehicle ID    : {item.VehicleId}", ConsoleColor.Yellow);
            ConsoleManager.WriteColored($"🏷️ Vehicle Brand : {item.Brand}", ConsoleColor.White);
            ConsoleManager.WriteColored($"🗂️ Vehicle Model : {item.Model}", ConsoleColor.DarkYellow);
            ConsoleManager.WriteColored($"📅 Year          : {item.Year}", ConsoleColor.Blue);
            ConsoleManager.WriteColored($"🎨 Color         : {item.Color}", ConsoleColor.Magenta);
            ConsoleManager.WriteColored($"🔢 Capacity      : {item.Capacity}", ConsoleColor.Green);

            ConsoleManager.WriteColored(new string('-', 40));
        }
    }

    public static void ListingCommercial()
    {
        foreach (var item in Data.commercials)
        {
            ConsoleManager.WriteColored($"🔑 Vehicle ID    : {item.VehicleId}", ConsoleColor.Yellow);
            ConsoleManager.WriteColored($"🏷️ Vehicle Brand : {item.Brand}", ConsoleColor.White);
            ConsoleManager.WriteColored($"🗂️ Vehicle Model : {item.Model}", ConsoleColor.DarkYellow);
            ConsoleManager.WriteColored($"📅 Year          : {item.Year}", ConsoleColor.Blue);
            ConsoleManager.WriteColored($"🎨 Color         : {item.Color}", ConsoleColor.Magenta);
            ConsoleManager.WriteColored($"🧩 Area          : {item.Area}", ConsoleColor.Green);

            ConsoleManager.WriteColored(new string('-', 40));
        }
    }

    public static void ListingMotocycle()
    {
        foreach (var item in Data.motocycles)
        {
            ConsoleManager.WriteColored($"🔑 Vehicle ID    : {item.VehicleId}", ConsoleColor.Yellow);
            ConsoleManager.WriteColored($"🏷️ Vehicle Brand : {item.Brand}", ConsoleColor.White);
            ConsoleManager.WriteColored($"🗂️ Vehicle Model : {item.Model}", ConsoleColor.DarkYellow);
            ConsoleManager.WriteColored($"📅 Year          : {item.Year}", ConsoleColor.Blue);
            ConsoleManager.WriteColored($"🎨 Color         : {item.Color}", ConsoleColor.Magenta);
            ConsoleManager.WriteColored($"🔋 CC            : {item.CC}", ConsoleColor.Green);

            ConsoleManager.WriteColored(new string('-', 40));
        }
    }
}