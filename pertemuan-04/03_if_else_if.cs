using System;

class Program
{
    static void Main()
    {
        int nilai = 85;

        // Mengecek kondisi dari atas ke bawah
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