public static class StatisticsHelper
{
    public static int CalculateSum(int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    public static double CalculateAverage(int[] numbers)
    {
        return (double)CalculateSum(numbers) / numbers.Length;
    }
}
