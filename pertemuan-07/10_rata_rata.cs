using System;

class Program
{
    static void Main()
    {
        int[] nilai = { 80, 75, 90, 85, 70 };

        int total = 0;

        // Menghitung total seluruh nilai
        for (int i = 0; i < nilai.Length; i++)
        {
            total += nilai[i];
        }

        // Mengubah total menjadi double agar hasil bisa berupa desimal
        double rataRata = (double)total / nilai.Length;

        Console.WriteLine($"Total: {total}");
        Console.WriteLine($"Rata-rata: {rataRata:F2}");
    }
}