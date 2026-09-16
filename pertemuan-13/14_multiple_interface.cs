// Pertemuan 13 - Multiple Interface
// Class dapat mengimplementasikan beberapa interface
// sekaligus

Smartphone smartphone = new Smartphone();

smartphone.Nyalakan();
smartphone.KoneksiInternet();
smartphone.PutarMusik();

// Interface pertama
interface IPerangkat
{
    void Nyalakan();
}

// Interface kedua
interface IInternet
{
    void KoneksiInternet();
}

// Interface ketiga
interface IMusik
{
    void PutarMusik();
}

// Satu class mengimplementasikan tiga interface
class Smartphone : IPerangkat, IInternet, IMusik
{
    public void Nyalakan()
    {
        Console.WriteLine("Smartphone dinyalakan");
    }

    public void KoneksiInternet()
    {
        Console.WriteLine("Smartphone terhubung ke internet");
    }

    public void PutarMusik()
    {
        Console.WriteLine("Smartphone memutar musik");
    }
}