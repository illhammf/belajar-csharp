// ==========================================
// Prefix & Postfix
// ==========================================

// ==========================================
// PREFIX
// ==========================================

int angkaPrefix = 10;

// ++ diletakkan SEBELUM variabel
// Nilai dinaikkan terlebih dahulu
int hasilPrefix = ++angkaPrefix;

Console.WriteLine("PREFIX");
Console.WriteLine($"Angka : {angkaPrefix}");
Console.WriteLine($"Hasil : {hasilPrefix}");


// ==========================================
// POSTFIX
// ==========================================

int angkaPostfix = 10;

// ++ diletakkan SETELAH variabel
// Nilai lama digunakan terlebih dahulu
int hasilPostfix = angkaPostfix++;

Console.WriteLine();
Console.WriteLine("POSTFIX");
Console.WriteLine($"Angka : {angkaPostfix}");
Console.WriteLine($"Hasil : {hasilPostfix}");