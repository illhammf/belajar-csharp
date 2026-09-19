// Pertemuan 16 - LINQ
// Menggunakan Any() untuk mengecek data

using System.Linq;

List<int> angka = new List<int>
{
    10,
    20,
    30,
    40
};

// Mengecek apakah ada angka yang lebih besar dari 25
bool ada = angka.Any(x => x > 25);

if (ada)
{
    Console.WriteLine("Ada angka yang lebih besar dari 25.");
}
else
{
    Console.WriteLine("Tidak ada angka yang lebih besar dari 25.");
}