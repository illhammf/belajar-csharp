// Membuat class Produk
class Produk
{
    // Property untuk nama produk
    public string Nama { get; set; }

    // Property untuk harga produk
    public double Harga { get; set; }

    // Property untuk stok produk
    public int Stok { get; set; }
}

// Membuat object
Produk produk = new Produk();

// Mengisi property
produk.Nama = "Keyboard";
produk.Harga = 150000;
produk.Stok = 10;

// Menampilkan data
Console.WriteLine("Nama  : " + produk.Nama);
Console.WriteLine("Harga : Rp" + produk.Harga);
Console.WriteLine("Stok  : " + produk.Stok);