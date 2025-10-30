using System.Text;
using System.Globalization;

class Initializer
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        try
        {
            Console.Write("👉 Please enter your date of birth (dd.MM.yyyy): ");
            string input = Console.ReadLine();

            DateTime birthDate = DateTime.ParseExact(input, "d.M.yyyy", CultureInfo.InvariantCulture);

            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now < birthDate.AddYears(age))
                age--;

            if (age < 18)
                Console.WriteLine("\n⚠️ You must be at least 18 years old to obtain a license.");
            else if (age > 65)
                Console.WriteLine("\n⚠️ You must be no older than 65 to obtain a license.");
            else
                Console.WriteLine("\n✅ You can obtain a license.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\n❌ Invalid input. Details: {ex.Message}");
        }

        Console.ReadLine();
    }
}
