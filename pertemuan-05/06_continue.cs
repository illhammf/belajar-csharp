using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            // Jika i bernilai 3, lewati iterasi ini
            if (i == 3)
            {
                continue;
            }

            Console.WriteLine(i);
        }
    }
}