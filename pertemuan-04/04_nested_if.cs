using System;

class Program
{
    static void Main()
    {
        int umur = 20;
        bool memilikiKtp = true;

        // Mengecek umur terlebih dahulu
        if (umur >= 17)
        {
            // Jika umur memenuhi, cek kondisi berikutnya
            if (memilikiKtp)
            {
                Console.WriteLine("Syarat terpenuhi");
            }
        }
    }
}