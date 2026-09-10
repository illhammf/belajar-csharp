// Membuat class Siswa
class Siswa
{
    // Property nama
    public string Nama { get; set; }

    // Constructor
    public Siswa(string Nama)
    {
        // this.Nama mengarah ke property milik object
        // Nama di sebelah kanan adalah parameter
        this.Nama = Nama;
    }
}

// Membuat object
Siswa siswa = new Siswa("Ilham");

// Menampilkan nama
Console.WriteLine("Nama: " + siswa.Nama);