using System;

class Program
{
    // Method menerima parameter nama
    static void Sapa(string nama)
    {
        Console.WriteLine($"Halo, {nama}!");
    }

    static void Main()
    {
        // Mengirim nilai ke parameter nama
        Sapa("Ilham");
    }
}