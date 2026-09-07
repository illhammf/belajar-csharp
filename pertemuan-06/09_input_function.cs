using System;

class Program
{
    // Method menghitung luas persegi
    static int HitungLuasPersegi(int sisi)
    {
        return sisi * sisi;
    }

    static void Main()
    {
        // Meminta input dari user
        Console.Write("Masukkan sisi: ");
        int sisi = Convert.ToInt32(Console.ReadLine());

        // Mengirim input ke method
        int luas = HitungLuasPersegi(sisi);

        Console.WriteLine($"Luas persegi: {luas}");
    }
}