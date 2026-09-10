// Membuat class Rekening
class Rekening
{
    // Saldo dibuat private
    // Jadi saldo tidak dapat diubah langsung dari luar class
    private double saldo;

    // Method untuk menyetor uang
    public void Setor(double jumlah)
    {
        // Menambahkan jumlah ke saldo
        saldo += jumlah;
    }

    // Method untuk mengambil saldo
    public double GetSaldo()
    {
        return saldo;
    }
}

// Membuat object rekening
Rekening rekening = new Rekening();

// Menyetor uang
rekening.Setor(100000);
rekening.Setor(50000);

// Mengambil saldo
double saldoSekarang = rekening.GetSaldo();

// Menampilkan saldo
Console.WriteLine("Saldo: Rp" + saldoSekarang);