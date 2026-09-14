// Pertemuan 11 - Array Polymorphism
// Array parent dapat menyimpan object dari berbagai child class

Hewan[] hewan =
{
    new Kucing(),
    new Anjing(),
    new Burung()
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