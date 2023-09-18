namespace ExtensionMethods_MiniProject;

public static class ConsoleHelper
{
    public static string RequestString(this string message)
    {
        string output = "";

        while (string.IsNullOrWhiteSpace(output))
        {
            Console.Write(message);
            output = Console.ReadLine();
        }

        return output;
    }

    public static int RequestInt(this string message, int minValue, int maxValue)
    {
        return message.RequestInt(true, minValue, maxValue);
    }

    public static int RequestInt(this string message)
    {
        return message.RequestInt(false);
    }

    private static int RequestInt(this string message, bool useMinMax, int minValue = 0, int maxValue = 0)
    {
        int output = 0;
        bool isValidInt = false;
        bool isInvalidRange = true;

        while (!isValidInt || !isInvalidRange)
        {
            Console.Write(message);
            isValidInt = int.TryParse(Console.ReadLine(), out output);

            if (useMinMax)
            {
                isInvalidRange = (output >= 0 && output <= maxValue);
                //if (output >= minValue && output <= maxValue)
                //{
                //    isInvalidRange = true;
                //}
                //else
                //{
                //    isInvalidRange = false;
                //}
            }
        }

        return output;
    }

    public static decimal RequestDecimal(this string message)
    {

    }

    public static decimal RequestDecimal(this string message, int low, int high)
    {

    }

    private static decimal RequestDecimal(this string message, bool moreThanOnePurchase, int low, int high)
    {

    }
}
