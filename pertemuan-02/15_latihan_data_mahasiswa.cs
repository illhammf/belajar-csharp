// ========================================
// Program Data Mahasiswa
// ========================================

// Meminta nama mahasiswa
Console.Write("Masukkan nama: ");
string nama = Console.ReadLine();

// Meminta nilai mahasiswa
Console.Write("Masukkan nilai: ");
double nilai = double.Parse(Console.ReadLine());

// Menampilkan data mahasiswa
Console.WriteLine();
Console.WriteLine("================================");
Console.WriteLine("       DATA MAHASISWA");
Console.WriteLine("================================");

Console.WriteLine($"Nama  : {nama}");
Console.WriteLine($"Nilai : {nilai}");

Console.WriteLine("================================");