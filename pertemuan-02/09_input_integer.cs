// Console.ReadLine() menghasilkan string.
// Untuk mendapatkan angka int, kita perlu melakukan parsing.

// Meminta umur
Console.Write("Masukkan umur: ");

// Mengubah input string menjadi int
int umur = int.Parse(Console.ReadLine());

// Menampilkan hasil
Console.WriteLine($"Umur kamu adalah {umur} tahun.");