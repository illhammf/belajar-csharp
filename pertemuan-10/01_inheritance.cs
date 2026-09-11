// Membuat object Kucing
Kucing kucing = new Kucing();

// Mengisi property dari parent class
kucing.Nama = "Milo";

// Memanggil method dari parent class
kucing.Makan();


// ==========================================
// PARENT CLASS
// ==========================================

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


// ==========================================
// CHILD CLASS
// ==========================================

class Kucing : Hewan
{
}