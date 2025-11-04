using System.Text;

class Initializer
{
    public static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        Console.Title = "\U0001f6de Renting Car System";

        try
        {
            while (true)
            {
                Console.Clear();
                Menu.MainMenu();

                byte act = ConsoleManager.GetInput<byte>("\n👉 Please enter the action you want to perform numerically: ");

                switch (act)
                {
                    default: ConsoleManager.WriteColored("\n⚠️ The operation you want to perform was not found!"); break;
                }
                ConsoleManager.WaitingScreen();
            }
        }
        catch (Exception ex)
        {
            ConsoleManager.WriteColored($"\n⚠️ An unknown error occured: {ex.Message}", ConsoleColor.Red);
        }
    }
}