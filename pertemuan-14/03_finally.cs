// Pertemuan 14 - Exception Handling
// Contoh penggunaan finally

Console.Write("Masukkan angka: ");

try
{
    int angka = int.Parse(Console.ReadLine() ?? "");

    Console.WriteLine($"Angka: {angka}");
}
catch
{
    Console.WriteLine("Input tidak valid.");
}
finally
{
    // finally selalu dijalankan
    Console.WriteLine("Blok finally dijalankan.");
}

Console.WriteLine("Program selesai.");