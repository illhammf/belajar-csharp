using System;

class Program
{
    // Mengecek apakah angka merupakan bilangan genap
    static bool IsGenap(int angka)
    {
        return angka % 2 == 0;
    }

    static void Main()
    {
        // Meminta input dari user
        Console.Write("Masukkan angka: ");
        int angka = Convert.ToInt32(Console.ReadLine());

        // Mengecek hasil dari method
        if (IsGenap(angka))
        {
            Console.WriteLine("Bilangan genap");
        }
        else
        {
            Console.WriteLine("Bilangan ganjil");
        }
    }
}