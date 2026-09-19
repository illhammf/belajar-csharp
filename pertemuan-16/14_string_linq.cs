// Pertemuan 16 - LINQ
// LINQ pada data string

using System.Linq;

List<string> nama = new List<string>
{
    "Ilham",
    "Budi",
    "Andi",
    "Irfan",
    "Rizky"
};

// Mengambil nama yang diawali huruf I
var hasil = nama.Where(x => x.StartsWith("I"));

// Menampilkan hasil
Console.WriteLine("Nama yang diawali huruf I:");

foreach (string item in hasil)
{
    Console.WriteLine(item);
}