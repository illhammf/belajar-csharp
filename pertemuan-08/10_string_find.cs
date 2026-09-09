// Membuat string
string kalimat = "Saya sedang belajar C#";

// Mencari posisi kata "belajar"
int posisi = kalimat.IndexOf("belajar");

// Menampilkan posisi
Console.WriteLine("Posisi kata 'belajar': " + posisi);

// Jika hasilnya -1 berarti tidak ditemukan
if (posisi != -1)
{
    Console.WriteLine("Kata ditemukan");
}
else
{
    Console.WriteLine("Kata tidak ditemukan");
}