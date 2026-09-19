// Pertemuan 16 - LINQ
// Menggunakan OrderBy()

using System.Linq;

List<int> angka = new List<int>
{
    40,
    10,
    30,
    20,
    50
};

// Mengurutkan dari kecil ke besar
var hasil = angka.OrderBy(x => x);

// Menampilkan hasil
Console.WriteLine("Urutan dari kecil ke besar:");

foreach (int item in hasil)
{
    Console.WriteLine(item);
}