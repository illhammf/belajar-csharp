// Pertemuan 11 - Polymorphism Employee
// Setiap jenis karyawan memiliki cara menghitung gaji yang berbeda

Karyawan[] karyawan =
{
    new KaryawanTetap(),
    new KaryawanKontrak()
};

foreach (Karyawan item in karyawan)
{
    Console.WriteLine($"Gaji: Rp{item.HitungGaji()}");
}

// Parent class
class Karyawan
{
    public virtual int HitungGaji()
    {
        return 0;
    }
}

// Child class
class KaryawanTetap : Karyawan
{
    public override int HitungGaji()
    {
        return 5000000;
    }
}

// Child class
class KaryawanKontrak : Karyawan
{
    public override int HitungGaji()
    {
        return 3500000;
    }
}