// Pertemuan 12 - Abstract Method
// Abstract method tidak memiliki isi di parent class
// Class turunan wajib memberikan implementasi

Kucing kucing = new Kucing();
Anjing anjing = new Anjing();

kucing.Suara();
anjing.Suara();

// Abstract class
abstract class Hewan
{
    // Abstract method
    public abstract void Suara();
}

// Class turunan
class Kucing : Hewan
{
    public override void Suara()
    {
        Console.WriteLine("Kucing: Meong!");
    }
}

// Class turunan
class Anjing : Hewan
{
    public override void Suara()
    {
        Console.WriteLine("Anjing: Guk guk!");
    }
}