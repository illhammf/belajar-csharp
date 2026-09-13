// Membuat object Kucing
Kucing kucing = new Kucing();

// Memanggil method dari parent
kucing.Makan();

// Memanggil method milik child
kucing.Mengeong();


// ==========================================
// PARENT CLASS
// ==========================================

class Hewan
{
    // Method milik parent
    public void Makan()
    {
        Console.WriteLine("Hewan sedang makan");
    }
}


// ==========================================
// CHILD CLASS
// ==========================================

class Kucing : Hewan
{
    // Method khusus milik Kucing
    public void Mengeong()
    {
        Console.WriteLine("Meong!");
    }
}