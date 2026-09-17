// Pertemuan 14 - Exception Handling
// Menangani IndexOutOfRangeException

int[] angka = { 10, 20, 30 };

try
{
    // Index array hanya tersedia dari 0 sampai 2
    Console.WriteLine($"Angka: {angka[5]}");
}
catch (IndexOutOfRangeException)
{
    // Menangani index yang berada di luar array
    Console.WriteLine("Index array berada di luar batas.");
}