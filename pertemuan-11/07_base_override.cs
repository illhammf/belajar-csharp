// Pertemuan 11 - Base dan Override
// base digunakan untuk memanggil method milik parent

Kucing kucing = new Kucing();

kucing.Suara();

// Parent class
class Hewan
{
    public virtual void Suara()
    {
        Console.WriteLine("Hewan mengeluarkan suara");
    }
}

// Child class
class Kucing : Hewan
{
    public override void Suara()
    {
        // Memanggil method parent
        base.Suara();

        // Menambahkan perilaku dari child
        Console.WriteLine("Kucing: Meong!");
    }
}