using System;

class Program
{
    // Method mengecek status berdasarkan nilai
    static string CekNilai(int nilai)
    {
        if (nilai >= 75)
        {
            return "Lulus";
        }
        else
        {
            return "Tidak Lulus";
        }
    }

    static void Main()
    {
        int nilai = 80;

        // Mengambil hasil dari method
        string hasil = CekNilai(nilai);

        Console.WriteLine($"Nilai: {nilai}");
        Console.WriteLine($"Status: {hasil}");
    }
}