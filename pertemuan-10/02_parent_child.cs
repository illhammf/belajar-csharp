// Membuat object Mobil
Mobil mobil = new Mobil();

// Mengisi property yang diwariskan
mobil.Merk = "Toyota";

// Memanggil method yang diwariskan
mobil.Bergerak();


// ==========================================
// PARENT CLASS
// ==========================================

class Kendaraan
{
    // Property milik parent
    public string Merk { get; set; }

    // Method milik parent
    public void Bergerak()
    {
        Console.WriteLine(Merk + " sedang bergerak");
    }
}


// ==========================================
// CHILD CLASS
// ==========================================

class Mobil : Kendaraan
{
}