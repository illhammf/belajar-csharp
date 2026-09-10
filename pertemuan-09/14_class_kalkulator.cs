// Membuat class Kalkulator
class Kalkulator
{
    // Method penjumlahan
    public double Tambah(double a, double b)
    {
        return a + b;
    }

    // Method pengurangan
    public double Kurang(double a, double b)
    {
        return a - b;
    }

    // Method perkalian
    public double Kali(double a, double b)
    {
        return a * b;
    }

    // Method pembagian
    public double Bagi(double a, double b)
    {
        return a / b;
    }
}

// Membuat object kalkulator
Kalkulator kalkulator = new Kalkulator();

// Memanggil setiap method
Console.WriteLine("Tambah : " + kalkulator.Tambah(10, 5));
Console.WriteLine("Kurang : " + kalkulator.Kurang(10, 5));
Console.WriteLine("Kali   : " + kalkulator.Kali(10, 5));
Console.WriteLine("Bagi   : " + kalkulator.Bagi(10, 5));