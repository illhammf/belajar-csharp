// Pertemuan 11 - Method Overriding
// Child class mengubah method milik parent

Kendaraan kendaraan = new Mobil();

kendaraan.Jalankan();

// Parent class
class Kendaraan
{
    public virtual void Jalankan()
    {
        Console.WriteLine("Kendaraan sedang berjalan");
    }
}

// Child class
class Mobil : Kendaraan
{
    public override void Jalankan()
    {
        Console.WriteLine("Mobil sedang melaju");
    }
}