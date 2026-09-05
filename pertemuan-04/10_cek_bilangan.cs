using System;

class Program
{
    static void Main()
    {
        Console.Write("Masukkan sebuah bilangan: ");
        int angka = Convert.ToInt32(Console.ReadLine());

        // Mengecek apakah angka positif
        if (angka > 0)
        {
            Console.WriteLine("Bilangan positif");
        }
        // Mengecek apakah angka negatif
        else if (angka < 0)
        {
            Console.WriteLine("Bilangan negatif");
        }
        // Jika bukan positif atau negatif, berarti nol
        else
        {
            Console.WriteLine("Bilangan nol");
        }
    }
}