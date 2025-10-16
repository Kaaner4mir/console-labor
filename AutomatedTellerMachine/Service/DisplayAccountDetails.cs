using Newtonsoft.Json;

class DisplayAccountDetails
{
    public static void Display(int cardPassword)
    {
        try
        {
            string json = File.ReadAllText("Database/database.json");
            dynamic data = JsonConvert.DeserializeObject<dynamic>(json);

            dynamic matchedAccount = null;

            foreach (var account in data.Accounts)
            {
                if ((int)account.CardPassword == cardPassword)
                {
                    matchedAccount = account;
                    break;
                }
            }

            Console.Clear();

            if (matchedAccount != null)
            {
                ConsoleManager.WriteColored($"🔑 Account ID    : {matchedAccount.AccountId}", ConsoleColor.Yellow);
                ConsoleManager.WriteColored($"🆔 Account Number: {matchedAccount.AccountNumber}", ConsoleColor.White);
                ConsoleManager.WriteColored($"🏷️ Account Name  : {matchedAccount.AccountName}", ConsoleColor.Cyan);
                ConsoleManager.WriteColored($"🪪 Customer ID   : {matchedAccount.CustomerId}", ConsoleColor.Blue);
                ConsoleManager.WriteColored($"💱 Currency      : {matchedAccount.Currency}", ConsoleColor.White);
                ConsoleManager.WriteColored($"💰 Balance       : {matchedAccount.Balance} {matchedAccount.Currency}", ConsoleColor.Green);
                ConsoleManager.WriteColored($"📅 Opening Date  : {matchedAccount.OpeningDate}", ConsoleColor.Red);
            }
            else
                ConsoleManager.WriteColored("❌ No account found with this PIN.");
        }
        catch (Exception ex)
        {
            ConsoleManager.WriteColored($"\n⚠️ An error occured:{ex.Message}", ConsoleColor.Red);
        }
    }
}
