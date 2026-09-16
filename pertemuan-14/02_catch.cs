// Pertemuan 14 - Exception Handling
// Contoh penggunaan try dan catch

Console.Write("Masukkan angka: ");

try
{
    // Mengambil input dari user
    int angka = int.Parse(Console.ReadLine() ?? "");

    Console.WriteLine($"Angka yang dimasukkan: {angka}");
}
catch
{
    // Dijalanakan jika terjadi error
    Console.WriteLine("Input harus berupa angka.");
}

Console.WriteLine("Program tetap berjalan.");