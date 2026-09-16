// Pertemuan 13 - Interface
// Contoh dasar membuat dan menggunakan interface

// Membuat object dari class yang mengimplementasikan interface
Mobil mobil = new Mobil();

mobil.Bergerak();

// Interface
interface IKendaraan
{
    void Bergerak();
}

// Class yang mengimplementasikan interface
class Mobil : IKendaraan
{
    public void Bergerak()
    {
        Console.WriteLine("Mobil sedang bergerak");
    }
}