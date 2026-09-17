// Pertemuan 14 - Exception Handling
// Mengambil informasi dari Exception

try
{
    Console.Write("Masukkan angka: ");

    int angka = int.Parse(Console.ReadLine() ?? "");

    Console.WriteLine($"Angka: {angka}");
}
catch (Exception ex)
{
    // Menampilkan jenis error
    Console.WriteLine($"Jenis error: {ex.GetType().Name}");

    // Menampilkan pesan error
    Console.WriteLine($"Pesan: {ex.Message}");
}