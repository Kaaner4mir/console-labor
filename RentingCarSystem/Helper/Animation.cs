class Animation
{
    public static void SpinnerAnimation()
    {
        char[] items = { '-', '\\', '|', '/' };

        byte loopTime = 50;
        byte loopCount = 0;

        Console.Clear();
        Console.CursorVisible = false;

        while (loopCount < 5)
        {
            foreach (var item in items)
            {
                Console.Write($"\r{item}");
                Thread.Sleep(loopTime);
            }
            loopCount++;
        }
        Console.CursorVisible = true;
        Console.Clear();
    }
}