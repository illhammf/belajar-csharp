using System;

class Program
{
    static void Main()
    {
        int[] angka = { 10, 20, 30, 40, 50 };

        // Menggunakan Length untuk mengetahui jumlah elemen
        for (int i = 0; i < angka.Length; i++)
        {
            // Menampilkan index dan nilai array
            Console.WriteLine($"Index {i}: {angka[i]}");
        }
    }
}