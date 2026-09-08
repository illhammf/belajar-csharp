using System;

class Program
{
    static void Main()
    {
        // Membuat array berisi nama
        string[] nama = { "Ilham", "Budi", "Andi", "Siti" };

        // Menampilkan seluruh nama
        for (int i = 0; i < nama.Length; i++)
        {
            Console.WriteLine($"Nama ke-{i + 1}: {nama[i]}");
        }
    }
}