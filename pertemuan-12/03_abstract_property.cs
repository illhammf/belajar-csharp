// Pertemuan 12 - Abstract Class dengan Property
// Abstract class dapat memiliki property biasa

Kucing kucing = new Kucing();

kucing.Nama = "Milo";

Console.WriteLine($"Nama: {kucing.Nama}");

kucing.Suara();

// Abstract class
abstract class Hewan
{
    // Property biasa
    public string Nama { get; set; } = "";

    // Abstract method
    public abstract void Suara();
}

// Class turunan
class Kucing : Hewan
{
    public override void Suara()
    {
        Console.WriteLine($"{Nama}: Meong!");
    }
}