using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            // Jika i sudah mencapai 5, hentikan looping
            if (i == 5)
            {
                break;
            }

            Console.WriteLine(i);
        }
    }
}