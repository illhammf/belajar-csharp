// Membuat array berisi beberapa string
string[] nama = 
{
    "Ilham",
    "Rizky",
    "Andi",
    "Budi"
};

// Menampilkan semua data menggunakan loop
for (int i = 0; i < nama.Length; i++)
{
    Console.WriteLine("Nama ke-" + (i + 1) + ": " + nama[i]);
}