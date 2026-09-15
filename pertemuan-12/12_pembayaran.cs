// Pertemuan 12 - Studi Kasus Pembayaran
// Setiap metode pembayaran memiliki proses yang berbeda

Pembayaran[] pembayaran =
{
    new Cash(),
    new EWallet(),
    new Transfer()
};

foreach (Pembayaran item in pembayaran)
{
    item.Bayar(50000);

    Console.WriteLine();
}

// Abstract class
abstract class Pembayaran
{
    public abstract void Bayar(int jumlah);
}

// Pembayaran cash
class Cash : Pembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine($"Pembayaran Cash: Rp{jumlah}");
    }
}

// Pembayaran E-Wallet
class EWallet : Pembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine($"Pembayaran E-Wallet: Rp{jumlah}");
    }
}

// Pembayaran transfer
class Transfer : Pembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine($"Pembayaran Transfer: Rp{jumlah}");
    }
}