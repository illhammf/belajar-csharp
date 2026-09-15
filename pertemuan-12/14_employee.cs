// Pertemuan 12 - Studi Kasus Employee
// Setiap jenis karyawan memiliki cara menghitung gaji berbeda

Karyawan[] karyawan =
{
    new KaryawanTetap("Andi"),
    new KaryawanKontrak("Budi"),
    new KaryawanMagang("Citra")
};

foreach (Karyawan item in karyawan)
{
    item.TampilkanNama();
    Console.WriteLine($"Gaji: Rp{item.HitungGaji()}");

    Console.WriteLine();
}

// Abstract class
abstract class Karyawan
{
    public string Nama { get; set; }

    public Karyawan(string nama)
    {
        Nama = nama;
    }

    public void TampilkanNama()
    {
        Console.WriteLine($"Nama: {Nama}");
    }

    // Setiap jenis karyawan memiliki perhitungan gaji sendiri
    public abstract int HitungGaji();
}

// Karyawan tetap
class KaryawanTetap : Karyawan
{
    public KaryawanTetap(string nama) : base(nama)
    {
    }

    public override int HitungGaji()
    {
        return 5000000;
    }
}

// Karyawan kontrak
class KaryawanKontrak : Karyawan
{
    public KaryawanKontrak(string nama) : base(nama)
    {
    }

    public override int HitungGaji()
    {
        return 3500000;
    }
}

// Karyawan magang
class KaryawanMagang : Karyawan
{
    public KaryawanMagang(string nama) : base(nama)
    {
    }

    public override int HitungGaji()
    {
        return 1500000;
    }
}