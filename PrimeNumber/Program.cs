using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        List<ulong> primeNumbers = new List<ulong> {2};
        ulong number = 0;
        ulong sum = 0;
        ulong counter = 0;
        var timeSpend = new Stopwatch();    // время выполнения 11:50 (ничего быстрее пока не придумал)

        timeSpend.Start();
        for (ulong i = 2; counter < 10000000; i++)
        {
            number = i;
            if (CheckingForPrimeNumber(number) == true)
            {
                primeNumbers.Add(number);
                counter++;
                sum += number;
            }
        }
        timeSpend.Stop();


        bool CheckingForPrimeNumber(ulong number)
        {
            int i = 0;
            bool q = true;
            for (ulong j = primeNumbers[i]; j <= Math.Round(Math.Sqrt(number - 0.49999)); j++)
            {
                if (number % j == 0)
                {
                    q = false;
                    break;
                }
                else
                {
                    i++;
                }
            }
            return q;
        }

        Console.WriteLine($"Последнее число: {number}");
        Console.WriteLine($"Сумма: {sum}");
        Console.WriteLine($"Время: {timeSpend.Elapsed}");
    }
}
