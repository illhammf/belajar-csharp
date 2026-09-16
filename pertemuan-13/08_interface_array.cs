// Pertemuan 13 - Array dengan Interface
// Array bertipe interface dapat menyimpan berbagai object
// yang mengimplementasikan interface tersebut

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

// Mobil
class Mobil : IKendaraan
{
    public void Bergerak()
    {
        Console.WriteLine("Mobil berjalan");
    }
}

// Motor
class Motor : IKendaraan
{
    public void Bergerak()
    {
        Console.WriteLine("Motor berjalan");
    }
}

// Sepeda
class Sepeda : IKendaraan
{
    public void Bergerak()
    {
        Console.WriteLine("Sepeda dikayuh");
    }
}