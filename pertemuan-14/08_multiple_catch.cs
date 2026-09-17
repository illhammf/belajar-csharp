// Pertemuan 14 - Exception Handling
// Menggunakan beberapa catch

Console.Write("Masukkan angka: ");

try
{
    int angka = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Masukkan pembagi: ");
    int pembagi = int.Parse(Console.ReadLine() ?? "");

    int hasil = angka / pembagi;

    Console.WriteLine($"Hasil: {hasil}");
}
catch (FormatException)
{
    // Menangani input bukan angka
    Console.WriteLine("Input harus berupa angka.");
}
catch (DivideByZeroException)
{
    // Menangani pembagian dengan 0
    Console.WriteLine("Pembagi tidak boleh 0.");
}