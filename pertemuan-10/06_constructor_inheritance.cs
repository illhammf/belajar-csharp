// Membuat object Kucing
Kucing kucing = new Kucing();


// ==========================================
// PARENT CLASS
// ==========================================

class Hewan
{
    // Property milik parent
    public string Nama { get; set; }

    // Constructor parent
    public Hewan()
    {
        Console.WriteLine("Constructor Hewan dijalankan");
    }
}


// ==========================================
// CHILD CLASS
// ==========================================

class Kucing : Hewan
{
    // Constructor child
    public Kucing()
    {
        Console.WriteLine("Constructor Kucing dijalankan");
    }
}