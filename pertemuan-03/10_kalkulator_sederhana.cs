// ==========================================
// KALKULATOR SEDERHANA
// ==========================================

Console.WriteLine("==============================");
Console.WriteLine("      KALKULATOR C#");
Console.WriteLine("==============================");

// Meminta input angka pertama
Console.Write("Masukkan angka pertama : ");
double angkaA = Convert.ToDouble(Console.ReadLine());

// Meminta operator
Console.Write("Masukkan operator (+ - * / %) : ");
string? operasi = Console.ReadLine();

// Meminta input angka kedua
Console.Write("Masukkan angka kedua   : ");
double angkaB = Convert.ToDouble(Console.ReadLine());

double hasil = 0;

// Mengecek operator yang dimasukkan
if (operasi == "+")
{
    hasil = angkaA + angkaB;
}
else if (operasi == "-")
{
    hasil = angkaA - angkaB;
}
else if (operasi == "*")
{
    hasil = angkaA * angkaB;
}
else if (operasi == "/")
{
    // Mengecek agar tidak melakukan pembagian dengan 0
    if (angkaB != 0)
    {
        hasil = angkaA / angkaB;
    }
    else
    {
        Console.WriteLine("Tidak bisa membagi dengan 0.");
        return;
    }
}
else if (operasi == "%")
{
    hasil = angkaA % angkaB;
}
else
{
    // Jika operator tidak dikenal
    Console.WriteLine("Operator tidak valid.");
    return;
}

// Menampilkan hasil
Console.WriteLine();
Console.WriteLine($"Hasil : {hasil}");