// Pertemuan 13 - Studi Kasus Interface
// Studi kasus: Sistem Login
// Setiap jenis pengguna memiliki proses login masing-masing

ILogin[] pengguna =
{
    new Admin("admin01"),
    new Mahasiswa("mahasiswa01"),
    new Dosen("dosen01")
};

foreach (ILogin user in pengguna)
{
    user.Login();

    Console.WriteLine();
}

// Interface
interface ILogin
{
    void Login();
}

// Class Admin
class Admin : ILogin
{
    public string Username { get; set; }

    public Admin(string username)
    {
        Username = username;
    }

    public void Login()
    {
        Console.WriteLine($"Admin '{Username}' berhasil login");
        Console.WriteLine("Membuka halaman dashboard admin");
    }
}

// Class Mahasiswa
class Mahasiswa : ILogin
{
    public string Username { get; set; }

    public Mahasiswa(string username)
    {
        Username = username;
    }

    public void Login()
    {
        Console.WriteLine($"Mahasiswa '{Username}' berhasil login");
        Console.WriteLine("Membuka halaman akademik mahasiswa");
    }
}

// Class Dosen
class Dosen : ILogin
{
    public string Username { get; set; }

    public Dosen(string username)
    {
        Username = username;
    }

    public void Login()
    {
        Console.WriteLine($"Dosen '{Username}' berhasil login");
        Console.WriteLine("Membuka halaman akademik dosen");
    }
}