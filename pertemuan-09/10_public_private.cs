// Membuat class Siswa
class Siswa
{
    // Public dapat diakses dari luar class
    public string Nama { get; set; }

    // Private hanya dapat digunakan di dalam class
    private double nilai;

    // Method untuk mengisi nilai
    public void SetNilai(double nilai)
    {
        this.nilai = nilai;
    }

    // Method untuk mengambil nilai
    public double GetNilai()
    {
        return nilai;
    }
}

// Membuat object
Siswa siswa = new Siswa();

// Mengisi nama
siswa.Nama = "Ilham";

// Mengisi nilai melalui method
siswa.SetNilai(90);

// Mengambil nilai melalui method
double nilaiSiswa = siswa.GetNilai();

// Menampilkan data
Console.WriteLine("Nama  : " + siswa.Nama);
Console.WriteLine("Nilai : " + nilaiSiswa);