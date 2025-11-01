class Data
{
    public static List<Account> _accounts = new List<Account>
        {
            new Account
            {
                AccountId = Random.Shared.Next(10000,99999),
                AccountName = "Salary Account",
                Branch = "Dublin",
                Currency = "€",
                Balance = 12500.75m,
                OpeningDate = new DateTime(2023, 5, 10)
            },
            new Account
            {
                AccountId = Random.Shared.Next(10000,99999),
                AccountName = "Saving Account",
                Branch = "Cork",
                Currency = "€",
                Balance = 2500.00m,
                OpeningDate = new DateTime(2024, 1, 20)
            }
        };
    public static List<Log> _logs = new List<Log>();
}


