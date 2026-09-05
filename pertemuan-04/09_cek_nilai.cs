using System;

class Program
{
    static void Main()
    {
        // Meminta user memasukkan nilai
        Console.Write("Masukkan nilai: ");
        int nilai = Convert.ToInt32(Console.ReadLine());

        // Mengecek nilai yang dimasukkan
        if (nilai >= 90)
        {
            Console.WriteLine("Grade A");
        }
        else if (nilai >= 80)
        {
            Console.WriteLine("Grade B");
        }
        else if (nilai >= 70)
        {
            Console.WriteLine("Grade C");
        }
        else
        {
            Console.WriteLine("Grade D");
        }
    }
}