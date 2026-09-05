using System;

class Program
{
    static void Main()
    {
        int nilai = 80;

        // Ternary adalah bentuk singkat dari if else
        string status = nilai >= 75 ? "Lulus" : "Tidak Lulus";

        Console.WriteLine($"Status: {status}");
    }
}