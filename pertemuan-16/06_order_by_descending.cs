// Pertemuan 16 - LINQ
// Menggunakan OrderByDescending()

using System.Linq;

List<int> angka = new List<int>
{
    40,
    10,
    30,
    20,
    50
};

// Mengurutkan dari besar ke kecil
var hasil = angka.OrderByDescending(x => x);

// Menampilkan hasil
Console.WriteLine("Urutan dari besar ke kecil:");

foreach (int item in hasil)
{
    Console.WriteLine(item);
}