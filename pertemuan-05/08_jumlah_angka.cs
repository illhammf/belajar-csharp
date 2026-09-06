using System;

class Program
{
    static void Main()
    {
        int total = 0;

        // Menjumlahkan angka 1 sampai 5
        for (int i = 1; i <= 5; i++)
        {
            total += i;
        }

        Console.WriteLine($"Total: {total}");
    }
}