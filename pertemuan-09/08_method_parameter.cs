// Membuat class Kalkulator
class Kalkulator
{
    // Method dengan dua parameter
    public void Tambah(int angka1, int angka2)
    {
        // Menghitung hasil
        int hasil = angka1 + angka2;

        // Menampilkan hasil
        Console.WriteLine("Hasil: " + hasil);
    }
}

// Membuat object
Kalkulator kalkulator = new Kalkulator();

// Memanggil method dan memberikan argument
kalkulator.Tambah(10, 20);