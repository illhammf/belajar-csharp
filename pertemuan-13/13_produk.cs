// Pertemuan 13 - Studi Kasus Produk
// Interface menentukan property dan method yang harus dimiliki produk

IProduk[] produk =
{
    new Makanan("Nasi Goreng", 20000),
    new Elektronik("Keyboard", 150000),
    new Pakaian("Kaos", 75000)
};

foreach (IProduk item in produk)
{
    item.TampilkanInfo();

    Console.WriteLine();
}

// Interface
interface IProduk
{
    string Nama { get; set; }
    int Harga { get; set; }

    void TampilkanInfo();
}

// Produk makanan
class Makanan : IProduk
{
    public string Nama { get; set; }
    public int Harga { get; set; }

    public Makanan(string nama, int harga)
    {
        Nama = nama;
        Harga = harga;
    }

    public void TampilkanInfo()
    {
        Console.WriteLine($"Makanan: {Nama}");
        Console.WriteLine($"Harga: Rp{Harga}");
    }
}

// Produk elektronik
class Elektronik : IProduk
{
    public string Nama { get; set; }
    public int Harga { get; set; }

    public Elektronik(string nama, int harga)
    {
        Nama = nama;
        Harga = harga;
    }

    public void TampilkanInfo()
    {
        Console.WriteLine($"Elektronik: {Nama}");
        Console.WriteLine($"Harga: Rp{Harga}");
    }
}

// Produk pakaian
class Pakaian : IProduk
{
    public string Nama { get; set; }
    public int Harga { get; set; }

    public Pakaian(string nama, int harga)
    {
        Nama = nama;
        Harga = harga;
    }

    public void TampilkanInfo()
    {
        Console.WriteLine($"Pakaian: {Nama}");
        Console.WriteLine($"Harga: Rp{Harga}");
    }
}