// Pertemuan 14 - Exception Handling
// Mengenal object Exception

try
{
    Console.Write("Masukkan angka: ");

    int angka = int.Parse(Console.ReadLine() ?? "");

    Console.WriteLine($"Angka: {angka}");
}
catch (Exception ex)
{
    // ex berisi informasi tentang error
    Console.WriteLine("Terjadi error.");
    Console.WriteLine($"Pesan error: {ex.Message}");
}