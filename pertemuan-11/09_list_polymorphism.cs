// Pertemuan 11 - List Polymorphism
// List parent dapat menyimpan berbagai object child

using System.Collections.Generic;

List<Hewan> hewan = new List<Hewan>();

hewan.Add(new Kucing());
hewan.Add(new Anjing());
hewan.Add(new Burung());

foreach (Hewan item in hewan)
{
    item.Suara();
}

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

// Child class
class Burung : Hewan
{
    public override void Suara()
    {
        Console.WriteLine("Burung: Cuit cuit!");
    }
}