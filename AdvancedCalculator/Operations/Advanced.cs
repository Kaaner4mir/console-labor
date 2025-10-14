class Advanced
{
    public static double? Exponentiation(OperationType operationType, Func<double, double, double> operation)
    {
        try
        {
            double baseNum = ConsoleManager.GetInput<double>("\n➡️ Enter the base number: ");
            double exponent = ConsoleManager.GetInput<double>("➡️ Enter the exponent: ");

            if (baseNum == 0 && exponent == 0)
            {
                ConsoleManager.WriteColored("⛔ Undefined!", ConsoleColor.Yellow);
                return null;
            }

            double result = operation(baseNum, exponent);

            return ShowResult(result, baseNum, exponent, operationType);
        }
        catch (Exception exc)
        {
            ConsoleManager.WriteColored($"\n⚠️ An error occurred: {exc.Message}", ConsoleColor.Red);
            return null;
        }
    }

    public static double? Root(OperationType operationType, Func<double, double, double> operation)
    {
        try
        {
            double radicand = ConsoleManager.GetInput<double>("\n➡️ Enter the radicand: ");
            double rootDegree = ConsoleManager.GetInput<double>("➡️ Enter the root degree: ");

            if (radicand < 0 && rootDegree % 2 == 0)
            {
                ConsoleManager.WriteColored("⛔ Undefined for negative radicand with even root!", ConsoleColor.Yellow);
                return null;
            }

            double result = operation(radicand, rootDegree);

            return ShowResult(result, radicand, rootDegree, operationType);
        }
        catch (Exception exc)
        {
            ConsoleManager.WriteColored($"\n⚠️ An error occurred: {exc.Message}", ConsoleColor.Red);
            return null;
        }
    }

    public static long? Factorial(OperationType operationType)
    {
        try
        {
            int number = ConsoleManager.GetInput<int>("\n➡️ Enter the number you want to learn factorial value: ");

            if (number < 0)
            {
                ConsoleManager.WriteColored("\n⛔ Please enter a positive value!", ConsoleColor.Yellow);
                return null;
            }

            long result = 1;

            for (int i = 1; i <= number; i++)
                result *= i;

            return ShowResult(result, number, 0, operationType);
        }
        catch (Exception exc)
        {
            ConsoleManager.WriteColored($"\n⚠️ An error occurred: {exc.Message}", ConsoleColor.Red);
            return null;
        }
    }

    public static double? Modulo(OperationType operationType, Func<double, double, double> operation)
    {
        try
        {
            int dividend = ConsoleManager.GetInput<int>("\n➡️ Enter the dividend: ");
            int divisor = ConsoleManager.GetInput<int>("\n➡️ Enter the divisor: ");

            if (dividend == 0 && divisor == 0)
            {
                ConsoleManager.WriteColored("\n⛔ Undefined!", ConsoleColor.Red);
                return null;
            }

            if (divisor == 0)
            {
                ConsoleManager.WriteColored("\n⛔ The divisor cannot be zero!", ConsoleColor.Red);
                return null;
            }

            double result = operation(dividend, divisor);

            return ShowResult(result, dividend, divisor, operationType);
        }
        catch (Exception exc)
        {
            ConsoleManager.WriteColored($"\n⚠️ An error occurred: {exc.Message}", ConsoleColor.Red);
            return null;
        }
    }

    public static double? Logarithm(OperationType operationType, Func<double, double, double> operation)
    {
        try
        {
            double baseNum = ConsoleManager.GetInput<double>("\n➡️ Enter the base number: ");
            double argument = ConsoleManager.GetInput<double>("➡️ Enter the argument: ");

            if (baseNum <= 0 || baseNum == 1)
            {
                ConsoleManager.WriteColored("⛔ Undefined! Base must be > 0 and ≠ 1.", ConsoleColor.Yellow);
                return null;
            }

            if (argument <= 0)
            {
                ConsoleManager.WriteColored("⛔ Undefined! Argument must be > 0.", ConsoleColor.Yellow);
                return null;
            }

            double result = operation(baseNum, argument);

            return ShowResult(result, baseNum, argument, operationType);
        }
        catch (Exception exc)
        {
            ConsoleManager.WriteColored($"\n⚠️ An error occurred: {exc.Message}", ConsoleColor.Red);
            return null;
        }
    }

    public static void Trigonometry()
    {
        Console.Clear();
        Menu.TrigonometryMenu();

        TrigonometryOption input = ConsoleManager.GetInput<TrigonometryOption>("\n👉 Please enter the operation you wish to perform numerically: ");
        double degree = ConsoleManager.GetInput<double>("\n👉 Enter the degree: ");
        double radian = degree * (Math.PI / 180);

        double result;

        switch (input)
        {
            case TrigonometryOption.Sine:
                result = Math.Sin(radian);
                ShowResult(result, degree, 0, OperationType.Sine);
                break;
            case TrigonometryOption.Cosine:
                result = Math.Cos(radian);
                ShowResult(result, degree, 0, OperationType.Cosine);
                break;
            case TrigonometryOption.Tangent:
                result = Math.Tan(radian);
                ShowResult(result, degree, 0, OperationType.Tangent);
                break;
            case TrigonometryOption.Cotangent:
                result = 1.0 / Math.Tan(radian);
                ShowResult(result, degree, 0, OperationType.Cotangent);
                break;
            case TrigonometryOption.Secant:
                result = 1.0 / Math.Cos(radian);
                ShowResult(result, degree, 0, OperationType.Secant);
                break;
            case TrigonometryOption.Cosecant:
                result = 1.0 / Math.Sin(radian);
                ShowResult(result, degree, 0, OperationType.Cosecant);
                break;
            default:
                ConsoleManager.WriteColored(
                    "\n❓ The operation you want to perform could not be found.", ConsoleColor.Yellow);
                break;
        }
    }

    public static T ShowResult<T>(T result, double operand1, double operand2, OperationType operationType)
    {
        string symbol = operationType switch
        {
            OperationType.Exponentiation => "^",
            OperationType.Root => "√",
            OperationType.Factorial => "!",
            OperationType.Modulo => "%",
            OperationType.Logarithm => "log",
            OperationType.Sine => "sin",
            OperationType.Cosine => "cos",
            OperationType.Tangent => "tan",
            OperationType.Cotangent => "cot",
            OperationType.Secant => "sec",
            OperationType.Cosecant => "csc",
            _ => "?"
        };

        if (operationType == OperationType.Factorial)
            ConsoleManager.WriteColored($"\n✅ {operand1}{symbol} = {result}", ConsoleColor.Green);
        else if (operationType == OperationType.Logarithm)
            ConsoleManager.WriteColored($"\n✅ {symbol}_{operand1}({operand2}) = {result}", ConsoleColor.Green);
        else if (operationType >= OperationType.Sine && operationType <= OperationType.Cosecant)
        {
            ConsoleManager.WriteColored(
               $"\n✅ {symbol}({operand1}) = {result}",
               ConsoleColor.Green);
        }
        else
            ConsoleManager.WriteColored($"\n✅ {operand1} {symbol} {operand2} = {result}", ConsoleColor.Green);



        return result;
    }
}


