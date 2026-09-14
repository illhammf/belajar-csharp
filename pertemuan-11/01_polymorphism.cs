// Pertemuan 11 - Polymorphism
// Contoh dasar polymorphism

Hewan hewan = new Kucing();

hewan.Suara();

// Parent class
class Hewan
{
    public virtual void Suara()
    {
        Console.WriteLine("Hewan mengeluarkan suara");
    }
}

// Child class
class Kucing : Hewan
{
    public override void Suara()
    {
        Console.WriteLine("Kucing: Meong!");
    }
}