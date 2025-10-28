class Area
{
    public static void Calc()
    {
        Console.Clear();
        Menu.AreaMenu();

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
        double sideLenght = ConsoleManager.GetInput<double>("\n👉 Enter the side length of the square in centimeters: ");

        double areaSquare = sideLenght * sideLenght;

        ConsoleManager.WriteColored($"\n✅ The area of the square is {areaSquare} cm²", ConsoleColor.Green);
    }

    public static void RectangleCalc()
    {
        double shortLenght = ConsoleManager.GetInput<double>("\n👉 Enter the short length of the rectangle in centimeters: ");
        double longLenght = ConsoleManager.GetInput<double>("👉 Enter the long length of the rectangle in centimeters: ");

        double areaRectangle = shortLenght * longLenght;

        ConsoleManager.WriteColored($"\n✅ The area of the rectangle is {areaRectangle} cm²", ConsoleColor.Green);
    }

    public static void TriangleCalc()
    {
        double baseLenght = ConsoleManager.GetInput<double>("\n👉 Enter the base length of the triangle in centimeters: ");
        double height = ConsoleManager.GetInput<double>("👉 Enter the height length of the triangle in centimeters: ");

        double areaTriangle = (baseLenght * height) / 2;

        ConsoleManager.WriteColored($"\n✅ The area of the triangle is {areaTriangle} cm²", ConsoleColor.Green);
    }

    public static void CircleCalc()
    {
        double radius = ConsoleManager.GetInput<double>("\n👉 Enter the radius of the circle in centimeters: ");

        double areaCircle = Math.PI * Math.Pow(radius, 2);

        ConsoleManager.WriteColored($"\n✅ The area of the circle is {areaCircle} cm²", ConsoleColor.Green);
    }

    public static void ParallelogramCalc()
    {
        double baseLenght = ConsoleManager.GetInput<double>("\n👉 Enter the base lenght of the parallelogram in centimeters: ");
        double height = ConsoleManager.GetInput<double>("\n👉 Enter the height of the parallelogram in centimeters: ");

        double areaParallelogram = baseLenght * height;

        ConsoleManager.WriteColored($"\n✅ The area of the parallelogram is {areaParallelogram} cm²", ConsoleColor.Green);
    }

    public static void RegularPolygonCalc()
    {
        double numberSide = ConsoleManager.GetInput<double>("\n👉 Enter the number side of the regular polygon in centimeters: ");
        double height = ConsoleManager.GetInput<double>("\n👉 Enter the height of the regular polygon in centimeters: ");
        double apothem = ConsoleManager.GetInput<double>("\n👉 Enter the height of the regular polygon in centimeters: ");

        double areaRegularPolygon = ((numberSide * height) * apothem) / 2;

        ConsoleManager.WriteColored($"\n✅ The area of the regular polygon is {areaRegularPolygon} cm²", ConsoleColor.Green);
    }
}