// Membuat class Matematika
class Matematika
{
    // Method static dimiliki oleh class
    // Tidak perlu membuat object
    public static int Tambah(int angka1, int angka2)
    {
        return angka1 + angka2;
    }

    // Method static lainnya
    public static int Kali(int angka1, int angka2)
    {
        return angka1 * angka2;
    }
}

// Memanggil method static langsung melalui nama class
int hasilTambah = Matematika.Tambah(10, 20);
int hasilKali = Matematika.Kali(5, 4);

// Menampilkan hasil
Console.WriteLine("Hasil tambah : " + hasilTambah);
Console.WriteLine("Hasil kali   : " + hasilKali);