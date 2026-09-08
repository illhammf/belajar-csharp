using System;

class Program
{
    static void Main()
    {
        int[] angka = { 10, 50, 30, 90, 20 };

        // Menggunakan elemen pertama sebagai nilai terbesar sementara
        int terbesar = angka[0];

        // Mulai dari index 1 karena index 0 sudah digunakan
        for (int i = 1; i < angka.Length; i++)
        {
            // Jika ditemukan angka yang lebih besar
            if (angka[i] > terbesar)
            {
                terbesar = angka[i];
            }
        }

        Console.WriteLine($"Nilai terbesar: {terbesar}");
    }
}