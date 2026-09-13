// Membuat object Programmer
Programmer programmer = new Programmer();

// Mengisi data Programmer
programmer.Nama = "Ilham";
programmer.Gaji = 5000000;
programmer.Bahasa = "C#";

// Menampilkan data
programmer.TampilkanData();

// Menjalankan method khusus
programmer.Coding();


// Memberikan jarak
Console.WriteLine();


// Membuat object Designer
Designer designer = new Designer();

// Mengisi data Designer
designer.Nama = "Andi";
designer.Gaji = 4500000;
designer.Software = "Figma";

// Menampilkan data
designer.TampilkanData();

// Menjalankan method khusus
designer.Design();


// ==========================================
// PARENT CLASS
// ==========================================

class Karyawan
{
    // Property milik parent
    public string Nama { get; set; }

    public double Gaji { get; set; }

    // Method milik parent
    public void TampilkanData()
    {
        Console.WriteLine(
            "Nama : " + Nama
        );

        Console.WriteLine(
            "Gaji : Rp" + Gaji
        );
    }
}


// ==========================================
// CHILD CLASS - PROGRAMMER
// ==========================================

class Programmer : Karyawan
{
    // Property khusus Programmer
    public string Bahasa { get; set; }

    // Method khusus Programmer
    public void Coding()
    {
        Console.WriteLine(
            Nama + " sedang coding menggunakan "
            + Bahasa
        );
    }
}


// ==========================================
// CHILD CLASS - DESIGNER
// ==========================================

class Designer : Karyawan
{
    // Property khusus Designer
    public string Software { get; set; }

    // Method khusus Designer
    public void Design()
    {
        Console.WriteLine(
            Nama + " sedang menggunakan "
            + Software
        );
    }
}