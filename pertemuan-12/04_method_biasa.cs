// Pertemuan 12 - Method Biasa dalam Abstract Class
// Abstract class dapat memiliki method biasa
// Selain abstract method

Kucing kucing = new Kucing();

kucing.Nama = "Milo";

kucing.Makan();
kucing.Suara();

// Abstract class
abstract class Hewan
{
    public string Nama { get; set; } = "";

    // Method biasa
    public void Makan()
    {
        Console.WriteLine($"{Nama} sedang makan");
    }

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