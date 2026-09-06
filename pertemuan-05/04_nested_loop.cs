using System;

class Program
{
    static void Main()
    {
        // Looping luar untuk menentukan baris
        for (int baris = 1; baris <= 3; baris++)
        {
            // Looping dalam untuk menentukan kolom
            for (int kolom = 1; kolom <= 3; kolom++)
            {
                Console.Write("*");
            }

            // Pindah ke baris berikutnya
            Console.WriteLine();
        }
    }
}