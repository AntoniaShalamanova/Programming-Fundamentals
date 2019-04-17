using System;

class PriceChangeAlert
{
    static void Main()
    {
        int priceCount = int.Parse(Console.ReadLine());
        double significanceThreshold = double.Parse(Console.ReadLine());
        double lastNumber = double.Parse(Console.ReadLine());

        for (int i = 2; i <= priceCount; i++)
        {
            double currentNumber = double.Parse(Console.ReadLine());
            double differnceInPercent = CalcDiffernce(lastNumber, currentNumber);
            bool isSignificantDifference = HasSignificantDifference(differnceInPercent, significanceThreshold);

            string result = GetResult(currentNumber, lastNumber, differnceInPercent, isSignificantDifference);
            Console.WriteLine(result);

            lastNumber = currentNumber;
        }
    }

    private static string GetResult(double currentNumber, double lastNumber, double differnceInPercent, bool isSignificantDifference)
    {
        string result = "";
        if (differnceInPercent == 0)
        {
            result = string.Format("NO CHANGE: {0}", currentNumber);
        }
        else if (!isSignificantDifference)
        {
            result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastNumber, currentNumber, differnceInPercent);
        }
        else if (isSignificantDifference && (differnceInPercent > 0))
        {
            result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastNumber, currentNumber, differnceInPercent);
        }
        else if (isSignificantDifference && (differnceInPercent < 0))
            result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastNumber, currentNumber, differnceInPercent);
        return result;
    }

    private static bool HasSignificantDifference(double differnceInPercent, double significanceThreshold)
    {
        if (Math.Abs(differnceInPercent / 100) >= significanceThreshold)
        {
            return true;
        }
        return false;
    }

    private static double CalcDiffernce(double lastNumber, double currentNumber)
    {
        double differenceInPercent = (currentNumber - lastNumber) * 100 / lastNumber;
        return differenceInPercent;
    }
}

