// Pertemuan 16 - LINQ
// Menggunakan Min() dan Max()

using System.Linq;

List<int> nilai = new List<int>
{
    80,
    90,
    70,
    85,
    95
};

// Mencari nilai terkecil
int terkecil = nilai.Min();

// Mencari nilai terbesar
int terbesar = nilai.Max();

Console.WriteLine($"Nilai terkecil: {terkecil}");
Console.WriteLine($"Nilai terbesar: {terbesar}");