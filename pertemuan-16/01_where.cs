// Pertemuan 16 - LINQ
// Menggunakan Where() untuk filter data

using System.Linq;

// Membuat List angka
List<int> angka = new List<int>
{
    10,
    15,
    20,
    25,
    30
};

// Mengambil angka yang lebih besar dari 20
var hasil = angka.Where(x => x > 20);

// Menampilkan hasil
foreach (int item in hasil)
{
    Console.WriteLine(item);
}