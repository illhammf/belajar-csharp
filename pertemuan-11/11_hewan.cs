// Pertemuan 11 - Polymorphism Hewan
// Setiap hewan memiliki suara yang berbeda

Hewan[] hewan =
{
    new Kucing(),
    new Anjing(),
    new Sapi()
};

foreach (Hewan item in hewan)
{
    item.Suara();
}

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

// Child class
class Anjing : Hewan
{
    public override void Suara()
    {
        Console.WriteLine("Anjing: Guk guk!");
    }
}

// Child class
class Sapi : Hewan
{
    public override void Suara()
    {
        Console.WriteLine("Sapi: Moo!");
    }
}