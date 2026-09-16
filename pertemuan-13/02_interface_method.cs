// Pertemuan 13 - Method dalam Interface
// Interface dapat menentukan method yang wajib dimiliki class

Kucing kucing = new Kucing();

kucing.Suara();

// Interface
interface IBisaBersuara
{
    void Suara();
}

// Class yang mengimplementasikan interface
class Kucing : IBisaBersuara
{
    public void Suara()
    {
        Console.WriteLine("Kucing: Meong!");
    }
}