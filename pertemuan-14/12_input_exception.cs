// Pertemuan 14 - Exception Handling
// Exception Handling pada input user

Console.Write("Masukkan nilai: ");

try
{
    int nilai = int.Parse(Console.ReadLine() ?? "");

    // Mengecek rentang nilai
    if (nilai < 0 || nilai > 100)
    {
        throw new Exception("Nilai harus berada di antara 0 sampai 100.");
    }

    Console.WriteLine($"Nilai kamu: {nilai}");
}
catch (FormatException)
{
    // Menangani input bukan angka
    Console.WriteLine("Input harus berupa angka.");
}
catch (Exception ex)
{
    // Menangani error validasi
    Console.WriteLine($"Error: {ex.Message}");
}