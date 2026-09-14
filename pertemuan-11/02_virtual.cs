// Pertemuan 11 - Virtual
// virtual memungkinkan method diubah oleh child class

Hewan hewan = new Kucing();

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