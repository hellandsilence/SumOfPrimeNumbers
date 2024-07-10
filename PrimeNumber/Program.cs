using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        ulong number = 0;
        ulong sum = 17; // Сумма первых 4 простых чисел (2, 3, 5, 7)
        ulong counter = 4; // Первые 4 простых числа из 10 000 000
        var timeSpend = new Stopwatch();

        timeSpend.Start();
        for (ulong i = 10; counter < 10000000; i++)
        {
            number = i;
            if(number % 2 != 0 && number % 3 != 0 && number % 5 != 0 && number % 7 != 0)
            {
                counter++;
                sum += number;
            }
        }
        timeSpend.Stop();

        Console.WriteLine($"Последнее число: {number}");
        Console.WriteLine($"Сумма: {sum}");
        Console.WriteLine($"Время: {timeSpend.Elapsed}");
    }
}