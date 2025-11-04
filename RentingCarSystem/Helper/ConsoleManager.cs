class ConsoleManager
{
    public static T GetInput<T>(string message, ConsoleColor color = ConsoleColor.White)
    {
        while (true)
        {
            WriteColored(message, color, false);
            string? text = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(text))
            {
                WriteColored("\n⚠️ Input cannot be empty!", ConsoleColor.Red);
                continue;
            }

            try
            {
                if (typeof(T).IsEnum)
                {
                    if (Enum.TryParse(typeof(T), text, out object? result))
                    {
                        return (T)result;
                    }
                    else
                    {
                        WriteColored($"\n⚠️ Please enter a valid {typeof(T).Name} value!", ConsoleColor.Red);
                        continue;
                    }
                }
                else
                {
                    return (T)Convert.ChangeType(text, typeof(T));
                }
            }
            catch (FormatException)
            {
                WriteColored($"\n⚠️ Please enter a valid {typeof(T).Name} value!", ConsoleColor.Red);
            }
            catch (OverflowException)
            {
                WriteColored($"\n⚠️ The entered value is too large or too small for {typeof(T).Name}!", ConsoleColor.Red);
            }
            catch (Exception exc)
            {
                WriteColored($"\n⚠️ An unexpected error occurred: {exc.Message}", ConsoleColor.Red);
            }
        }
    }

    public static void WriteColored(string text, ConsoleColor color = ConsoleColor.White, bool newLine = true)
    {
        Console.ForegroundColor = color;
        if (newLine) Console.WriteLine(text);
        else Console.Write(text);
        Console.ResetColor();
    }

    public static void WaitingScreen(ConsoleColor color = ConsoleColor.White)
    {
        Console.CursorVisible = false;
        WriteColored("\n⏳ Press any key to continue ...", color);
        Console.ReadKey(intercept: true);
        Console.CursorVisible = true;
    }
}