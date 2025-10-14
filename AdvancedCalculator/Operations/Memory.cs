class Memory
{
    private static double _memoryValue = 0;

    public static void MemoryOperations()
    {
        Console.Clear();

        Menu.MemoryMenu();

        MemoryOption input = ConsoleManager.GetInput<MemoryOption>("\n👉 Please enter the operation you wish to perform numerically: ");

        switch (input)
        {
            case MemoryOption.MemoryAdd:
                {
                    double inputMemory = ConsoleManager.GetInput<double>("\n👉 Enter the number you want to add to memory: ");
                    _memoryValue += inputMemory;
                    ShowMemoryValue();
                }
                break;
            case MemoryOption.MemorySubtract:
                {
                    double inputMemory = ConsoleManager.GetInput<double>("\n👉 Enter the number you want to substract from memory: ");
                    _memoryValue -= inputMemory; // Corrected logic
                    ShowMemoryValue();
                }
                break;
            case MemoryOption.MemoryRecall:
                ShowMemoryValue(); // Corrected logic, just show memory
                break;
            case MemoryOption.MemoryClear:
                _memoryValue = 0; // Corrected logic, clear memory
                ShowMemoryValue();
                break;
            default:
                ConsoleManager.WriteColored(
                "\n❓ The operation you want to perform could not be found.", ConsoleColor.Yellow); break;
        }
    }

    private static void ShowMemoryValue()
    {
        ConsoleManager.WriteColored($"\n💾 Memory: {_memoryValue}", ConsoleColor.Green);
    }
}