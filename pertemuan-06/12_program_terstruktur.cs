using System;

class Program
{
    // Method untuk menampilkan judul program
    static void TampilkanJudul()
    {
        Console.WriteLine("=== PROGRAM NILAI ===");
    }

    // Method untuk mengecek kelulusan
    static string CekKelulusan(int nilai)
    {
        if (nilai >= 75)
        {
            return "Lulus";
        }

        return "Tidak Lulus";
    }

    // Method untuk menentukan grade
    static string TentukanGrade(int nilai)
    {
        if (nilai >= 90)
        {
            return "A";
        }
        else if (nilai >= 80)
        {
            return "B";
        }
        else if (nilai >= 70)
        {
            return "C";
        }
        else
        {
            return "D";
        }
    }

    static void Main()
    {
        // Menampilkan judul
        TampilkanJudul();

        // Meminta input nama
        Console.Write("Masukkan nama: ");
        string nama = Console.ReadLine() ?? "";

        // Meminta input nilai
        Console.Write("Masukkan nilai: ");
        int nilai = Convert.ToInt32(Console.ReadLine());

        // Memanggil method untuk menentukan status
        string status = CekKelulusan(nilai);

        // Memanggil method untuk menentukan grade
        string grade = TentukanGrade(nilai);

        // Menampilkan hasil
        Console.WriteLine();
        Console.WriteLine("=== HASIL ===");
        Console.WriteLine($"Nama   : {nama}");
        Console.WriteLine($"Nilai  : {nilai}");
        Console.WriteLine($"Grade  : {grade}");
        Console.WriteLine($"Status : {status}");
    }
}