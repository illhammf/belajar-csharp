// Parent class
class Hewan
{
    // Property milik parent class
    public string Nama { get; set; }

    // Method milik parent class
    public void Makan()
    {
        Console.WriteLine(Nama + " sedang makan");
    }
}

// Child class mewarisi Hewan
class Kucing : Hewan
{
}

// Membuat object Kucing
Kucing kucing = new Kucing();

// Menggunakan property dari parent class
kucing.Nama = "Milo";

// Menggunakan method dari parent class
kucing.Makan();