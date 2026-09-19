// Pertemuan 16 - LINQ
// Menggunakan Select() untuk mengubah data

using System.Linq;

List<int> angka = new List<int>
{
    1,
    2,
    3,
    4,
    5
};

// Mengubah setiap angka menjadi kuadrat
var kuadrat = angka.Select(x => x * x);

// Menampilkan hasil
foreach (int item in kuadrat)
{
    Console.WriteLine(item);
}