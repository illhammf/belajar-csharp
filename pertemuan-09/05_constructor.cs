// Membuat class Siswa
class Siswa
{
    // Property nama
    public string Nama { get; set; }

    // Constructor
    // Constructor otomatis dijalankan saat object dibuat
    public Siswa()
    {
        Console.WriteLine("Object Siswa berhasil dibuat!");
    }
}

// Membuat object
// Constructor akan otomatis dijalankan
Siswa siswa = new Siswa();

// Mengisi data
siswa.Nama = "Ilham";

// Menampilkan data
Console.WriteLine("Nama: " + siswa.Nama);