// Membuat object Mobil
Mobil mobil = new Mobil();

// Mengisi property dari parent class
mobil.Merk = "Toyota";
mobil.Tahun = 2024;

// Mengisi property milik child class
mobil.JumlahPintu = 4;

// Menampilkan data
Console.WriteLine("Merk         : " + mobil.Merk);
Console.WriteLine("Tahun        : " + mobil.Tahun);
Console.WriteLine("Jumlah pintu : " + mobil.JumlahPintu);


// ==========================================
// PARENT CLASS
// ==========================================

class Kendaraan
{
    // Property yang diwariskan
    public string Merk { get; set; }

    public int Tahun { get; set; }
}


// ==========================================
// CHILD CLASS
// ==========================================

class Mobil : Kendaraan
{
    // Property khusus Mobil
    public int JumlahPintu { get; set; }
}