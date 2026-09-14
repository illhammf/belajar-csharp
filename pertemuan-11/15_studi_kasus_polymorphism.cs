// Pertemuan 11 - Studi Kasus Polymorphism
// Studi kasus: sistem kendaraan

Kendaraan[] kendaraan =
{
    new Mobil("Toyota"),
    new Motor("Honda"),
    new Sepeda("Polygon")
};

foreach (Kendaraan item in kendaraan)
{
    item.TampilkanInfo();
    item.Bergerak();

    Console.WriteLine();
}

// Parent class
class Kendaraan
{
    public string Nama { get; set; }

    public Kendaraan(string nama)
    {
        Nama = nama;
    }

    public virtual void TampilkanInfo()
    {
        Console.WriteLine($"Kendaraan: {Nama}");
    }

    public virtual void Bergerak()
    {
        Console.WriteLine("Kendaraan bergerak");
    }
}

// Child class
class Mobil : Kendaraan
{
    public Mobil(string nama) : base(nama)
    {
    }

    public override void TampilkanInfo()
    {
        Console.WriteLine($"Jenis: Mobil | Nama: {Nama}");
    }

    public override void Bergerak()
    {
        Console.WriteLine("Mobil berjalan menggunakan mesin");
    }
}

// Child class
class Motor : Kendaraan
{
    public Motor(string nama) : base(nama)
    {
    }

    public override void TampilkanInfo()
    {
        Console.WriteLine($"Jenis: Motor | Nama: {Nama}");
    }

    public override void Bergerak()
    {
        Console.WriteLine("Motor berjalan menggunakan mesin");
    }
}

// Child class
class Sepeda : Kendaraan
{
    public Sepeda(string nama) : base(nama)
    {
    }

    public override void TampilkanInfo()
    {
        Console.WriteLine($"Jenis: Sepeda | Nama: {Nama}");
    }

    public override void Bergerak()
    {
        Console.WriteLine("Sepeda bergerak dengan dikayuh");
    }
}