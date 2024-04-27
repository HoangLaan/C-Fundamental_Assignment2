using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static async Task<bool> IsPrimeAsync(int number)
    {
        await Task.Delay(1);

        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
    static async Task CheckAndPrintPrimeAsync(int number)
    {
        if (await IsPrimeAsync(number))
            Console.WriteLine(number);
    }

    static async Task Main()
    {
        Console.WriteLine("Enter start number: ");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter end Number: ");
        int end = Convert.ToInt32(Console.ReadLine());

        List<Task> primeTasks = new List<Task>();
        for (int i = start; i <= end; i++)
        {
            primeTasks.Add(CheckAndPrintPrimeAsync(i));
        }

        await Task.WhenAll(primeTasks);
    }


}
