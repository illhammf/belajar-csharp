// Pertemuan 15 - Collections
// Menambahkan data ke List dengan Add()

List<string> nama = new List<string>();

// Menambahkan data ke dalam List
nama.Add("Ilham");
nama.Add("Budi");
nama.Add("Andi");

// Menampilkan seluruh data
foreach (string item in nama)
{
    Console.WriteLine(item);
}