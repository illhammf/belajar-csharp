// Pertemuan 14 - Exception Handling
// Studi kasus: Sistem Data Mahasiswa

class Mahasiswa
{
    public string Nama { get; set; }
    public int Nilai { get; set; }

    public Mahasiswa(string nama, int nilai)
    {
        Nama = nama;
        Nilai = nilai;
    }

    public void TampilkanData()
    {
        Console.WriteLine("\n=== Data Mahasiswa ===");
        Console.WriteLine($"Nama  : {Nama}");
        Console.WriteLine($"Nilai : {Nilai}");

        if (Nilai >= 60)
        {
            Console.WriteLine("Status: Lulus");
        }
        else
        {
            Console.WriteLine("Status: Tidak Lulus");
        }
    }
}

// Program utama
Console.WriteLine("=== Input Data Mahasiswa ===");

try
{
    // Input nama
    Console.Write("Nama mahasiswa: ");
    string nama = Console.ReadLine() ?? "";

    // Validasi nama
    if (string.IsNullOrWhiteSpace(nama))
    {
        throw new Exception("Nama tidak boleh kosong.");
    }

    // Input nilai
    Console.Write("Nilai mahasiswa: ");
    int nilai = int.Parse(Console.ReadLine() ?? "");

    // Validasi nilai
    if (nilai < 0 || nilai > 100)
    {
        throw new Exception("Nilai harus berada di antara 0 sampai 100.");
    }

    // Membuat object mahasiswa
    var mahasiswa = new Mahasiswa(nama, nilai);

    // Menampilkan data
    mahasiswa.TampilkanData();
}
catch (FormatException)
{
    // Jika nilai bukan angka
    Console.WriteLine("Nilai harus berupa angka.");
}
catch (Exception ex)
{
    // Menangani error lainnya
    Console.WriteLine($"Error: {ex.Message}");
}
finally
{
    // Selalu dijalankan
    Console.WriteLine("\nProgram selesai.");
}