using System;

class Program
{
    static void Main()
    {
        bool sudahLogin = false;

        // Operator ! digunakan untuk membalik nilai boolean
        // false menjadi true
        if (!sudahLogin)
        {
            Console.WriteLine("Silakan login terlebih dahulu");
        }
        else
        {
            Console.WriteLine("Selamat datang!");
        }
    }
}