// Pertemuan 14 - Exception Handling
// Menggunakan throw untuk membuat exception sendiri

Console.Write("Masukkan umur: ");

try
{
    int umur = int.Parse(Console.ReadLine() ?? "");

    // Validasi umur
    if (umur < 0)
    {
        // Membuat exception secara manual
        throw new Exception("Umur tidak boleh negatif.");
    }

    Console.WriteLine($"Umur: {umur}");
}
catch (Exception ex)
{
    // Menampilkan pesan dari exception
    Console.WriteLine($"Error: {ex.Message}");
}