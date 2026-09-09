// Membuat string
string teks = "belajar";

// Karakter yang ingin dicari
char target = 'a';

// Variabel untuk menghitung jumlah karakter
int jumlah = 0;

// Melakukan perulangan setiap karakter
for (int i = 0; i < teks.Length; i++)
{
    // Mengecek apakah karakter sama dengan target
    if (teks[i] == target)
    {
        jumlah++;
    }
}

// Menampilkan hasil
Console.WriteLine("Teks: " + teks);
Console.WriteLine("Karakter '" + target + "' muncul: " + jumlah + " kali");