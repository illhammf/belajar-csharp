# Pertemuan 13 — Interface

Pada pertemuan ini kita akan mempelajari **Interface** di C#.

Interface digunakan untuk menentukan **kontrak** atau aturan yang harus diikuti oleh sebuah class.

Jika abstract class biasanya digunakan sebagai dasar dari sebuah kelompok object, interface lebih berfokus pada **kemampuan yang harus dimiliki oleh sebuah class**.

---

## 🎯 Tujuan Pembelajaran

Setelah menyelesaikan pertemuan ini, kita diharapkan dapat:

- Memahami konsep interface
- Membuat interface
- Mengimplementasikan interface pada class
- Memahami method dalam interface
- Memahami property dalam interface
- Menggunakan interface dengan beberapa class
- Memahami hubungan interface dengan polymorphism
- Menggunakan lebih dari satu interface
- Memahami perbedaan abstract class dan interface
- Menggunakan interface dalam studi kasus sederhana

---

# 1. Apa Itu Interface?

Interface adalah sebuah **kontrak** yang menentukan apa saja yang harus dimiliki oleh sebuah class.

Interface tidak digunakan untuk membuat object secara langsung.

Contoh:

    interface IBisaTerbang
    {
        void Terbang();
    }

Interface tersebut menentukan bahwa class yang mengimplementasikannya harus memiliki method `Terbang()`.

---

# 2. Membuat Interface

Nama interface biasanya diawali dengan huruf `I`.

Contoh:

    interface IBisaTerbang
    {
        void Terbang();
    }

`IBisaTerbang` dapat dibaca sebagai:

> Interface yang menentukan kemampuan untuk terbang.

---

# 3. Implementasi Interface

Sebuah class dapat mengimplementasikan interface.

Contoh:

    interface IBisaTerbang
    {
        void Terbang();
    }

    class Burung : IBisaTerbang
    {
        public void Terbang()
        {
            Console.WriteLine("Burung sedang terbang");
        }
    }

Class `Burung` wajib menyediakan method `Terbang()`.

---

# 4. Method dalam Interface

Interface dapat mendefinisikan method yang harus diimplementasikan oleh class.

Contoh:

    interface IBisaBersuara
    {
        void Suara();
    }

    class Kucing : IBisaBersuara
    {
        public void Suara()
        {
            Console.WriteLine("Meong!");
        }
    }

---

# 5. Property dalam Interface

Interface juga dapat menentukan property.

Contoh:

    interface IProduk
    {
        string Nama { get; set; }
        int Harga { get; set; }
    }

Class yang mengimplementasikan interface tersebut harus menyediakan property tersebut.

Contoh:

    class Makanan : IProduk
    {
        public string Nama { get; set; } = "";
        public int Harga { get; set; }
    }

---

# 6. Interface Sebagai Kontrak

Interface dapat dianggap seperti sebuah kontrak.

Misalnya:

    interface IKendaraan
    {
        void Bergerak();
    }

Artinya:

> Setiap class yang mengimplementasikan `IKendaraan` harus memiliki kemampuan `Bergerak()`.

Contoh:

    class Mobil : IKendaraan
    {
        public void Bergerak()
        {
            Console.WriteLine("Mobil bergerak");
        }
    }

    class Motor : IKendaraan
    {
        public void Bergerak()
        {
            Console.WriteLine("Motor bergerak");
        }
    }

---

# 7. Interface dan Polymorphism

Interface juga dapat digunakan sebagai reference untuk object.

Contoh:

    IKendaraan kendaraan = new Mobil();

    kendaraan.Bergerak();

Variable bertipe `IKendaraan` dapat menyimpan object dari class yang mengimplementasikan interface tersebut.

---

# 8. Banyak Class Menggunakan Interface yang Sama

Satu interface dapat digunakan oleh banyak class.

Contoh:

    interface IBisaTerbang
    {
        void Terbang();
    }

    class Burung : IBisaTerbang
    {
        public void Terbang()
        {
            Console.WriteLine("Burung terbang");
        }
    }

    class Pesawat : IBisaTerbang
    {
        public void Terbang()
        {
            Console.WriteLine("Pesawat terbang");
        }
    }

Burung dan pesawat berbeda, tetapi keduanya memiliki kemampuan yang sama, yaitu terbang.

---

# 9. Satu Class Dapat Menggunakan Banyak Interface

C# memungkinkan sebuah class mengimplementasikan lebih dari satu interface.

Contoh:

    interface IBisaTerbang
    {
        void Terbang();
    }

    interface IBisaBerenang
    {
        void Berenang();
    }

    class Bebek : IBisaTerbang, IBisaBerenang
    {
        public void Terbang()
        {
            Console.WriteLine("Bebek terbang");
        }

        public void Berenang()
        {
            Console.WriteLine("Bebek berenang");
        }
    }

Bebek memiliki dua kemampuan:

- Terbang
- Berenang

---

# 10. Interface dengan Property dan Method

Interface dapat memiliki beberapa kontrak sekaligus.

Contoh:

    interface IProduk
    {
        string Nama { get; set; }

        int Harga { get; set; }

        void TampilkanInfo();
    }

Class yang mengimplementasikan interface tersebut harus memenuhi semua kontrak tersebut.

---

