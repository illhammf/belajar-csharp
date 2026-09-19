// Pertemuan 16 - LINQ
// Menggunakan Sum()

using System.Linq;

List<int> nilai = new List<int>
{
    80,
    90,
    70,
    85
};

// Menghitung total nilai
int total = nilai.Sum();

Console.WriteLine($"Total nilai: {total}");