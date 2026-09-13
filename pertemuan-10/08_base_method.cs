// Membuat object Kucing
Kucing kucing = new Kucing();

// Mengisi nama
kucing.Nama = "Milo";

// Memanggil method milik child
kucing.TampilkanData();


// ==========================================
// PARENT CLASS
// ==========================================

class Hewan
{
    // Property nama
    public string Nama { get; set; }

    // Method parent
    public void Perkenalan()
    {
        Console.WriteLine(
            "Nama hewan: " + Nama
        );
    }
}


// ==========================================
// CHILD CLASS
// ==========================================

class Kucing : Hewan
{
    // Method milik child
    public void TampilkanData()
    {
        // Memanggil method parent
        // menggunakan keyword base
        base.Perkenalan();

        // Method tambahan milik child
        Console.WriteLine("Jenis: Kucing");
    }
}