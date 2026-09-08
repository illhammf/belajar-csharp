using System;

class Program
{
    // Method menghitung total semua elemen array
    static int HitungTotal(int[] angka)
    {
        int total = 0;

        // Menjumlahkan semua data
        for (int i = 0; i < angka.Length; i++)
        {
            total += angka[i];
        }

        // Mengembalikan hasil total
        return total;
    }

    static void Main()
    {
        int[] data = { 10, 20, 30, 40, 50 };

        // Memanggil method dan menyimpan hasilnya
        int total = HitungTotal(data);

        Console.WriteLine($"Total: {total}");
    }
}