// ==========================================
// PROGRAM UTAMA
// ==========================================

// Membuat object Mobil
Mobil mobil = new Mobil(
    "Toyota",
    "Hitam",
    4
);

// Menampilkan data Mobil
Console.WriteLine("=== DATA MOBIL ===");

mobil.TampilkanMobil();
mobil.Bergerak();
mobil.Klakson();


// Memberikan jarak
Console.WriteLine();


// Membuat object Motor
Motor motor = new Motor(
    "Honda",
    "Merah",
    "Sport"
);

// Menampilkan data Motor
Console.WriteLine("=== DATA MOTOR ===");

motor.TampilkanMotor();
motor.Bergerak();
motor.BunyiMesin();


// ==========================================
// PARENT CLASS
// ==========================================

class Kendaraan
{
    // Property yang diwariskan
    public string Merk { get; set; }

    public string Warna { get; set; }

    // Constructor parent
    public Kendaraan(
        string merk,
        string warna
    )
    {
        Merk = merk;
        Warna = warna;
    }

    // Method parent
    public void TampilkanInfo()
    {
        Console.WriteLine(
            "Merk  : " + Merk
        );

        Console.WriteLine(
            "Warna : " + Warna
        );
    }

    // Method parent
    public void Bergerak()
    {
        Console.WriteLine(
            Merk + " sedang bergerak"
        );
    }
}


// ==========================================
// CHILD CLASS - MOBIL
// ==========================================

class Mobil : Kendaraan
{
    // Property khusus Mobil
    public int JumlahPintu { get; set; }

    // Constructor Mobil
    public Mobil(
        string merk,
        string warna,
        int jumlahPintu
    ) : base(merk, warna)
    {
        JumlahPintu = jumlahPintu;
    }

    // Method khusus Mobil
    public void Klakson()
    {
        Console.WriteLine("Tin tin!");
    }

    // Method untuk menampilkan data Mobil
    public void TampilkanMobil()
    {
        // Menggunakan method dari parent
        TampilkanInfo();

        // Menampilkan property milik Mobil
        Console.WriteLine(
            "Jumlah pintu: " + JumlahPintu
        );
    }
}


// ==========================================
// CHILD CLASS - MOTOR
// ==========================================

class Motor : Kendaraan
{
    // Property khusus Motor
    public string JenisMotor { get; set; }

    // Constructor Motor
    public Motor(
        string merk,
        string warna,
        string jenisMotor
    ) : base(merk, warna)
    {
        JenisMotor = jenisMotor;
    }

    // Method khusus Motor
    public void BunyiMesin()
    {
        Console.WriteLine(
            "Brumm brumm!"
        );
    }

    // Method untuk menampilkan data Motor
    public void TampilkanMotor()
    {
        // Menggunakan method dari parent
        TampilkanInfo();

        // Menampilkan property milik Motor
        Console.WriteLine(
            "Jenis motor: " + JenisMotor
        );
    }
}