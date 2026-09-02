// ========================================
// Program Biodata
// Menggabungkan variable dan input
// ========================================

// Meminta nama
Console.Write("Masukkan nama: ");
string nama = Console.ReadLine();

// Meminta umur
Console.Write("Masukkan umur: ");
int umur = int.Parse(Console.ReadLine());

// Meminta kota
Console.Write("Masukkan kota: ");
string kota = Console.ReadLine();

// Menampilkan biodata
Console.WriteLine();
Console.WriteLine("================================");
Console.WriteLine("          BIODATA");
Console.WriteLine("================================");

Console.WriteLine($"Nama : {nama}");
Console.WriteLine($"Umur : {umur}");
Console.WriteLine($"Kota : {kota}");

Console.WriteLine("================================");