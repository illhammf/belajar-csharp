using System;

class Program
{
    static void Main()
    {
        int[] angka = { 10, 20, 30 };

        // Menampilkan data sebelum diubah
        Console.WriteLine("Sebelum diubah:");
        Console.WriteLine(angka[1]);

        // Mengubah nilai pada index 1
        angka[1] = 100;

        // Menampilkan data setelah diubah
        Console.WriteLine("Setelah diubah:");
        Console.WriteLine(angka[1]);
    }
}