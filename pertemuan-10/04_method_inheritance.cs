// Membuat object Mobil
Mobil mobil = new Mobil();

// Memanggil method dari parent class
mobil.NyalakanMesin();


// ==========================================
// PARENT CLASS
// ==========================================

class Kendaraan
{
    // Method milik parent
    public void NyalakanMesin()
    {
        Console.WriteLine("Mesin kendaraan menyala");
    }
}


// ==========================================
// CHILD CLASS
// ==========================================

class Mobil : Kendaraan
{
}