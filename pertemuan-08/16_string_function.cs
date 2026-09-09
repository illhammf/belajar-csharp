// Function untuk menghitung jumlah karakter
static int HitungKarakter(string teks)
{
    // Mengembalikan panjang string
    return teks.Length;
}

// Function untuk mengubah string menjadi huruf besar
static string HurufBesar(string teks)
{
    return teks.ToUpper();
}

// Program utama
string nama = "Ilham";

// Memanggil function
int jumlah = HitungKarakter(nama);
string hasil = HurufBesar(nama);

// Menampilkan hasil
Console.WriteLine("Nama: " + nama);
Console.WriteLine("Jumlah karakter: " + jumlah);
Console.WriteLine("Huruf besar: " + hasil);