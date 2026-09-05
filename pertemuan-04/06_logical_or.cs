using System;

class Program
{
    static void Main()
    {
        string hari = "Sabtu";

        // Operator || berarti minimal salah satu kondisi harus benar
        if (hari == "Sabtu" || hari == "Minggu")
        {
            Console.WriteLine("Hari libur");
        }
        else
        {
            Console.WriteLine("Hari kerja");
        }
    }
}