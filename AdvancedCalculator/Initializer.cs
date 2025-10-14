using System.Text;

class Initializer
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Title = "🧮 Advanced Calculator";

        try
        {
            while (true)
            {
                Console.Clear();

                Menu.MainMenu();

                MainMenuOption input = ConsoleManager.GetInput<MainMenuOption>("\n👉 Please enter the operation you wish to perform numerically: ");

                switch (input)
                {
                    case MainMenuOption.Addition: Elementary.BasicOperation(OperationType.Addition, (val1, val2) => val1 + val2); break;
                    case MainMenuOption.Subtraction: Elementary.BasicOperation(OperationType.Subtraction, (val1, val2) => val1 - val2); break;
                    case MainMenuOption.Multiplication: Elementary.BasicOperation(OperationType.Multiplication, (val1, val2) => val1 * val2); break;
                    case MainMenuOption.Division: Elementary.BasicOperation(OperationType.Division, (val1, val2) => val1 / val2); break;
                    case MainMenuOption.Exponentiation: Advanced.Exponentiation(OperationType.Exponentiation, (baseNum, exponent) => Math.Pow(baseNum, exponent)); break;
                    case MainMenuOption.Root: Advanced.Root(OperationType.Root, (radicand, rootDegree) => Math.Pow(radicand, 1.0 / rootDegree)); break;
                    case MainMenuOption.Factorial: Advanced.Factorial(OperationType.Factorial); break;
                    case MainMenuOption.Modulo: Advanced.Modulo(OperationType.Modulo, (dividend, divisor) => dividend % divisor); break;
                    case MainMenuOption.Logarithm: Advanced.Logarithm(OperationType.Logarithm, (baseNum, argument) => Math.Log(argument, baseNum)); break;
                    case MainMenuOption.Trigonometry: Advanced.Trigonometry(); break;
                    case MainMenuOption.MemoryOperations: Memory.MemoryOperations(); break;
                    case MainMenuOption.Exit: Environment.Exit(0); break;
                    default:
                        ConsoleManager.WriteColored(
                        "\n❓ The operation you want to perform could not be found.", ConsoleColor.Yellow); break;
                }
                ConsoleManager.WaitingScreen();
            }

        }
        catch (Exception exc)
        {
            ConsoleManager.WriteColored($"\n⚠️ An error occured: {exc.Message}");
        }
    }
}