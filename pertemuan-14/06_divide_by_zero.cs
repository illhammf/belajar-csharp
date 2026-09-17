// Pertemuan 14 - Exception Handling
// Menangani DivideByZeroException

try
{
    int angka = 10;

    // Menggunakan variabel agar pembagian terjadi saat program berjalan
    int pembagi = 0;

    int hasil = angka / pembagi;

    Console.WriteLine($"Hasil: {hasil}");
}
catch (DivideByZeroException)
{
    // Menangani pembagian dengan angka 0
    Console.WriteLine("Tidak bisa membagi angka dengan 0.");
}