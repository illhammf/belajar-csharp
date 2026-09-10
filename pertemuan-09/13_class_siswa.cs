// Membuat class Siswa
class Siswa
{
    // Property siswa
    public string Nama { get; set; }
    public string Kelas { get; set; }
    public double Nilai { get; set; }

    // Method untuk menentukan kelulusan
    public string CekKelulusan()
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
        Console.WriteLine("Status : " + CekKelulusan());
    }
}

// Membuat object siswa
Siswa siswa = new Siswa();

// Mengisi data
siswa.Nama = "Ilham";
siswa.Kelas = "TI-1";
siswa.Nilai = 90;

// Menampilkan data
siswa.TampilkanData();