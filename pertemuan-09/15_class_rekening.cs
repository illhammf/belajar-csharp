// Membuat class Rekening
class Rekening
{
    // Property nama pemilik
    public string Pemilik { get; set; }

    // Saldo dibuat private
    private double saldo;

    // Constructor
    public Rekening(string pemilik)
    {
        Pemilik = pemilik;
        saldo = 0;
    }

    // Method untuk setor uang
    public void Setor(double jumlah)
    {
        if (jumlah > 0)
        {
            saldo += jumlah;

            Console.WriteLine(
                "Berhasil setor Rp" + jumlah
            );
        }
        else
        {
            Console.WriteLine("Jumlah setor tidak valid");
        }
    }

    // Method untuk mengambil uang
    public void Tarik(double jumlah)
    {
        if (jumlah <= 0)
        {
            Console.WriteLine("Jumlah penarikan tidak valid");
        }
        else if (jumlah > saldo)
        {
            Console.WriteLine("Saldo tidak cukup");
        }
        else
        {
            saldo -= jumlah;

            Console.WriteLine(
                "Berhasil tarik Rp" + jumlah
            );
        }
    }

    // Method untuk melihat saldo
    public double GetSaldo()
    {
        return saldo;
    }
}

// Membuat rekening
Rekening rekening = new Rekening("Ilham");

// Menampilkan pemilik
Console.WriteLine("Pemilik: " + rekening.Pemilik);

// Melakukan transaksi
rekening.Setor(500000);
rekening.Tarik(100000);

// Menampilkan saldo akhir
Console.WriteLine("Saldo akhir: Rp" + rekening.GetSaldo());