// Membuat object Kucing
Kucing kucing = new Kucing("Milo");

// Menampilkan nama
Console.WriteLine("Nama: " + kucing.Nama);


// ==========================================
// PARENT CLASS
// ==========================================

class Hewan
{
    // Property nama
    public string Nama { get; set; }

    // Constructor parent
    public Hewan(string nama)
    {
        Nama = nama;

        Console.WriteLine(
            "Constructor Hewan dijalankan"
        );
    }
}


// ==========================================
// CHILD CLASS
// ==========================================

class Kucing : Hewan
{
    // Constructor child
    // base(nama) memanggil constructor parent
    public Kucing(string nama) : base(nama)
    {
        Console.WriteLine(
            "Constructor Kucing dijalankan"
        );
    }
}