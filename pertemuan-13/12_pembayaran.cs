// Pertemuan 13 - Studi Kasus Pembayaran
// Semua metode pembayaran memiliki kemampuan Bayar()

IPembayaran[] pembayaran =
{
    new Cash(),
    new EWallet(),
    new Transfer()
};

foreach (IPembayaran item in pembayaran)
{
    item.Bayar(50000);

    Console.WriteLine();
}

// Interface
interface IPembayaran
{
    void Bayar(int jumlah);
}

// Cash
class Cash : IPembayaran
{
    public void Bayar(int jumlah)
    {
        Console.WriteLine($"Pembayaran Cash: Rp{jumlah}");
    }
}

// E-Wallet
class EWallet : IPembayaran
{
    public void Bayar(int jumlah)
    {
        Console.WriteLine($"Pembayaran E-Wallet: Rp{jumlah}");
    }
}

// Transfer
class Transfer : IPembayaran
{
    public void Bayar(int jumlah)
    {
        Console.WriteLine($"Pembayaran Transfer: Rp{jumlah}");
    }
}