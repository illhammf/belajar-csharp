using System;

class Program
{
    // Method memiliki dua parameter
    static void Biodata(string nama, int umur)
    {
        Console.WriteLine($"Nama: {nama}");
        Console.WriteLine($"Umur: {umur}");
    }

    static void Main()
    {
        // Mengirim dua nilai sesuai urutan parameter
        Biodata("Ilham", 20);
    }
}