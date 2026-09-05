using System;

class Program
{
    static void Main()
    {
        Console.Write("Masukkan nama: ");
        string nama = Console.ReadLine() ?? "";

        Console.Write("Masukkan nilai: ");
        int nilai = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("=== HASIL KELULUSAN ===");
        Console.WriteLine($"Nama  : {nama}");
        Console.WriteLine($"Nilai : {nilai}");

        // Menentukan status berdasarkan nilai
        if (nilai >= 75)
        {
            Console.WriteLine("Status: LULUS");
        }
        else
        {
            Console.WriteLine("Status: TIDAK LULUS");
        }
    }
}