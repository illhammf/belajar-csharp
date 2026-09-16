// Pertemuan 13 - Multiple Interface
// Satu class dapat mengimplementasikan beberapa interface

Bebek bebek = new Bebek();

bebek.Terbang();
bebek.Berenang();

// Interface pertama
interface IBisaTerbang
{
    void Terbang();
}

// Interface kedua
interface IBisaBerenang
{
    void Berenang();
}

// Class mengimplementasikan dua interface
class Bebek : IBisaTerbang, IBisaBerenang
{
    public void Terbang()
    {
        Console.WriteLine("Bebek sedang terbang");
    }

    public void Berenang()
    {
        Console.WriteLine("Bebek sedang berenang");
    }
}