// Pertemuan 11 - Override
// override digunakan untuk mengganti perilaku method dari parent

Hewan hewan = new Anjing();

hewan.Suara();

// Parent
class Hewan
{
    public virtual void Suara()
    {
        Console.WriteLine("Hewan bersuara");
    }
}

// Child
class Anjing : Hewan
{
    public override void Suara()
    {
        Console.WriteLine("Anjing: Guk guk!");
    }
}