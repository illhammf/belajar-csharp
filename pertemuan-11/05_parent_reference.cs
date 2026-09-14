// Pertemuan 11 - Parent Reference
// Variable bertipe parent dapat menyimpan object dari child

Hewan hewan;

hewan = new Kucing();
hewan.Suara();

hewan = new Anjing();
hewan.Suara();

// Parent class
class Hewan
{
    public virtual void Suara()
    {
        Console.WriteLine("Suara hewan");
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

// Child class
class Anjing : Hewan
{
    public override void Suara()
    {
        Console.WriteLine("Anjing: Guk guk!");
    }
}