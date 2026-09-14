// Pertemuan 11 - Polymorphism Kendaraan
// Setiap kendaraan memiliki cara bergerak yang berbeda

Kendaraan[] kendaraan =
{
    new Mobil(),
    new Motor(),
    new Sepeda()
};

foreach (Kendaraan item in kendaraan)
{
    item.Bergerak();
}

// Parent class
class Kendaraan
{
    public virtual void Bergerak()
    {
        Console.WriteLine("Kendaraan bergerak");
    }
}

// Child class
class Mobil : Kendaraan
{
    public override void Bergerak()
    {
        Console.WriteLine("Mobil berjalan di jalan raya");
    }
}

// Child class
class Motor : Kendaraan
{
    public override void Bergerak()
    {
        Console.WriteLine("Motor berjalan di jalan raya");
    }
}

// Child class
class Sepeda : Kendaraan
{
    public override void Bergerak()
    {
        Console.WriteLine("Sepeda dikayuh");
    }
}