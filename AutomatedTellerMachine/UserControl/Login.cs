using Newtonsoft.Json;

class Login
{
    public static void Control()
    {
        const byte Attempt = 4;

        for (int i = 0; i < Attempt; i++)
        {
            string jsonContent = File.ReadAllText("Database/database.json");
            dynamic? database = JsonConvert.DeserializeObject<dynamic>(jsonContent);

            if (database == null || database.Accounts == null || database.Customers == null)
            {
                ConsoleManager.WriteColored("\n⚠️ Database loading failed or is empty!", ConsoleColor.Red);
                return;
            }

            int cardPassword = ConsoleManager.GetInput<int>("\n👉 Please enter your 4-digit card PIN registered with our bank: ");

            bool loginSuccessful = false;
            int loggedInCustomerId = -1;

            foreach (var account in database.Accounts)
            {
                if (account.CardPassword == cardPassword)
                {
                    loginSuccessful = true;
                    loggedInCustomerId = (int)account.CustomerId;
                    break;
                }
            }

            if (loginSuccessful)
            {
                dynamic? loggedInCustomer = null;
                foreach (var customer in database.Customers)
                {
                    if (customer.CustomerId == loggedInCustomerId)
                    {
                        loggedInCustomer = customer;
                        break;
                    }
                }

                if (loggedInCustomer != null)
                {
                    ConsoleManager.WriteColored($"\n✅ Welcome, {loggedInCustomer.FirstName} {loggedInCustomer.LastName}! Login successful.", ConsoleColor.Green);
                    ConsoleManager.WaitingScreen();
                    return;
                }
            }
            else
            {
                ConsoleManager.WriteColored($"\n❌ Incorrect PIN. You have {Attempt - 1 - i} attempts left.", ConsoleColor.Red);
            }
        }

        ConsoleManager.WriteColored("\n🔒 Too many failed attempts. Your card has been blocked. Please contact our support.", ConsoleColor.Red);
        ConsoleManager.WaitingScreen();
        Environment.Exit(0);
    }
}