using System;

class Program
{
    static void Main()
    {
        int[] angka = { 10, 20, 30, 40, 50 };

        int total = 0;

        // Menjumlahkan seluruh elemen array
        for (int i = 0; i < angka.Length; i++)
        {
            total += angka[i];
        }

        Console.WriteLine($"Total: {total}");
    }
}