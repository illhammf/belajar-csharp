// Pertemuan 14 - Exception Handling
// Gabungan try, catch, dan finally

Console.Write("Masukkan angka: ");

try
{
    int angka = int.Parse(Console.ReadLine() ?? "");

    Console.WriteLine($"Angka yang dimasukkan: {angka}");
}
catch (FormatException)
{
    // Dijalanakan jika input bukan angka
    Console.WriteLine("Input harus berupa angka.");
}
finally
{
    // Selalu dijalankan
    Console.WriteLine("Proses input selesai.");
}