using System;

class Program
{
    // Method mengembalikan nilai true atau false
    static bool Lulus(int nilai)
    {
        return nilai >= 75;
    }

    static void Main()
    {
        int nilai = 80;

        // Memanggil method dan menyimpan hasilnya
        bool status = Lulus(nilai);

        Console.WriteLine($"Lulus: {status}");
    }
}