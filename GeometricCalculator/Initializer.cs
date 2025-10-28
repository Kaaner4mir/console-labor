using System.Text;

class Initializer
{
    public static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        Console.Title = "📏 Geometric Calculator";

        try
        {
            while (true)
            {
                Console.Clear();
                Menu.MainMenu();

                byte act = ConsoleManager.GetInput<byte>("\n👉 Select the operation you want to perform numerically: ");

                switch (act)
                {
                    case 1: Perimeter.Calc(); break;
                    default: ConsoleManager.WriteColored("\n❌ You have made an invalid transaction! Please try again."); break;
                }
                ConsoleManager.WaitingScreen();
            }
        }
        catch (Exception ex)
        {
            ConsoleManager.WriteColored($"\n⚠️ An error occured: {ex.Message}", ConsoleColor.Red);
        }
    }
}