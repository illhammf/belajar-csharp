// Membuat object Kucing
Kucing kucing = new Kucing();

// Mengisi jenis melalui method parent
kucing.SetJenis("Kucing domestik");

// Menampilkan jenis
kucing.TampilkanJenis();


// ==========================================
// PARENT CLASS
// ==========================================

class Hewan
{
    // protected hanya dapat diakses oleh
    // class ini dan child class
    protected string jenis;

    // Method untuk mengisi jenis
    public void SetJenis(string jenis)
    {
        this.jenis = jenis;
    }
}


// ==========================================
// CHILD CLASS
// ==========================================

class Kucing : Hewan
{
    // Child class dapat mengakses
    // member protected dari parent
    public void TampilkanJenis()
    {
        Console.WriteLine(
            "Jenis: " + jenis
        );
    }
}