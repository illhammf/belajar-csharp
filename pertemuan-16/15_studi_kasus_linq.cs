// Pertemuan 16 - LINQ
// Studi Kasus: Sistem Data Mahasiswa

using System.Linq;

// Membuat List data mahasiswa
List<Mahasiswa> mahasiswa = new List<Mahasiswa>
{
    new Mahasiswa("Ilham", 90),
    new Mahasiswa("Luqman", 55),
    new Mahasiswa("Adit", 80),
    new Mahasiswa("Dafa", 70),
    new Mahasiswa("Farel", 65),
    new Mahasiswa("Tupen", 40)
};

// ========================================
// 1. Menampilkan semua mahasiswa
// ========================================

Console.WriteLine("=== SEMUA MAHASISWA ===");

foreach (var item in mahasiswa)
{
    Console.WriteLine($"{item.Nama}: {item.Nilai}");
}

// ========================================
// 2. Menampilkan mahasiswa yang lulus
// ========================================

Console.WriteLine("\n=== MAHASISWA LULUS ===");

var lulus = mahasiswa
    .Where(x => x.Nilai >= 60);

foreach (var item in lulus)
{
    Console.WriteLine($"{item.Nama}: {item.Nilai}");
}

// ========================================
// 3. Menampilkan mahasiswa yang tidak lulus
// ========================================

Console.WriteLine("\n=== MAHASISWA TIDAK LULUS ===");

var tidakLulus = mahasiswa
    .Where(x => x.Nilai < 60);

foreach (var item in tidakLulus)
{
    Console.WriteLine($"{item.Nama}: {item.Nilai}");
}

// ========================================
// 4. Mengurutkan dari nilai terbesar
// ========================================

Console.WriteLine("\n=== URUTAN NILAI TERBESAR ===");

var urutanTerbesar = mahasiswa
    .OrderByDescending(x => x.Nilai);

foreach (var item in urutanTerbesar)
{
    Console.WriteLine($"{item.Nama}: {item.Nilai}");
}

// ========================================
// 5. Mengurutkan dari nilai terkecil
// ========================================

Console.WriteLine("\n=== URUTAN NILAI TERKECIL ===");

var urutanTerkecil = mahasiswa
    .OrderBy(x => x.Nilai);

foreach (var item in urutanTerkecil)
{
    Console.WriteLine($"{item.Nama}: {item.Nilai}");
}

// ========================================
// 6. Mencari mahasiswa dengan nilai tertinggi
// ========================================

var nilaiTertinggi = mahasiswa.Max(x => x.Nilai);

var mahasiswaTerbaik = mahasiswa
    .First(x => x.Nilai == nilaiTertinggi);

Console.WriteLine("\n=== NILAI TERTINGGI ===");
Console.WriteLine($"{mahasiswaTerbaik.Nama}: {mahasiswaTerbaik.Nilai}");

// ========================================
// 7. Mencari mahasiswa dengan nilai terendah
// ========================================

var nilaiTerendah = mahasiswa.Min(x => x.Nilai);

var mahasiswaTerendah = mahasiswa
    .First(x => x.Nilai == nilaiTerendah);

Console.WriteLine("\n=== NILAI TERENDAH ===");
Console.WriteLine($"{mahasiswaTerendah.Nama}: {mahasiswaTerendah.Nilai}");

// ========================================
// 8. Menghitung jumlah mahasiswa
// ========================================

int jumlahMahasiswa = mahasiswa.Count();

Console.WriteLine($"\nJumlah mahasiswa: {jumlahMahasiswa}");

// ========================================
// 9. Menghitung jumlah mahasiswa lulus
// ========================================

int jumlahLulus = mahasiswa.Count(x => x.Nilai >= 60);

Console.WriteLine($"Jumlah mahasiswa lulus: {jumlahLulus}");

// ========================================
// 10. Menghitung rata-rata
// ========================================

double rataRata = mahasiswa
    .Average(x => x.Nilai);

Console.WriteLine($"Rata-rata nilai: {rataRata:F2}");

// ========================================
// 11. Mengecek nilai tertentu
// ========================================

int nilaiDicari = 90;

bool ditemukan = mahasiswa
    .Any(x => x.Nilai == nilaiDicari);

Console.WriteLine($"\nApakah ada nilai {nilaiDicari}? {ditemukan}");

// ========================================
// 12. Menampilkan hanya nama mahasiswa lulus
// ========================================

Console.WriteLine("\n=== NAMA MAHASISWA LULUS ===");

var namaLulus = mahasiswa
    .Where(x => x.Nilai >= 60)
    .Select(x => x.Nama);

foreach (string nama in namaLulus)
{
    Console.WriteLine(nama);
}

// ========================================
// Class Mahasiswa
// ========================================

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