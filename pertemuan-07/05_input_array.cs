using System;

class Program
{
    static void Main()
    {
        // Membuat array dengan 5 elemen
        int[] angka = new int[5];

        // Meminta user mengisi setiap elemen
        for (int i = 0; i < angka.Length; i++)
        {
            Console.Write($"Masukkan angka ke-{i + 1}: ");
            angka[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("Isi array:");

        // Menampilkan semua data yang sudah dimasukkan
        for (int i = 0; i < angka.Length; i++)
        {
            Console.WriteLine(angka[i]);
        }
    }
}