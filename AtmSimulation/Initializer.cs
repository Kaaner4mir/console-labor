using System.Text;

class Initializer
{
    public static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        Console.Title = "🏧 Automated Teller Machine";

        try
        {
            while (true)
            {
                Console.Clear();
                Menu.MainMenu();
                byte act = ConsoleManager.GetInput<byte>("\n👉 Enter the operation you want to perform numerically: ");
                Console.Clear();

                switch (act)
                {
                    case 1: ShowBalance.Show(); break;
                    case 2: WithdrawMoney.Withdraw(); break;
                    case 3: DepositMoney.Deposit(); break;
                    case 6: ShowLog.Show(); break;
                    default: ConsoleManager.WriteColored("\n❌ The transaction you want to make is invalid! Please try again."); break;
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