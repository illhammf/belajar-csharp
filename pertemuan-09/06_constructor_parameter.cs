// Membuat class Siswa
class Siswa
{
    // Property nama
    public string Nama { get; set; }

    // Property umur
    public int Umur { get; set; }

    // Constructor dengan parameter
    public Siswa(string nama, int umur)
    {
        Nama = nama;
        Umur = umur;
    }
}

// Membuat object sekaligus memberikan data
Siswa siswa = new Siswa("Ilham", 20);

// Menampilkan data
Console.WriteLine("Nama : " + siswa.Nama);
Console.WriteLine("Umur : " + siswa.Umur);