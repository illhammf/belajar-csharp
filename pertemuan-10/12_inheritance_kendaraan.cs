// Membuat object Mobil
Mobil mobil = new Mobil();

// Mengisi data Mobil
mobil.Merk = "Toyota";

// Memanggil method Mobil
mobil.Bergerak();
mobil.Klakson();


// Memberikan jarak
Console.WriteLine();


// Membuat object Motor
Motor motor = new Motor();

// Mengisi data Motor
motor.Merk = "Honda";

// Memanggil method Motor
motor.Bergerak();
motor.BunyiMesin();


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
        Console.WriteLine(
            Merk + " sedang bergerak"
        );
    }
}


// ==========================================
// CHILD CLASS - MOBIL
// ==========================================

class Mobil : Kendaraan
{
    // Method khusus Mobil
    public void Klakson()
    {
        Console.WriteLine("Tin tin!");
    }
}


// ==========================================
// CHILD CLASS - MOTOR
// ==========================================

class Motor : Kendaraan
{
    // Method khusus Motor
    public void BunyiMesin()
    {
        Console.WriteLine(
            "Brumm brumm!"
        );
    }
}