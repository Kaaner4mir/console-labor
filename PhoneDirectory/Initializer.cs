using System.Text;

class Initializer
{
    public static void Main()
    {
        Console.Title = "📞 Phone Directory";
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        try
        {
            while (true)
            {
                Menu.MainMenu();
                short act = ConsoleManager.GetInput<short>("\n👉 Please enter the action you want to perform: ");
                Console.Clear();
                switch (act)
                {
                    case 1: Operation.List(); break;
                    case 2: Operation.Add(); break;
                    case 3: Operation.Update(); break;
                    case 4: Operation.Delete(); break;
                    case 5: Operation.Search(); break;
                    case 6: Environment.Exit(0); break;
                    default: ConsoleManager.WriteColored("\n⚠️ The operation you want to perform was not found!", ConsoleColor.Yellow); break;
                }
                ConsoleManager.WaitingScreen();
            }
        }
        catch (Exception ex)
        {
            ConsoleManager.WriteColored($"\nAn occured error: {ex.Message}!", ConsoleColor.Red);
        }
    }
}