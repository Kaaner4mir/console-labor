class Animation
{
    public static void SpinnerAnimation()
    {
        try
        {
            Console.CursorVisible = false;
            Console.Clear();
            const short Loop_Duration = 50;

            char[] items = { '-', '\\', '|', '/', '-', '\\', '|', '/' };

            for (int i = 0; i < 4; i++)
            {
                foreach (var item in items)
                {
                    Console.Write($"\r{item}");
                    Thread.Sleep(Loop_Duration);
                }
            }
        }
        catch (Exception ex)
        {
            ConsoleManager.WriteColored($"\nAn error occured: {ex.Message}", ConsoleColor.Red);
        }
        finally
        {
            Console.CursorVisible = true;
            Console.Clear();
        }

    }
}