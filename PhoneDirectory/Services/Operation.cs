class Operation
{
    static List<Person> _people = new List<Person>
        {
            new Person { Id = Random.Shared.Next(1000,9999), FirstName = "John", LastName = "Smith", Number = "(555) 010-1234", Notes = "First contact, referred by marketing." },
            new Person { Id = Random.Shared.Next(1000,9999), FirstName = "Emily", LastName = "Johnson", Number = "(555) 011-5678", Notes = "Potential client." },
            new Person { Id = Random.Shared.Next(1000,9999), FirstName = "Michael", LastName = "Williams", Number = "(555) 012-9012", Notes = null },
            new Person { Id = Random.Shared.Next(1000,9999), FirstName = "Sophia", LastName = "Brown", Number = "(555) 013-3456", Notes = "Met at NY conference." },
            new Person { Id = Random.Shared.Next(1000,9999), FirstName = "James", LastName = "Jones", Number = "(555) 014-7890", Notes = "" },
            new Person { Id = Random.Shared.Next(1000,9999), FirstName = "Olivia", LastName = "Garcia", Number = "(555) 015-2345", Notes = "Spanish-speaking contact." },
            new Person { Id = Random.Shared.Next(1000,9999), FirstName = "Robert", LastName = "Miller", Number = "(555) 016-6789", Notes = "VIP Client." },
            new Person { Id = Random.Shared.Next(1000,9999), FirstName = "Mia", LastName = "Davis", Number = "(555) 017-1234", Notes = null },
            new Person { Id = Random.Shared.Next(1000,9999), FirstName = "David", LastName = "Rodriguez", Number = "(555) 018-5678", Notes = "Follow up required." },
            new Person { Id = Random.Shared.Next(1000,9999), FirstName = "Isabella", LastName = "Martinez", Number = "(555) 019-9012", Notes = "Internal supplier." },
            new Person { Id = Random.Shared.Next(1000,9999), FirstName = "William", LastName = "Hernandez", Number = "(555) 020-3456", Notes = "" },
            new Person { Id = Random.Shared.Next(1000,9999), FirstName = "Ava", LastName = "Lopez", Number = "(555) 021-7890", Notes = "Project manager." },
            new Person { Id = Random.Shared.Next(1000,9999), FirstName = "Richard", LastName = "Gonzalez", Number = "(555) 022-2345", Notes = null },
            new Person { Id = Random.Shared.Next(1000,9999), FirstName = "Charlotte", LastName = "Wilson", Number = "(555) 023-6789", Notes = "Legal department." },
            new Person { Id = Random.Shared.Next(1000,9999), FirstName = "Joseph", LastName = "Anderson", Number = "(555) 024-1234", Notes = "Needs quote for Q4." },
            new Person { Id = Random.Shared.Next(1000,9999), FirstName = "Amelia", LastName = "Thomas", Number = "(555) 025-5678", Notes = "" },
            new Person { Id = Random.Shared.Next(1000,9999), FirstName = "Charles", LastName = "Taylor", Number = "(555) 026-9012", Notes = "Invited to webinar." },
            new Person { Id = Random.Shared.Next(1000,9999), FirstName = "Harper", LastName = "Moore", Number = "(555) 027-3456", Notes = null },
            new Person { Id = Random.Shared.Next(1000,9999), FirstName = "Thomas", LastName = "Jackson", Number = "(555) 028-7890", Notes = "Technical support lead." },
            new Person { Id = Random.Shared.Next(1000,9999), FirstName = "Evelyn", LastName = "Martin", Number = "(555) 029-2345", Notes = "Pending contract." }
        };

    public static void List()
    {
        foreach (var item in _people)
        {
            ConsoleManager.WriteColored($"🔑 ID           : {item.Id}");
            ConsoleManager.WriteColored($"🏷️ Full Name    : {item.FirstName} {item.LastName}", ConsoleColor.Green);
            ConsoleManager.WriteColored($"☎️ Phone Number : {item.Number}", ConsoleColor.Red);
            ConsoleManager.WriteColored($"📝 Notes        : {item.Notes}", ConsoleColor.White);
            ConsoleManager.WriteColored(new string('-', 50));
        }
    }

    public static void Add()
    {
        Console.Clear();

        string firstName = ConsoleManager.GetInput<string>("🏷️ Enter the first name of the new contact: ");
        string lastName = ConsoleManager.GetInput<string>("🏷️ Enter the last name of the new contact: ");
        string number = ConsoleManager.GetInput<string>("☎️ Enter the phone number of the new contact: ");
        string notes = ConsoleManager.GetInput<string>("📝 Enter details about the new person: ");

        _people.Add(new Person
        {
            Id = Random.Shared.Next(1000, 9999),
            FirstName = firstName,
            LastName = lastName,
            Number = number,
            Notes = notes
        });
        ConsoleManager.WriteColored("\n✅ Person successfully added", ConsoleColor.Green);
    }

    public static void Update()
    {
        Console.Clear();

        List();

        short id = ConsoleManager.GetInput<short>("\n🆔 Enter the ID of the account you want to update: ");

        var account = _people.FirstOrDefault(x => x.Id == id);

        if (account == null)
        {
            ConsoleManager.WriteColored("\n❓ Account not found!");
            return;
        }

        Console.Clear();

        Menu.UpdateMenu();

        short act = ConsoleManager.GetInput<short>("\nℹ️ Select the item you want to update: ");
        string newItem = ConsoleManager.GetInput<string>("\n🆕 Enter the new item you want to update: ");

        switch (act)
        {
            case 1: account.FirstName = newItem; break;   
            case 2: account.LastName = newItem; break;   
            case 3: account.Number = newItem; break;   
            case 4: account.Notes = newItem; break;   
            default: ConsoleManager.WriteColored("\n⚠️ The operation you want to perform was not found!", ConsoleColor.Yellow); break;
        }
        ConsoleManager.WriteColored("\n✅ Person successfully updated", ConsoleColor.Green);
    }

    public static void Delete()
    {
        Console.Clear();

        List();

        short id = ConsoleManager.GetInput<short>("\n🆔 Enter the ID of the account you want to delete: ");

        var account = _people.FirstOrDefault(x => x.Id == id);

        if (account == null)
        {
            ConsoleManager.WriteColored("\n❓ Account not found!");
            return;
        }

        _people.Remove(account);
        ConsoleManager.WriteColored("\n✅ Person successfully deleted", ConsoleColor.Green);
    }
}