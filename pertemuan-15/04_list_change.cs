// Pertemuan 15 - Collections
// Mengubah data di dalam List

List<string> nama = new List<string>
{
    "Ilham",
    "Budi",
    "Andi"
};

// Mengubah data pada index 1
nama[1] = "Rizky";

// Menampilkan data setelah diubah
foreach (string item in nama)
{
    Console.WriteLine(item);
}