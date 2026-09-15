// Pertemuan 12 - Array dengan Abstract Class
// Array bertipe parent dapat menyimpan object child

Hewan[] hewan =
{
    new Kucing(),
    new Anjing(),
    new Burung()
};

// Menjalankan method masing-masing object
foreach (Hewan item in hewan)
{
    item.Suara();
}

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

// Child class
class Burung : Hewan
{
    public override void Suara()
    {
        Console.WriteLine("Burung: Cuit cuit!");
    }
}