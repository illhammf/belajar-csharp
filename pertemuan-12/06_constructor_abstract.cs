// Pertemuan 12 - Constructor pada Abstract Class
// Abstract class tetap dapat memiliki constructor

Kucing kucing = new Kucing("Milo");

kucing.TampilkanNama();
kucing.Suara();

// Abstract class
abstract class Hewan
{
    public string Nama { get; set; }

    // Constructor abstract class
    public Hewan(string nama)
    {
        Nama = nama;
    }

    public void TampilkanNama()
    {
        Console.WriteLine($"Nama hewan: {Nama}");
    }

    public abstract void Suara();
}

// Child class
class Kucing : Hewan
{
    public Kucing(string nama) : base(nama)
    {
    }

    public override void Suara()
    {
        Console.WriteLine($"{Nama}: Meong!");
    }
}