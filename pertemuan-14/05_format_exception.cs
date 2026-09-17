// Pertemuan 14 - Exception Handling
// Menangani FormatException

Console.Write("Masukkan umur: ");

try
{
    // Jika input bukan angka, akan menghasilkan FormatException
    int umur = int.Parse(Console.ReadLine() ?? "");

    Console.WriteLine($"Umur kamu: {umur}");
}
catch (FormatException)
{
    // Menangani input dengan format yang salah
    Console.WriteLine("Input harus berupa angka.");
}