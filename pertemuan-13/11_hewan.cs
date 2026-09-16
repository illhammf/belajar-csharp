// Pertemuan 13 - Studi Kasus Hewan
// Menggunakan interface untuk menentukan kemampuan hewan

IBisaTerbang[] hewanTerbang =
{
    new Burung(),
    new Bebek()
};

foreach (IBisaTerbang hewan in hewanTerbang)
{
    hewan.Terbang();
}

Console.WriteLine();

IBisaBerenang[] hewanBerenang =
{
    new Bebek(),
    new Ikan()
};

foreach (IBisaBerenang hewan in hewanBerenang)
{
    hewan.Berenang();
}

// Interface terbang
interface IBisaTerbang
{
    void Terbang();
}

// Interface berenang
interface IBisaBerenang
{
    void Berenang();
}

// Burung
class Burung : IBisaTerbang
{
    public void Terbang()
    {
        Console.WriteLine("Burung terbang");
    }
}

// Bebek memiliki dua kemampuan
class Bebek : IBisaTerbang, IBisaBerenang
{
    public void Terbang()
    {
        Console.WriteLine("Bebek terbang");
    }

    public void Berenang()
    {
        Console.WriteLine("Bebek berenang");
    }
}

// Ikan hanya bisa berenang
class Ikan : IBisaBerenang
{
    public void Berenang()
    {
        Console.WriteLine("Ikan berenang");
    }
}