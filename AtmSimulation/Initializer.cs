using System.Text;

class Initializer
{
    public static void Main()
    {
        int registeredId = 1111;
        byte attemept = 0;

        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        Console.Title = "🏧 Automated Teller Machine";

        try
        {
            while (attemept <= 5)
            {
                int password = ConsoleManager.GetInput<int>("\n👤 Enter your 4-digit card password registered with your bank: ");

                if (password != registeredId)
                {
                    ConsoleManager.WriteColored($"❌ Wrong password! Please try again. Remaining: {5 - attemept}", ConsoleColor.Yellow);
                    attemept++;
                }
                else
                {
                    ConsoleManager.WriteColored($"\n👤 Welcome Dear Customer", ConsoleColor.Green);
                    ConsoleManager.WaitingScreen();
                    break;
                }
            }
            if (attemept == 6)
            {
                ConsoleManager.WriteColored("\n⚠️ Your card has been blocked for security reasons. Please contact customer service as soon as possible", ConsoleColor.Red);
                ConsoleManager.WaitingScreen();
                return;
            }

            ConsoleManager.SpinnerAnimation();

            while (true)
            {
                Console.Clear();
                Menu.MainMenu();
                byte act = ConsoleManager.GetInput<byte>("\n👉 Enter the operation you want to perform numerically: ");
                Console.Clear();

                switch (act)
                {
                    case 1: ShowBalance.ListAccount(); break;
                    case 2: WithdrawMoney.Withdraw(); break;
                    case 3: DepositMoney.Deposit(); break;
                    case 4: MoneyTransfer.Transfer(); break;
                    case 5: BillPayment.Payment(); break;
                    case 6: ShowLog.Show(); break;
                    case 7: ExitAction.Exit(); break;
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