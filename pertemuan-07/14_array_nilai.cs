using System;

class Program
{
    static void Main()
    {
        int[] nilai = { 60, 80, 75, 50, 90 };

        Console.WriteLine("=== HASIL NILAI ===");

        // Mengecek setiap nilai di dalam array
        for (int i = 0; i < nilai.Length; i++)
        {
            // Mengecek apakah nilai memenuhi batas kelulusan
            if (nilai[i] >= 75)
            {
                Console.WriteLine($"Nilai {nilai[i]}: Lulus");
            }
            else
            {
                Console.WriteLine($"Nilai {nilai[i]}: Tidak Lulus");
            }
        }
    }
}