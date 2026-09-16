// Pertemuan 13 - List dengan Interface
// List juga dapat menggunakan interface sebagai tipe data

using System.Collections.Generic;

List<IKendaraan> kendaraan = new List<IKendaraan>();

kendaraan.Add(new Mobil());
kendaraan.Add(new Motor());
kendaraan.Add(new Sepeda());

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
        Console.WriteLine("Mobil bergerak");
    }
}

// Motor
class Motor : IKendaraan
{
    public void Bergerak()
    {
        Console.WriteLine("Motor bergerak");
    }
}

// Sepeda
class Sepeda : IKendaraan
{
    public void Bergerak()
    {
        Console.WriteLine("Sepeda bergerak");
    }
}