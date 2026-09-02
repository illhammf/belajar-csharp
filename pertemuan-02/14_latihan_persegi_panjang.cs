// ========================================
// Program Menghitung Luas Persegi Panjang
// ========================================

// Meminta panjang
Console.Write("Masukkan panjang: ");
double panjang = double.Parse(Console.ReadLine());

// Meminta lebar
Console.Write("Masukkan lebar: ");
double lebar = double.Parse(Console.ReadLine());

// Menghitung luas
double luas = panjang * lebar;

// Menampilkan hasil
Console.WriteLine();
Console.WriteLine($"Panjang : {panjang}");
Console.WriteLine($"Lebar   : {lebar}");
Console.WriteLine($"Luas    : {luas}");