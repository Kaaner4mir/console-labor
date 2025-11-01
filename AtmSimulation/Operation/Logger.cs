class Logger
{
    public static void AddLog(string type,decimal amount)
    {
        Data._logs.Add(new Log
        {
            LogId=Random.Shared.Next(10000000,99999999),
            Time=DateTime.Now,
            Type=type,
            TransactionAmount=amount
        });
    }
}