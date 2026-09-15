// Pertemuan 12 - Polymorphism dengan Abstract Class
// Abstract class dapat digunakan sebagai reference
// untuk object dari class turunannya

Hewan hewan;

hewan = new Kucing();
hewan.Suara();

hewan = new Anjing();
hewan.Suara();

// Abstract class
abstract class Hewan
{
    public abstract void Suara();
}

// Child class
class Kucing : Hewan
{
    public override void Suara()
    {
        Console.WriteLine("Kucing: Meong!");
    }
}

// Child class
class Anjing : Hewan
{
    public override void Suara()
    {
        Console.WriteLine("Anjing: Guk guk!");
    }
}