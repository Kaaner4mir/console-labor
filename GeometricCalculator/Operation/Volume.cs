using System;

public class Volume
{
    public static void Calc()
    {
        Console.Clear();
        Menu.VolumeMenu(); 

        try
        {
            byte act = ConsoleManager.GetInput<byte>("\n👉 Select the operation you want to perform numerically: ");

            switch (act)
            {
                case 1: CubeCalc(); break;
                case 2: RectangularPrismCalc(); break;
                case 3: CylinderCalc(); break;
                case 4: SphereCalc(); break;
                case 5: ConeCalc(); break;
                case 6: SquarePyramidCalc(); break;
                default: ConsoleManager.WriteColored("\n❌ You have made an invalid transaction! Please try again."); break;
            }
        }
        catch (Exception ex)
        {
            ConsoleManager.WriteColored($"\n⚠️ An error occurred: {ex.Message}", ConsoleColor.Red);
        }
    }

    public static void CubeCalc()
    {
        double sideLength = ConsoleManager.GetInput<double>("\n👉 Enter the side length of the cube in centimeters: ");

        double volumeCube = Math.Pow(sideLength, 3);

        ConsoleManager.WriteColored($"\n✅ The volume of the cube is {volumeCube} cm³", ConsoleColor.Green);
    }

    public static void RectangularPrismCalc()
    {
        double length = ConsoleManager.GetInput<double>("\n👉 Enter the length of the prism in centimeters: ");
        double width = ConsoleManager.GetInput<double>("👉 Enter the width of the prism in centimeters: ");
        double height = ConsoleManager.GetInput<double>("👉 Enter the height of the prism in centimeters: ");

        double volumePrism = length * width * height;

        ConsoleManager.WriteColored($"\n✅ The volume of the rectangular prism is {volumePrism} cm³", ConsoleColor.Green);
    }

    public static void CylinderCalc()
    {
        double radius = ConsoleManager.GetInput<double>("\n👉 Enter the radius of the cylinder base in centimeters: ");
        double height = ConsoleManager.GetInput<double>("👉 Enter the height of the cylinder in centimeters: ");

        double volumeCylinder = Math.PI * Math.Pow(radius, 2) * height;

        ConsoleManager.WriteColored($"\n✅ The volume of the cylinder is {volumeCylinder} cm³", ConsoleColor.Green);
    }

    public static void SphereCalc()
    {
        double radius = ConsoleManager.GetInput<double>("\n👉 Enter the radius of the sphere in centimeters: ");

        double volumeSphere = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);

        ConsoleManager.WriteColored($"\n✅ The volume of the sphere is {volumeSphere} cm³", ConsoleColor.Green);
    }

    public static void ConeCalc()
    {
        double radius = ConsoleManager.GetInput<double>("\n👉 Enter the radius of the cone base in centimeters: ");
        double height = ConsoleManager.GetInput<double>("👉 Enter the height of the cone in centimeters: ");

        double volumeCone = (1.0 / 3.0) * Math.PI * Math.Pow(radius, 2) * height;

        ConsoleManager.WriteColored($"\n✅ The volume of the cone is {volumeCone} cm³", ConsoleColor.Green);
    }

    public static void SquarePyramidCalc()
    {
        double baseSide = ConsoleManager.GetInput<double>("\n👉 Enter the base side length of the pyramid in centimeters: ");
        double height = ConsoleManager.GetInput<double>("👉 Enter the height of the pyramid in centimeters: ");

        double volumePyramid = (1.0 / 3.0) * Math.Pow(baseSide, 2) * height;

        ConsoleManager.WriteColored($"\n✅ The volume of the square pyramid is {volumePyramid} cm³", ConsoleColor.Green);
    }
}