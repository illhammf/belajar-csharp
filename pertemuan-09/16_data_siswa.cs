// Membuat class Siswa
class Siswa
{
    // Property siswa
    public string Nama { get; set; }
    public string Kelas { get; set; }
    public double Nilai { get; set; }

    // Constructor untuk mengisi data awal
    public Siswa(string nama, string kelas, double nilai)
    {
        Nama = nama;
        Kelas = kelas;
        Nilai = nilai;
    }

    // Method untuk mendapatkan status kelulusan
    public string GetStatus()
    {
        if (Nilai >= 75)
        {
            return "Lulus";
        }

        return "Tidak Lulus";
    }

    // Method untuk menampilkan data
    public void TampilkanData()
    {
        Console.WriteLine("Nama   : " + Nama);
        Console.WriteLine("Kelas  : " + Kelas);
        Console.WriteLine("Nilai  : " + Nilai);
        Console.WriteLine("Status : " + GetStatus());
    }
}

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

siswa.TampilkanData();