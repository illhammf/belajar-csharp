// Membuat object Siswa
Siswa siswa = new Siswa();

// Mengisi property dari parent
siswa.Nama = "Ilham";

// Mengisi property dari child
siswa.Kelas = "TI-1";

// Memanggil method parent
siswa.Perkenalan();

// Menampilkan kelas
Console.WriteLine(
    "Kelas: " + siswa.Kelas
);

// Memanggil method child
siswa.Belajar();


// ==========================================
// PARENT CLASS
// ==========================================

class Orang
{
    // Property milik parent
    public string Nama { get; set; }

    // Method milik parent
    public void Perkenalan()
    {
        Console.WriteLine(
            "Nama: " + Nama
        );
    }
}


// ==========================================
// CHILD CLASS
// ==========================================

class Siswa : Orang
{
    // Property khusus Siswa
    public string Kelas { get; set; }

    // Method khusus Siswa
    public void Belajar()
    {
        Console.WriteLine(
            Nama + " sedang belajar"
        );
    }
}