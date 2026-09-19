// Pertemuan 16 - LINQ
// Menggunakan Average()

using System.Linq;

List<int> nilai = new List<int>
{
    80,
    90,
    70,
    85
};

// Menghitung rata-rata
double rataRata = nilai.Average();

Console.WriteLine($"Rata-rata nilai: {rataRata:F2}");