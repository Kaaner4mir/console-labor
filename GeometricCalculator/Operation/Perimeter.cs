class Perimeter
{
    public static void Calc()
    {
        Console.Clear();
        Menu.PerimeterMenu();

        try
        {
            byte act = ConsoleManager.GetInput<byte>("\n👉 Select the operation you want to perform numerically: ");

            switch (act)
            {
                case 1: SquareCalc(); break;
                case 2: RectangleCalc(); break;
                case 3: TriangleCalc(); break;
                case 4: CircleCalc(); break;
                case 5: ParallelogramCalc(); break;
                case 6: RegularPolygonCalc(); break;
                default: ConsoleManager.WriteColored("\n❌ You have made an invalid transaction! Please try again."); break;
            }
        }
        catch (Exception ex)
        {
            ConsoleManager.WriteColored($"\n⚠️ An error occured: {ex.Message}", ConsoleColor.Red);
        }
    }

    public static void SquareCalc()
    {
        double sideLenght = ConsoleManager.GetInput<double>("\n👉 Enter the side length of the square: ");

        double perimeterSquare = 4 * sideLenght;

        ConsoleManager.WriteColored($"\n✅ The area of the square is {perimeterSquare}", ConsoleColor.Green);
    }

    public static void RectangleCalc()
    {
        double longSide = ConsoleManager.GetInput<double>("\n👉 Enter the length of the long side of the rectangle: ");
        double shortSide = ConsoleManager.GetInput<double>("\n👉 Enter the length of the short side of the rectangle: ");

        double perimeterRectangle = 2 * longSide + 2 * shortSide;

        ConsoleManager.WriteColored($"\n✅ The area of the rectangle is {perimeterRectangle}", ConsoleColor.Green);
    }

    public static void TriangleCalc()
    {
        double firstSide = ConsoleManager.GetInput<double>("\n👉 Enter the length of the first side of the triangle: ");
        double secondSide = ConsoleManager.GetInput<double>("\n👉 Enter the length of the second side of the triangle: ");
        double thirthSide = ConsoleManager.GetInput<double>("\n👉 Enter the length of the thirth side of the triangle: ");

        double perimeterTriangle = firstSide + secondSide + thirthSide;

        ConsoleManager.WriteColored($"\n✅ The area of the triangle is {perimeterTriangle}", ConsoleColor.Green);
    }

    public static void CircleCalc()
    {
        double radius = ConsoleManager.GetInput<double>("\n👉 Enter the length of the radius of the circle: ");

        double perimeterCircle = 2 * Math.PI * radius;

        ConsoleManager.WriteColored($"\n✅ The area of the circle is {perimeterCircle}", ConsoleColor.Green);
    }

    public static void ParallelogramCalc()
    {
        double shortSide = ConsoleManager.GetInput<double>("\n👉 Enter the length of the short side of the parallelogram: ");
        double longSide = ConsoleManager.GetInput<double>("\n👉 Enter the length of the long side of the parallelogram: ");

        double perimeterParallelogram = 2 * (shortSide + longSide);

        ConsoleManager.WriteColored($"\n✅ The area of the rectangle is {perimeterParallelogram}", ConsoleColor.Green);
    }

    public static void RegularPolygonCalc()
    {
        double numberSide = ConsoleManager.GetInput<double>("\n👉 Enter the number of sides: ");
        double sideLenght = ConsoleManager.GetInput<double>("\n👉 Enter the length of one side: ");

        double perimeterRegularPolygon = numberSide * sideLenght;

        ConsoleManager.WriteColored($"\n✅ The area of the regular polygon is {perimeterRegularPolygon}", ConsoleColor.Green);
    }
}