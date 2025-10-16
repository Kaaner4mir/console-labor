using System.Text;

class Initializer
{
    public static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        try
        {
            int cardPassword = Login.Control();

            if (cardPassword == -1)
            {
                Environment.Exit(0);
            }

            while (true)
            {
                Animation.SpinnerAnimation();
                Menu.MainMenu();

                byte act = ConsoleManager.GetInput<byte>("\n👉 Please enter the operation you wish to perform numerically (1-8) : ");

                Animation.SpinnerAnimation();

                switch (act)
                {
                    case 1: DisplayAccountDetails.Display(cardPassword); break;
                    default: ConsoleManager.WriteColored("\n❌ The operation you want to perform is not available.", ConsoleColor.Yellow); break;
                }
                ConsoleManager.WaitingScreen();
            }
        }
        catch (Exception ex)
        {
            ConsoleManager.WriteColored($"\n⚠️ An error occured:{ex.Message}", ConsoleColor.Red);
        }
    }
}