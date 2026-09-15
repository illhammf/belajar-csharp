// Pertemuan 12 - Abstract dan Override
// Abstract method diimplementasikan menggunakan override

Hewan hewan1 = new Kucing();
Hewan hewan2 = new Anjing();

hewan1.Suara();
hewan2.Suara();

// Abstract class
abstract class Hewan
{
    // Method ini wajib diimplementasikan oleh child
    public abstract void Suara();
}

// Child class
class Kucing : Hewan
{
    public override void Suara()
    {
        Console.WriteLine("Kucing mengeluarkan suara: Meong!");
    }
}

// Child class
class Anjing : Hewan
{
    public override void Suara()
    {
        Console.WriteLine("Anjing mengeluarkan suara: Guk guk!");
    }
}