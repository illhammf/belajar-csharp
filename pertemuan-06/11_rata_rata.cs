using System;

class Program
{
    // Method menghitung rata-rata dari tiga nilai
    static double HitungRataRata(int nilai1, int nilai2, int nilai3)
    {
        return (nilai1 + nilai2 + nilai3) / 3.0;
    }

    static void Main()
    {
        int nilai1 = 80;
        int nilai2 = 75;
        int nilai3 = 90;

        // Memanggil method untuk menghitung rata-rata
        double rataRata = HitungRataRata(nilai1, nilai2, nilai3);

        Console.WriteLine($"Nilai 1 : {nilai1}");
        Console.WriteLine($"Nilai 2 : {nilai2}");
        Console.WriteLine($"Nilai 3 : {nilai3}");
        Console.WriteLine($"Rata-rata: {rataRata:F2}");
    }
}