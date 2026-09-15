// Pertemuan 12 - Abstract Class
// Contoh dasar abstract class

// Membuat object dari class turunan
Kucing kucing = new Kucing();

kucing.Suara();

// Abstract class
abstract class Hewan
{
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