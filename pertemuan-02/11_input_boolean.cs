// bool digunakan untuk menyimpan true atau false.

// Meminta pengguna memasukkan nilai boolean
Console.Write("Apakah kamu mahasiswa? ");

// Mengubah input string menjadi bool
bool mahasiswa = bool.Parse(Console.ReadLine());

// Menampilkan hasil
Console.WriteLine($"Status mahasiswa: {mahasiswa}");