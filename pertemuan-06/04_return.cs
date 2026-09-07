using System;

class Program
{
    // Method mengembalikan hasil penjumlahan
    static int Tambah(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        // Menyimpan nilai yang dikembalikan method
        int hasil = Tambah(10, 5);

        Console.WriteLine($"Hasil: {hasil}");
    }
}