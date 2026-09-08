using System;

class Program
{
    static void Main()
    {
        int[] angka = { 10, 50, 30, 90, 20 };

        // Menggunakan elemen pertama sebagai nilai terkecil sementara
        int terkecil = angka[0];

        // Mengecek elemen berikutnya
        for (int i = 1; i < angka.Length; i++)
        {
            // Jika ditemukan angka yang lebih kecil
            if (angka[i] < terkecil)
            {
                terkecil = angka[i];
            }
        }

        Console.WriteLine($"Nilai terkecil: {terkecil}");
    }
}