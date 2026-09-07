using System;

class Program
{
    // Method menampilkan angka dari 1 sampai batas tertentu
    static void TampilkanAngka(int batas)
    {
        for (int i = 1; i <= batas; i++)
        {
            Console.WriteLine(i);
        }
    }

    static void Main()
    {
        // Menampilkan angka 1 sampai 5
        TampilkanAngka(5);

        Console.WriteLine();

        // Method yang sama bisa digunakan lagi
        TampilkanAngka(10);
    }
}