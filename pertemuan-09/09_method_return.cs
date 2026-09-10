// Membuat class Matematika
class Matematika
{
    // Method yang mengembalikan hasil
    public int Kuadrat(int angka)
    {
        // Mengembalikan hasil perkalian
        return angka * angka;
    }
}

// Membuat object
Matematika matematika = new Matematika();

// Memanggil method
int hasil = matematika.Kuadrat(5);

// Menampilkan hasil
Console.WriteLine("Hasil kuadrat: " + hasil);