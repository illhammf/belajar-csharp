// Pertemuan 15 - Collections
// Mengenal Dictionary<TKey, TValue>

// Membuat Dictionary
// Key bertipe string
// Value bertipe int
Dictionary<string, int> nilai = new Dictionary<string, int>();

// Menambahkan data
nilai.Add("Ilham", 90);
nilai.Add("Budi", 80);
nilai.Add("Andi", 85);

// Mengakses Value menggunakan Key
Console.WriteLine($"Nilai Ilham: {nilai["Ilham"]}");
Console.WriteLine($"Nilai Budi: {nilai["Budi"]}");
Console.WriteLine($"Nilai Andi: {nilai["Andi"]}");