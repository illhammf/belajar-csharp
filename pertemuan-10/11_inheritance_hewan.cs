// Membuat object Kucing
Kucing kucing = new Kucing();

// Mengisi nama Kucing
kucing.Nama = "Milo";

// Membuat object Anjing
Anjing anjing = new Anjing();

// Mengisi nama Anjing
anjing.Nama = "Buddy";


// ==========================================
// MENJALANKAN KUCING
// ==========================================

kucing.Makan();
kucing.Mengeong();


// Memberikan jarak
Console.WriteLine();


// ==========================================
// MENJALANKAN ANJING
// ==========================================

anjing.Makan();
anjing.Menggonggong();


// ==========================================
// PARENT CLASS
// ==========================================

class Hewan
{
    // Property milik parent
    public string Nama { get; set; }

    // Method milik parent
    public void Makan()
    {
        Console.WriteLine(
            Nama + " sedang makan"
        );
    }
}


// ==========================================
// CHILD CLASS 1
// ==========================================

class Kucing : Hewan
{
    public void Mengeong()
    {
        Console.WriteLine(
            Nama + " berkata: Meong!"
        );
    }
}


// ==========================================
// CHILD CLASS 2
// ==========================================

class Anjing : Hewan
{
    public void Menggonggong()
    {
        Console.WriteLine(
            Nama + " berkata: Guk guk!"
        );
    }
}