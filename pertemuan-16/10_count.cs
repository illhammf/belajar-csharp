// Pertemuan 16 - LINQ
// Menggunakan Count()

using System.Linq;

List<int> nilai = new List<int>
{
    90,
    75,
    60,
    50,
    85,
    70
};

// Menghitung jumlah nilai yang >= 60
int jumlahLulus = nilai.Count(x => x >= 60);

Console.WriteLine($"Jumlah mahasiswa lulus: {jumlahLulus}");