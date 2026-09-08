using System;

class Program
{
    static void Main()
    {
        int[] angka = { 10, 20, 30, 40, 50 };

        Console.Write("Masukkan angka yang ingin dicari: ");
        int cari = Convert.ToInt32(Console.ReadLine());

        bool ditemukan = false;

        // Mencari data di dalam array
        for (int i = 0; i < angka.Length; i++)
        {
            if (angka[i] == cari)
            {
                ditemukan = true;

                // Hentikan looping karena data sudah ditemukan
                break;
            }
        }

        // Menampilkan hasil pencarian
        if (ditemukan)
        {
            Console.WriteLine("Data ditemukan!");
        }
        else
        {
            Console.WriteLine("Data tidak ditemukan.");
        }
    }
}