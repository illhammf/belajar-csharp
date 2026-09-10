// Membuat class Siswa
class Siswa
{
    // Property nama
    public string Nama { get; set; }

    // Method untuk memperkenalkan diri
    public void Perkenalan()
    {
        Console.WriteLine("Halo, nama saya " + Nama);
    }
}

// Membuat object
Siswa siswa = new Siswa();

// Mengisi nama
siswa.Nama = "Ilham";

// Memanggil method
siswa.Perkenalan();