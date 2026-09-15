// Pertemuan 12 - Studi Kasus Kendaraan
// Setiap kendaraan memiliki cara bergerak yang berbeda

Kendaraan[] kendaraan =
{
    new Mobil("Toyota"),
    new Motor("Honda"),
    new Sepeda("Polygon")
};

foreach (Kendaraan item in kendaraan)
{
    item.TampilkanNama();
    item.Bergerak();

    Console.WriteLine();
}

// Abstract class
abstract class Kendaraan
{
    public string Nama { get; set; }

    public Kendaraan(string nama)
    {
        Nama = nama;
    }

    public void TampilkanNama()
    {
        Console.WriteLine($"Kendaraan: {Nama}");
    }

    // Setiap child wajib menentukan cara bergeraknya
    public abstract void Bergerak();
}

// Mobil
class Mobil : Kendaraan
{
    public Mobil(string nama) : base(nama)
    {
    }

    public override void Bergerak()
    {
        Console.WriteLine("Mobil bergerak menggunakan mesin");
    }
}

// Motor
class Motor : Kendaraan
{
    public Motor(string nama) : base(nama)
    {
    }

    public override void Bergerak()
    {
        Console.WriteLine("Motor bergerak menggunakan mesin");
    }
}

// Sepeda
class Sepeda : Kendaraan
{
    public Sepeda(string nama) : base(nama)
    {
    }

    public override void Bergerak()
    {
        Console.WriteLine("Sepeda bergerak dengan dikayuh");
    }
}