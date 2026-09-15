// Pertemuan 12 - Base pada Abstract Class
// base digunakan untuk memanggil constructor atau method parent

Kucing kucing = new Kucing("Milo");

kucing.TampilkanInfo();
kucing.Suara();

// Abstract class
abstract class Hewan
{
    public string Nama { get; set; }

    public Hewan(string nama)
    {
        Nama = nama;
    }

    public void TampilkanInfo()
    {
        Console.WriteLine($"Nama: {Nama}");
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