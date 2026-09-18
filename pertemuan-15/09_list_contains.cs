// Pertemuan 15 - Collections
// Mengecek data menggunakan Contains()

List<string> nama = new List<string>
{
    "Ilham",
    "Budi",
    "Andi"
};

Console.Write("Masukkan nama yang ingin dicari: ");
string cari = Console.ReadLine() ?? "";

// Contains menghasilkan true atau false
if (nama.Contains(cari))
{
    Console.WriteLine("Nama ditemukan.");
}
else
{
    Console.WriteLine("Nama tidak ditemukan.");
}