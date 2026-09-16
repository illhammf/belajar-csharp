// Pertemuan 13 - Studi Kasus Kendaraan
// Menggunakan interface untuk menentukan kemampuan kendaraan

IKendaraan[] kendaraan =
{
    new Mobil("Toyota"),
    new Motor("Honda"),
    new Sepeda("Polygon")
};

foreach (IKendaraan item in kendaraan)
{
    item.TampilkanInfo();
    item.Bergerak();

    Console.WriteLine();
}

// Interface
interface IKendaraan
{
    void TampilkanInfo();
    void Bergerak();
}

// Class Mobil
class Mobil : IKendaraan
{
    public string Nama { get; set; }

    public Mobil(string nama)
    {
        Nama = nama;
    }

    public void TampilkanInfo()
    {
        Console.WriteLine($"Jenis: Mobil | Nama: {Nama}");
    }

    public void Bergerak()
    {
        Console.WriteLine("Mobil bergerak menggunakan mesin");
    }
}

// Class Motor
class Motor : IKendaraan
{
    public string Nama { get; set; }

    public Motor(string nama)
    {
        Nama = nama;
    }

    public void TampilkanInfo()
    {
        Console.WriteLine($"Jenis: Motor | Nama: {Nama}");
    }

    public void Bergerak()
    {
        Console.WriteLine("Motor bergerak menggunakan mesin");
    }
}

// Class Sepeda
class Sepeda : IKendaraan
{
    public string Nama { get; set; }

    public Sepeda(string nama)
    {
        Nama = nama;
    }

    public void TampilkanInfo()
    {
        Console.WriteLine($"Jenis: Sepeda | Nama: {Nama}");
    }

    public void Bergerak()
    {
        Console.WriteLine("Sepeda bergerak dengan dikayuh");
    }
}