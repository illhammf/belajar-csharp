// Pertemuan 13 - Multiple Class dengan Interface
// Banyak class dapat menggunakan interface yang sama

IKendaraan[] kendaraan =
{
    new Mobil(),
    new Motor(),
    new Sepeda()
};

foreach (IKendaraan item in kendaraan)
{
    item.Bergerak();
}

// Interface
interface IKendaraan
{
    void Bergerak();
}

// Class Mobil
class Mobil : IKendaraan
{
    public void Bergerak()
    {
        Console.WriteLine("Mobil bergerak");
    }
}

// Class Motor
class Motor : IKendaraan
{
    public void Bergerak()
    {
        Console.WriteLine("Motor bergerak");
    }
}

// Class Sepeda
class Sepeda : IKendaraan
{
    public void Bergerak()
    {
        Console.WriteLine("Sepeda dikayuh");
    }
}