// Pertemuan 16 - LINQ
// Menggunakan Select() pada object

using System.Linq;

List<Mahasiswa> mahasiswa = new List<Mahasiswa>
{
    new Mahasiswa("Ilham", 90),
    new Mahasiswa("Budi", 80),
    new Mahasiswa("Andi", 85)
};

// Mengambil property Nama saja
var nama = mahasiswa.Select(x => x.Nama);

// Menampilkan nama
foreach (string item in nama)
{
    Console.WriteLine(item);
}

// Class Mahasiswa
class Mahasiswa
{
    public string Nama { get; set; }
    public int Nilai { get; set; }

    public Mahasiswa(string nama, int nilai)
    {
        Nama = nama;
        Nilai = nilai;
    }
}