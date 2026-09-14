// Pertemuan 11 - Multiple Child
// Satu parent dapat memiliki banyak child

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

// Child 1
class Kucing : Hewan
{
    public override void Suara()
    {
        Console.WriteLine("Kucing: Meong!");
    }
}

// Child 2
class Anjing : Hewan
{
    public override void Suara()
    {
        Console.WriteLine("Anjing: Guk guk!");
    }
}

// Child 3
class Burung : Hewan
{
    public override void Suara()
    {
        Console.WriteLine("Burung: Cuit cuit!");
    }
}