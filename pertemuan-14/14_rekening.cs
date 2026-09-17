// Pertemuan 14 - Exception Handling
// Studi kasus rekening sederhana

class Rekening
{
    public string Nama { get; set; }
    public double Saldo { get; private set; }

    public Rekening(string nama, double saldoAwal)
    {
        Nama = nama;
        Saldo = saldoAwal;
    }

    public void Tarik(double jumlah)
    {
        // Jumlah penarikan harus lebih dari 0
        if (jumlah <= 0)
        {
            throw new Exception("Jumlah penarikan harus lebih dari 0.");
        }

        // Saldo harus mencukupi
        if (jumlah > Saldo)
        {
            throw new Exception("Saldo tidak mencukupi.");
        }

        Saldo -= jumlah;

        Console.WriteLine($"Penarikan berhasil: Rp{jumlah:N0}");
    }

    public void TampilkanSaldo()
    {
        Console.WriteLine($"Saldo: Rp{Saldo:N0}");
    }
}

// Program utama
var rekening = new Rekening("Ilham", 500000);

Console.WriteLine($"Nama: {rekening.Nama}");
rekening.TampilkanSaldo();

Console.Write("\nMasukkan jumlah penarikan: ");

try
{
    double jumlah = double.Parse(Console.ReadLine() ?? "");

    rekening.Tarik(jumlah);

    rekening.TampilkanSaldo();
}
catch (FormatException)
{
    Console.WriteLine("Jumlah harus berupa angka.");
}
catch (Exception ex)
{
    Console.WriteLine($"Transaksi gagal: {ex.Message}");
}