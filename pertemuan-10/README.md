# Pertemuan 10 — Inheritance (Pewarisan)

## 📚 Materi

Pada pertemuan ini kita belajar salah satu konsep penting dalam **Object-Oriented Programming (OOP)**, yaitu **Inheritance** atau pewarisan.

Inheritance memungkinkan sebuah class mewarisi property dan method dari class lain.

Dengan inheritance, kita dapat menggunakan kembali kode yang sudah ada tanpa harus menulis ulang semuanya.

Materi yang dipelajari:

- Pengertian inheritance
- Parent class
- Child class
- Pewarisan property
- Pewarisan method
- Membuat child class
- Keyword `:`
- Keyword `base`
- Constructor pada inheritance
- Method tambahan pada child class
- Protected member
- Multi-level inheritance
- Studi kasus inheritance

---

## 🧠 1. Apa Itu Inheritance?

**Inheritance** adalah mekanisme yang memungkinkan sebuah class mendapatkan property dan method dari class lain.

Contoh sederhana:

    class Hewan
    {
        public string Nama { get; set; }

        public void Makan()
        {
            Console.WriteLine("Hewan sedang makan");
        }
    }

Kemudian kita membuat class `Kucing` yang mewarisi `Hewan`:

    class Kucing : Hewan
    {
    }

Sekarang `Kucing` memiliki property dan method dari `Hewan`.

---

## 👨‍👦 2. Parent Class dan Child Class

Dalam inheritance terdapat dua istilah penting.

### Parent Class

Parent class adalah class yang memberikan property dan method.

Contoh:

    class Hewan
    {
        public string Nama { get; set; }
    }

### Child Class

Child class adalah class yang menerima atau mewarisi property dan method dari parent class.

Contoh:

    class Kucing : Hewan
    {
    }

Hubungannya:

    Hewan
      ↓
    Kucing

`Hewan` adalah parent class.

`Kucing` adalah child class.

---

## 🔗 3. Keyword `:`

Di C#, inheritance dibuat menggunakan tanda `:`.

Contoh:

    class Kucing : Hewan
    {
    }

Artinya:

    Kucing mewarisi Hewan

Dengan begitu, object `Kucing` dapat menggunakan member yang diwariskan dari `Hewan`.

---

## 🐱 4. Contoh Inheritance Sederhana

Parent class:

    class Hewan
    {
        public string Nama { get; set; }

        public void Makan()
        {
            Console.WriteLine(Nama + " sedang makan");
        }
    }

Child class:

    class Kucing : Hewan
    {
    }

Kemudian:

    Kucing kucing = new Kucing();

    kucing.Nama = "Milo";
    kucing.Makan();

Object `kucing` dapat menggunakan `Nama` dan `Makan()` karena keduanya diwariskan dari `Hewan`.

---

## ➕ 5. Menambahkan Method pada Child Class

Child class tidak hanya dapat menggunakan member dari parent class.

Child class juga dapat memiliki method miliknya sendiri.

Contoh:

    class Hewan
    {
        public void Makan()
        {
            Console.WriteLine("Hewan sedang makan");
        }
    }

    class Kucing : Hewan
    {
        public void Mengeong()
        {
            Console.WriteLine("Meong!");
        }
    }

Sekarang object `Kucing` dapat menggunakan:

    Kucing kucing = new Kucing();

    kucing.Makan();
    kucing.Mengeong();

`Makan()` berasal dari parent class.

`Mengeong()` berasal dari child class.

---

## 🧬 6. Pewarisan Property

Property dari parent class juga dapat digunakan oleh child class.

Contoh:

    class Kendaraan
    {
        public string Merk { get; set; }
        public int Tahun { get; set; }
    }

    class Mobil : Kendaraan
    {
        public int JumlahPintu { get; set; }
    }

Object:

    Mobil mobil = new Mobil();

    mobil.Merk = "Toyota";
    mobil.Tahun = 2024;
    mobil.JumlahPintu = 4;

Property:

- `Merk` → diwariskan dari `Kendaraan`
- `Tahun` → diwariskan dari `Kendaraan`
- `JumlahPintu` → milik `Mobil`

---

## ⚙️ 7. Pewarisan Method

Method dari parent class juga dapat digunakan oleh child class.

Contoh:

    class Kendaraan
    {
        public void NyalakanMesin()
        {
            Console.WriteLine("Mesin menyala");
        }
    }

    class Mobil : Kendaraan
    {
    }

Kemudian:

    Mobil mobil = new Mobil();

    mobil.NyalakanMesin();

Method `NyalakanMesin()` berasal dari `Kendaraan`.

---

## 🏗️ 8. Constructor pada Inheritance

Child class dapat memiliki constructor sendiri.

Contoh:

    class Hewan
    {
        public string Nama { get; set; }

        public Hewan(string nama)
        {
            Nama = nama;
        }
    }

    class Kucing : Hewan
    {
        public Kucing(string nama) : base(nama)
        {
        }
    }

`base(nama)` digunakan untuk memanggil constructor milik parent class.

---

## 🔑 9. Keyword `base`

Keyword `base` digunakan untuk mengakses member dari parent class.

