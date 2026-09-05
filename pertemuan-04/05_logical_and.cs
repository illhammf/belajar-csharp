using System;

class Program
{
    static void Main()
    {
        int umur = 20;
        bool memilikiKtp = true;

        // Operator && berarti kedua kondisi harus benar
        if (umur >= 17 && memilikiKtp)
        {
            Console.WriteLine("Syarat terpenuhi");
        }
        else
        {
            Console.WriteLine("Syarat tidak terpenuhi");
        }
    }
}