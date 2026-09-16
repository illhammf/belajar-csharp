// Pertemuan 13 - Implementasi Interface
// Satu interface dapat digunakan oleh beberapa class

Mobil mobil = new Mobil();
Motor motor = new Motor();

mobil.Bergerak();
motor.Bergerak();

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
        Console.WriteLine("Mobil bergerak menggunakan mesin");
    }
}

// Class Motor
class Motor : IKendaraan
{
    public void Bergerak()
    {
        Console.WriteLine("Motor bergerak menggunakan mesin");
    }
}