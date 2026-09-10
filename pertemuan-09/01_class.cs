// Membuat sebuah class bernama Siswa
class Siswa
{
    // Property untuk menyimpan nama siswa
    public string Nama { get; set; }

    // Property untuk menyimpan kelas siswa
    public string Kelas { get; set; }
}

// Program utama
Siswa siswa = new Siswa();

// Mengisi property object
siswa.Nama = "Ilham";
siswa.Kelas = "TI-1";

// Menampilkan data
Console.WriteLine("Nama  : " + siswa.Nama);
Console.WriteLine("Kelas : " + siswa.Kelas);