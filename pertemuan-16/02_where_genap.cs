// Pertemuan 16 - LINQ
// Menggunakan Where() untuk mencari bilangan genap

using System.Linq;

List<int> angka = new List<int>
{
    1,
    2,
    3,
    4,
    5,
    6,
    7,
    8
};

// Mengambil angka yang habis dibagi 2
var genap = angka.Where(x => x % 2 == 0);

// Menampilkan bilangan genap
Console.WriteLine("Bilangan genap:");

foreach (int item in genap)
{
    Console.WriteLine(item);
}