Contoh:

    class Hewan
    {
        public string Nama { get; set; }

        public void Perkenalan()
        {
            Console.WriteLine("Nama hewan: " + Nama);
        }
    }

    class Kucing : Hewan
    {
        public void Tampilkan()
        {
            base.Perkenalan();
        }
    }

`base.Perkenalan()` berarti memanggil method `Perkenalan()` yang berasal dari parent class.

---

## 🔒 10. Protected

`protected` memungkinkan member diakses oleh class itu sendiri dan child class.

Contoh:

    class Hewan
    {
        protected string jenis;

        public void SetJenis(string jenis)
        {
            this.jenis = jenis;
        }
    }

    class Kucing : Hewan
    {
        public void TampilkanJenis()
        {
            Console.WriteLine(jenis);
        }
    }

Property atau field `jenis` tidak dapat diakses langsung dari luar class, tetapi dapat digunakan oleh child class.

---

## 🧬 11. Multi-Level Inheritance

Inheritance dapat dibuat secara bertingkat.

Contoh:

    class Hewan
    {
    }

    class Mamalia : Hewan
    {
    }

    class Kucing : Mamalia
    {
    }

Hubungannya:

    Hewan
      ↓
    Mamalia
      ↓
    Kucing

`Kucing` secara tidak langsung juga mewarisi member dari `Hewan`.

---

## 🏎️ 12. Studi Kasus Kendaraan

Kita dapat membuat parent class `Kendaraan`.

Contoh:

    class Kendaraan
    {
        public string Merk { get; set; }

        public void Bergerak()
        {
            Console.WriteLine("Kendaraan sedang bergerak");
        }
    }

Kemudian membuat child class:

    class Mobil : Kendaraan
    {
        public void Klakson()
        {
            Console.WriteLine("Tin tin!");
        }
    }

Object:

    Mobil mobil = new Mobil();

    mobil.Merk = "Toyota";
    mobil.Bergerak();
    mobil.Klakson();

---

## 👨‍🎓 13. Studi Kasus Siswa

Inheritance juga dapat digunakan pada sistem siswa.

Contoh parent:

    class Orang
    {
        public string Nama { get; set; }

        public void Perkenalan()
        {
            Console.WriteLine("Nama: " + Nama);
        }
    }

Kemudian:

    class Siswa : Orang
    {
        public string Kelas { get; set; }
    }

Object:

    Siswa siswa = new Siswa();

    siswa.Nama = "Ilham";
    siswa.Kelas = "TI-1";

    siswa.Perkenalan();

Property `Nama` dan method `Perkenalan()` diwariskan dari `Orang`.

---

# 📁 Struktur Folder

File yang akan dibuat:

    pertemuan-10/
    │
    ├── 01_inheritance.cs
    ├── 02_parent_child.cs
    ├── 03_property_inheritance.cs
    ├── 04_method_inheritance.cs
    ├── 05_child_method.cs
    ├── 06_constructor_inheritance.cs
    ├── 07_base_constructor.cs
    ├── 08_base_method.cs
    ├── 09_protected.cs
    ├── 10_multilevel_inheritance.cs
    ├── 11_inheritance_hewan.cs
    ├── 12_inheritance_kendaraan.cs
    ├── 13_inheritance_siswa.cs
    ├── 14_inheritance_karyawan.cs
    └── 15_studi_kasus_inheritance.cs

---

# 🚀 Cara Menjalankan

Gunakan `run.ps1` untuk menjalankan file secara individual.

Contoh:

    .\run.ps1 pertemuan-10/01_inheritance.cs

Contoh lainnya:

    .\run.ps1 pertemuan-10/15_studi_kasus_inheritance.cs

---

# 🎯 Tujuan Pembelajaran

Setelah menyelesaikan pertemuan ini, diharapkan sudah memahami:

- Pengertian inheritance
- Perbedaan parent class dan child class
- Cara membuat inheritance
- Penggunaan keyword `:`
- Pewarisan property
- Pewarisan method
- Membuat method pada child class
- Constructor pada inheritance
- Penggunaan `base`
- Penggunaan `protected`
- Multi-level inheritance
- Penggunaan inheritance dalam studi kasus

---

# 💡 Kesimpulan

Inheritance memungkinkan sebuah class mewarisi property dan method dari class lain.

Contoh:

    class Hewan
    {
        public string Nama { get; set; }

        public void Makan()
        {
            Console.WriteLine("Hewan sedang makan");
        }
    }

    class Kucing : Hewan
    {
        public void Mengeong()
        {
            Console.WriteLine("Meong!");
        }
    }

Dengan inheritance:

- `Kucing` mendapatkan `Nama` dari `Hewan`
- `Kucing` mendapatkan `Makan()` dari `Hewan`
- `Kucing` memiliki method sendiri yaitu `Mengeong()`

Inheritance membantu kita membuat program yang lebih terstruktur dan mengurangi pengulangan kode.

Setelah memahami inheritance, materi berikutnya dapat dilanjutkan ke **Polymorphism**, yaitu kemampuan object untuk memiliki perilaku yang berbeda melalui interface atau method yang sama.