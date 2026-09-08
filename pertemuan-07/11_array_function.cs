using System;

class Program
{
    // Method menerima array sebagai parameter
    static void TampilkanArray(int[] angka)
    {
        // Menampilkan seluruh isi array
        for (int i = 0; i < angka.Length; i++)
        {
            Console.WriteLine($"Index {i}: {angka[i]}");
        }
    }

    static void Main()
    {
        int[] data = { 10, 20, 30, 40, 50 };

        // Mengirim array ke method
        TampilkanArray(data);
    }
}