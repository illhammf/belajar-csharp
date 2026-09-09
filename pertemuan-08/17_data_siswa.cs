// Meminta nama siswa
Console.Write("Masukkan nama siswa: ");
string nama = Console.ReadLine() ?? "";

// Meminta kelas siswa
Console.Write("Masukkan kelas: ");
string kelas = Console.ReadLine() ?? "";

// Meminta nilai siswa
Console.Write("Masukkan nilai: ");
double nilai = Convert.ToDouble(Console.ReadLine());

// Menentukan status kelulusan
string status;

if (nilai >= 75)
{
    status = "Lulus";
}
else
{
    status = "Tidak Lulus";
}

// Menampilkan data siswa
Console.WriteLine();
Console.WriteLine("=== DATA SISWA ===");
Console.WriteLine("Nama   : " + nama);
Console.WriteLine("Kelas  : " + kelas);
Console.WriteLine("Nilai  : " + nilai);
Console.WriteLine("Status : " + status);