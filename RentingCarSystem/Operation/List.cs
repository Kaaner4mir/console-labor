class List
{
    public static void ListingCar()
    {
        foreach (var item in Data.vehicles)
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
}