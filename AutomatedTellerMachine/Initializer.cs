using System.Text;

class Initializer
{
    public static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        try
        {
            Login.Control();

            while (true)
            {
                Console.Clear();
                Menu.MainMenu();

                byte act = ConsoleManager.GetInput<byte>("\n👉 Please enter the operation you wish to perform numerically: ");

                switch (act)
                {

                }
            }
        }
        catch (Exception ex)
        {

        }
    }
}