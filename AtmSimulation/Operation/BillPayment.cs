class BillPayment
{
    public static void Payment()
    {
        Console.Clear();
        Menu.BillPaymentMenu();

        byte act = ConsoleManager.GetInput<byte>("\n👉 Enter the operation you want to perform numerically: ");

        Console.Clear();
        ShowBalance.ListAccount();

        int id = ConsoleManager.GetInput<int>("\n👉 Enter the ID of the account you want to pay for the invoice: ");

        var account = Data._accounts.FirstOrDefault(x => x.AccountId == id);

        if (account == null)
        {
            ConsoleManager.WriteColored("\n❓ Account not found", ConsoleColor.Yellow);
            return;
        }

        switch (act)
        {
            case 1:
                {
                    if (account.Balance < 78)
                    {
                        ConsoleManager.WriteColored("\n❗ Insufficient balance!", ConsoleColor.Yellow);
                        return;
                    }
                    account.Balance -= 78;
                }break;
            case 2:
                {
                    if (account.Balance < 49)
                    {
                        ConsoleManager.WriteColored("\n❗ Insufficient balance!", ConsoleColor.Yellow);
                        return;
                    }
                    account.Balance -= 49;
                }
                break;
            case 3:
                {
                    if (account.Balance < 90)
                    {
                        ConsoleManager.WriteColored("\n❗ Insufficient balance!", ConsoleColor.Yellow);
                        return;
                    }
                    account.Balance -= 90;
                }
                break;
            case 4:
                {
                    if (account.Balance < 61)
                    {
                        ConsoleManager.WriteColored("\n❗ Insufficient balance!", ConsoleColor.Yellow);
                        return;
                    }
                    account.Balance -= 61;
                }
                break;
            case 5:
                {
                    if (account.Balance < 120)
                    {
                        ConsoleManager.WriteColored("\n❗ Insufficient balance!", ConsoleColor.Yellow);
                        return;
                    }
                    account.Balance -= 120;
                }
                break;
        }

        string type = "Bill";

        ConsoleManager.WriteColored($"\n💰 The payment was successful. New Balance: {account.Currency}{account.Balance}", ConsoleColor.Green);

        Logger.AddLog(type,decimal.Zero);
    }
}