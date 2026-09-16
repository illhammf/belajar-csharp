// Pertemuan 13 - Interface dan Polymorphism
// Variable bertipe interface dapat menyimpan object class
// yang mengimplementasikan interface tersebut

IKendaraan kendaraan;

kendaraan = new Mobil();
kendaraan.Bergerak();

kendaraan = new Motor();
kendaraan.Bergerak();

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
        Console.WriteLine("Mobil sedang berjalan");
    }
}

// Class Motor
class Motor : IKendaraan
{
    public void Bergerak()
    {
        Console.WriteLine("Motor sedang berjalan");
    }
}