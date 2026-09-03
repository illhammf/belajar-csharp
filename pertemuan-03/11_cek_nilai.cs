// ==========================================
// CEK NILAI MAHASISWA
// ==========================================

Console.WriteLine("==============================");
Console.WriteLine("       CEK NILAI");
Console.WriteLine("==============================");

// Input nama
Console.Write("Masukkan nama  : ");
string? nama = Console.ReadLine();

// Input nilai
Console.Write("Masukkan nilai : ");
double nilai = Convert.ToDouble(Console.ReadLine());


// Mengecek apakah nilai berada pada range yang valid
bool nilaiValid = nilai >= 0 && nilai <= 100;

if (!nilaiValid)
{
    Console.WriteLine();
    Console.WriteLine("Nilai harus berada di antara 0 - 100.");
    return;
}


// Menentukan status menggunakan ternary
string status = nilai >= 75
    ? "Lulus"
    : "Tidak Lulus";


// Menampilkan hasil
Console.WriteLine();
Console.WriteLine("==============================");
Console.WriteLine("          HASIL");
Console.WriteLine("==============================");

Console.WriteLine($"Nama   : {nama}");
Console.WriteLine($"Nilai  : {nilai}");
Console.WriteLine($"Status : {status}");