// Pertemuan 12 - Studi Kasus Hewan
// Menggunakan abstract class untuk berbagai jenis hewan

Hewan[] hewan =
{
    new Kucing("Milo"),
    new Anjing("Buddy"),
    new Burung("Rio")
};

foreach (Hewan item in hewan)
{
    item.TampilkanNama();
    item.Suara();

    Console.WriteLine();
}

// Abstract class
abstract class Hewan
{
    public string Nama { get; set; }

    public Hewan(string nama)
    {
        Nama = nama;
    }

    public void TampilkanNama()
    {
        Console.WriteLine($"Nama: {Nama}");
    }

    public abstract void Suara();
}

// Kucing
class Kucing : Hewan
{
    public Kucing(string nama) : base(nama)
    {
    }

    public override void Suara()
    {
        Console.WriteLine("Suara: Meong!");
    }
}

// Anjing
class Anjing : Hewan
{
    public Anjing(string nama) : base(nama)
    {
    }

    public override void Suara()
    {
        Console.WriteLine("Suara: Guk guk!");
    }
}

// Burung
class Burung : Hewan
{
    public Burung(string nama) : base(nama)
    {
    }

    public override void Suara()
    {
        Console.WriteLine("Suara: Cuit cuit!");
    }
}