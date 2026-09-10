// Membuat class Siswa
class Siswa
{
    // Property untuk menyimpan nama
    public string Nama { get; set; }

    // Property untuk menyimpan kelas
    public string Kelas { get; set; }

    // Property untuk menyimpan nilai
    public double Nilai { get; set; }

    // Constructor untuk mengisi data awal
    public Siswa(string nama, string kelas, double nilai)
    {
        Nama = nama;
        Kelas = kelas;
        Nilai = nilai;
    }

    // Method untuk menentukan status kelulusan
    public string GetStatus()
    {
        if (Nilai >= 75)
        {
            return "Lulus";
        }

        return "Tidak Lulus";
    }

    // Method untuk menampilkan data siswa
    public void TampilkanData()
    {
        Console.WriteLine("Nama   : " + Nama);
        Console.WriteLine("Kelas  : " + Kelas);
        Console.WriteLine("Nilai  : " + Nilai);
        Console.WriteLine("Status : " + GetStatus());
    }
}


// ==============================
// PROGRAM UTAMA
// ==============================

// Meminta input nama
Console.Write("Masukkan nama: ");
string nama = Console.ReadLine() ?? "";

// Meminta input kelas
Console.Write("Masukkan kelas: ");
string kelas = Console.ReadLine() ?? "";

// Meminta input nilai
Console.Write("Masukkan nilai: ");
double nilai = Convert.ToDouble(Console.ReadLine());

// Membuat object Siswa
Siswa siswa = new Siswa(nama, kelas, nilai);

// Menampilkan data
Console.WriteLine();
Console.WriteLine("=== DATA SISWA ===");

// Memanggil method dari object
siswa.TampilkanData();