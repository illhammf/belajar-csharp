using System;

class Program
{
    static void Main()
    {
        // Meminta user memasukkan angka
        Console.Write("Masukkan angka: ");
        int angka = Convert.ToInt32(Console.ReadLine());

        // Menampilkan perkalian dari 1 sampai 10
        for (int i = 1; i <= 10; i++)
        {
            int hasil = angka * i;

            Console.WriteLine($"{angka} x {i} = {hasil}");
        }
    }
}