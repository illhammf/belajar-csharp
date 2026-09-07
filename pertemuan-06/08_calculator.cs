using System;

class Program
{
    // Method untuk penjumlahan
    static int Tambah(int a, int b)
    {
        return a + b;
    }

    // Method untuk pengurangan
    static int Kurang(int a, int b)
    {
        return a - b;
    }

    // Method untuk perkalian
    static int Kali(int a, int b)
    {
        return a * b;
    }

    // Method untuk pembagian
    static double Bagi(int a, int b)
    {
        return (double)a / b;
    }

    static void Main()
    {
        int angka1 = 20;
        int angka2 = 5;

        Console.WriteLine($"Tambah : {Tambah(angka1, angka2)}");
        Console.WriteLine($"Kurang : {Kurang(angka1, angka2)}");
        Console.WriteLine($"Kali   : {Kali(angka1, angka2)}");
        Console.WriteLine($"Bagi   : {Bagi(angka1, angka2)}");
    }
}