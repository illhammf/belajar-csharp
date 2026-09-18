// Pertemuan 15 - Collections
// Menghapus data menggunakan RemoveAt()

List<string> nama = new List<string>
{
    "Ilham",
    "Budi",
    "Andi"
};

// Menghapus data pada index 1
nama.RemoveAt(1);

// Menampilkan data setelah dihapus
foreach (string item in nama)
{
    Console.WriteLine(item);
}