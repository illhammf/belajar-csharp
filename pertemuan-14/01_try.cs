// Pertemuan 14 - Exception Handling
// Contoh dasar penggunaan try

Console.WriteLine("Program dimulai.");

try
{
    // Kode yang berpotensi menghasilkan error
    int angka = 10;
    int hasil = angka / 2;

    Console.WriteLine($"Hasil: {hasil}");
}
catch (Exception ex)
{
    Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
}

Console.WriteLine("Program selesai.");