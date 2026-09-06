using System;

class Program
{
    static void Main()
    {
        // Menampilkan angka genap dari 1 sampai 10
        for (int i = 1; i <= 10; i++)
        {
            // Jika sisa pembagian dengan 2 adalah 0,
            // berarti angka tersebut genap
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}