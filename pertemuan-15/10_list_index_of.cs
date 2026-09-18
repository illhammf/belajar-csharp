// Pertemuan 15 - Collections
// Mencari index data menggunakan IndexOf()

List<string> nama = new List<string>
{
    "Ilham",
    "Budi",
    "Andi"
};

Console.Write("Masukkan nama yang ingin dicari: ");
string cari = Console.ReadLine() ?? "";

// Mencari posisi index
int index = nama.IndexOf(cari);

if (index != -1)
{
    Console.WriteLine($"Data ditemukan pada index {index}.");
}
else
{
    Console.WriteLine("Data tidak ditemukan.");
}