# 11. Interface dan Array

Interface juga dapat digunakan sebagai tipe array.

Contoh:

    IKendaraan[] kendaraan =
    {
        new Mobil(),
        new Motor(),
        new Sepeda()
    };

    foreach (IKendaraan item in kendaraan)
    {
        item.Bergerak();
    }

Hal ini merupakan salah satu bentuk polymorphism.

---

# 12. Interface vs Abstract Class

Interface dan abstract class sama-sama dapat digunakan untuk abstraction, tetapi memiliki tujuan yang berbeda.

### Abstract Class

Biasanya digunakan ketika beberapa class memiliki hubungan yang kuat sebagai parent dan child.

Contoh:

    abstract class Hewan
    {
        public string Nama { get; set; } = "";

        public abstract void Suara();
    }

### Interface

Biasanya digunakan untuk menentukan kemampuan atau kontrak.

Contoh:

    interface IBisaTerbang
    {
        void Terbang();
    }

Contoh class:

    class Burung : Hewan, IBisaTerbang
    {
        public override void Suara()
        {
            Console.WriteLine("Cuit cuit!");
        }

        public void Terbang()
        {
            Console.WriteLine("Burung terbang");
        }
    }

Satu class dapat mewarisi satu class parent sekaligus mengimplementasikan beberapa interface.

---

# 13. Nama Interface

Konvensi umum C# adalah menggunakan huruf `I` di awal nama interface.

Contoh:

    IKendaraan
    IBisaTerbang
    IBisaBerenang
    IPembayaran
    IProduk

Huruf `I` membantu kita langsung mengetahui bahwa sesuatu tersebut adalah interface.

---

# 14. Studi Kasus

Pada pertemuan ini kita akan membuat beberapa studi kasus.

### Kendaraan

Interface:

    IKendaraan

Class:

    Mobil
    Motor
    Sepeda

Semua kendaraan memiliki kemampuan:

    Bergerak()

---

### Hewan

Interface:

    IBisaTerbang
    IBisaBerenang

Class:

    Burung
    Bebek
    Ikan

Tidak semua hewan memiliki kemampuan yang sama.

---

### Pembayaran

Interface:

    IPembayaran

Class:

    Cash
    EWallet
    Transfer

Semua metode pembayaran memiliki kemampuan:

    Bayar()

---

### Produk

Interface:

    IProduk

Class:

    Makanan
    Elektronik
    Pakaian

Semua produk memiliki informasi dasar seperti:

    Nama
    Harga

---

# 📁 Struktur Folder

File latihan pada pertemuan ini:

    pertemuan-13/
    │
    ├── 01_interface.cs
    ├── 02_interface_method.cs
    ├── 03_interface_property.cs
    ├── 04_implementasi_interface.cs
    ├── 05_interface_polymorphism.cs
    ├── 06_multiple_class_interface.cs
    ├── 07_multiple_interface.cs
    ├── 08_interface_array.cs
    ├── 09_interface_list.cs
    ├── 10_kendaraan.cs
    ├── 11_hewan.cs
    ├── 12_pembayaran.cs
    ├── 13_produk.cs
    ├── 14_multiple_interface.cs
    └── 15_studi_kasus_interface.cs

---

# ▶️ Cara Menjalankan

Gunakan `run.ps1` untuk menjalankan setiap file.

Contoh:

    .\run.ps1 pertemuan-13/01_interface.cs

Contoh lainnya:

    .\run.ps1 pertemuan-13/10_kendaraan.cs

Untuk studi kasus:

    .\run.ps1 pertemuan-13/15_studi_kasus_interface.cs

---

# 🧠 Ringkasan

Pada pertemuan ini kita mempelajari:

1. Interface adalah kontrak untuk sebuah class.
2. Nama interface biasanya diawali dengan `I`.
3. Interface dapat memiliki method.
4. Interface dapat memiliki property.
5. Class menggunakan interface dengan syntax `:`.
6. Class yang mengimplementasikan interface harus memenuhi kontraknya.
7. Banyak class dapat menggunakan interface yang sama.
8. Satu class dapat mengimplementasikan beberapa interface.
9. Interface dapat digunakan untuk polymorphism.
10. Interface merupakan salah satu cara menerapkan abstraction.

---

# 🔥 Hubungan Materi OOP

Sampai pertemuan ini, kita sudah mempelajari beberapa konsep penting OOP:

    Class & Object
          ↓
    Encapsulation
          ↓
    Inheritance
          ↓
    Polymorphism
          ↓
    Abstraction
          ↓
    Interface

Konsep-konsep tersebut saling berhubungan dan sering digunakan bersama dalam project C#.

---

# 🚀 Tantangan

Buat sebuah sistem sederhana menggunakan interface.

Contoh:

    interface ILogin
    {
        void Login();
    }

Kemudian buat beberapa class:

    Admin
    Mahasiswa
    Dosen

Ketiga class tersebut memiliki method `Login()` dengan implementasi masing-masing.

Kemudian simpan object tersebut dalam array atau list bertipe `ILogin` dan jalankan method `Login()` menggunakan polymorphism.

Tujuannya adalah memahami bahwa interface dapat digunakan untuk membuat **kontrak yang dapat diterapkan oleh berbagai class dengan implementasi yang berbeda**.