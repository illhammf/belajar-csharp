// Pertemuan 11 - Polymorphism Pembayaran
// Setiap metode pembayaran memiliki cara proses yang berbeda

Pembayaran[] pembayaran =
{
    new Cash(),
    new EWallet(),
    new Transfer()
};

foreach (Pembayaran item in pembayaran)
{
    item.Bayar(50000);
}

// Parent class
class Pembayaran
{
    public virtual void Bayar(int jumlah)
    {
        Console.WriteLine($"Membayar Rp{jumlah}");
    }
}

// Child class
class Cash : Pembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine($"Pembayaran cash: Rp{jumlah}");
    }
}

// Child class
class EWallet : Pembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine($"Pembayaran E-Wallet: Rp{jumlah}");
    }
}

// Child class
class Transfer : Pembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine($"Pembayaran transfer: Rp{jumlah}");
    }
}