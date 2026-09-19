// Pertemuan 16 - LINQ
// Menggunakan First()

using System.Linq;

List<int> angka = new List<int>
{
    10,
    20,
    30,
    40
};

// Mengambil data pertama
int pertama = angka.First();

Console.WriteLine($"Data pertama: {pertama}");