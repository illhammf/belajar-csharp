// Pertemuan 15 - Collections
// Menghapus data menggunakan Remove()

List<string> nama = new List<string>
{
    "Ilham",
    "Budi",
    "Andi"
};

// Menghapus data berdasarkan nilai
nama.Remove("Budi");

// Menampilkan data setelah dihapus
foreach (string item in nama)
{
    Console.WriteLine(item);
}