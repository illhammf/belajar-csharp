// Pertemuan 12 - Studi Kasus Abstract
// Studi kasus sederhana sistem produk

Produk[] produk =
{
    new Makanan("Nasi Goreng", 20000),
    new Elektronik("Keyboard", 150000),
    new Pakaian("Kaos", 75000)
};

foreach (Produk item in produk)
{
    item.TampilkanInfo();
    item.TampilkanHarga();

    Console.WriteLine();
}

// Abstract class
abstract class Produk
{
    public string Nama { get; set; }
    public int Harga { get; set; }

    public Produk(string nama, int harga)
    {
        Nama = nama;
        Harga = harga;
    }

    // Method biasa
    public void TampilkanInfo()
    {
        Console.WriteLine($"Produk: {Nama}");
    }

    // Abstract method
    // Setiap jenis produk wajib menentukan cara menampilkan harga
    public abstract void TampilkanHarga();
}

// Produk makanan
class Makanan : Produk
{
    public Makanan(string nama, int harga) : base(nama, harga)
    {
    }

    public override void TampilkanHarga()
    {
        Console.WriteLine($"Harga makanan: Rp{Harga}");
    }
}

// Produk elektronik
class Elektronik : Produk
{
    public Elektronik(string nama, int harga) : base(nama, harga)
    {
    }

    public override void TampilkanHarga()
    {
        Console.WriteLine($"Harga elektronik: Rp{Harga}");
    }
}

// Produk pakaian
class Pakaian : Produk
{
    public Pakaian(string nama, int harga) : base(nama, harga)
    {
    }

    public override void TampilkanHarga()
    {
        Console.WriteLine($"Harga pakaian: Rp{Harga}");
    }
}