using System;

class Program
{
    static void Main()
    {
        int i = 1;

        // do akan dijalankan terlebih dahulu
        do
        {
            Console.WriteLine(i);

            // Menambah nilai i
            i++;
        }
        // Setelah itu kondisi baru diperiksa
        while (i <= 5);
    }
}