// Membuat class Mobil
class Mobil
{
    public string Merk { get; set; }
    public string Warna { get; set; }
}

// Membuat object pertama
Mobil mobil1 = new Mobil();

mobil1.Merk = "Toyota";
mobil1.Warna = "Hitam";

// Membuat object kedua
Mobil mobil2 = new Mobil();

mobil2.Merk = "Honda";
mobil2.Warna = "Putih";

// Menampilkan data object pertama
Console.WriteLine("Mobil 1");
Console.WriteLine("Merk  : " + mobil1.Merk);
Console.WriteLine("Warna : " + mobil1.Warna);

// Menampilkan data object kedua
Console.WriteLine();
Console.WriteLine("Mobil 2");
Console.WriteLine("Merk  : " + mobil2.Merk);
Console.WriteLine("Warna : " + mobil2.Warna);