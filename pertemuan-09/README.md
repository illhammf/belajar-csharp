# Pertemuan 09 — Class & Object

## 📚 Materi

Pada pertemuan ini kita mulai belajar **Object-Oriented Programming (OOP)** menggunakan C#.

OOP adalah konsep pemrograman yang mengorganisasi program menggunakan **object**.

Di C#, object dibuat berdasarkan sebuah **class**.

Materi yang dipelajari:

- Class
- Object
- Property
- Method di dalam class
- Constructor
- Membuat object
- Mengakses property
- Mengubah property
- Method dengan parameter
- Method dengan return value
- Encapsulation sederhana
- `private` dan `public`
- `this`
- Static member
- Class dan object dalam studi kasus

---

## 🧠 1. Apa Itu Class?

**Class** adalah blueprint atau cetakan untuk membuat object.

Contohnya kita ingin membuat data seorang siswa.

Kita dapat membuat class `Siswa` yang memiliki:

- Nama
- Kelas
- Nilai

Contoh:

    class Siswa
    {
        public string Nama;
        public string Kelas;
        public double Nilai;
    }

Class tersebut belum menjadi siswa tertentu.

Class hanya menjadi **cetakan**.

---

## 🧠 2. Apa Itu Object?

**Object** adalah hasil atau instance dari sebuah class.

Contoh:

    Siswa siswa1 = new Siswa();

Sekarang kita sudah memiliki object `siswa1`.

Kita dapat mengisi datanya:

    siswa1.Nama = "Ilham";
    siswa1.Kelas = "TI-1";
    siswa1.Nilai = 90;

---

## 🧩 3. Class dan Object

Hubungan sederhananya:

    Class
       ↓
    Blueprint / cetakan
       ↓
    Object
       ↓
    Data dan behavior

Contoh:

    class Mobil
    {
        public string Merk;
        public string Warna;
    }

Kemudian membuat object:

    Mobil mobil1 = new Mobil();
    Mobil mobil2 = new Mobil();

Keduanya berasal dari class yang sama, tetapi datanya dapat berbeda.

---

## 🏷️ 4. Property

Property digunakan untuk menyimpan dan mengatur data pada sebuah class.

Contoh:

    class Siswa
    {
        public string Nama { get; set; }
        public int Umur { get; set; }
    }

Kemudian:

    Siswa siswa = new Siswa();

    siswa.Nama = "Ilham";
    siswa.Umur = 20;

    Console.WriteLine(siswa.Nama);
    Console.WriteLine(siswa.Umur);

---

## ⚙️ 5. Method

Method adalah function yang berada di dalam class.

Method dapat digunakan untuk memberikan behavior kepada object.

Contoh:

    class Siswa
    {
        public string Nama { get; set; }

        public void Perkenalan()
        {
            Console.WriteLine("Halo, nama saya " + Nama);
        }
    }

Kemudian:

    Siswa siswa = new Siswa();

    siswa.Nama = "Ilham";
    siswa.Perkenalan();

---

## 🏗️ 6. Constructor

Constructor adalah method khusus yang otomatis dijalankan ketika object dibuat.

Contoh:

    class Siswa
    {
        public string Nama { get; set; }

        public Siswa()
        {
            Console.WriteLine("Object Siswa dibuat");
        }
    }

Ketika:

    Siswa siswa = new Siswa();

Constructor akan otomatis dijalankan.

---

## 🧱 7. Constructor dengan Parameter

Constructor juga dapat menerima parameter.

Contoh:

    class Siswa
    {
        public string Nama { get; set; }

        public Siswa(string nama)
        {
            Nama = nama;
        }
    }

Kemudian:

    Siswa siswa = new Siswa("Ilham");

    Console.WriteLine(siswa.Nama);

Dengan cara ini kita dapat langsung memberikan data ketika object dibuat.

---

## 🔑 8. Keyword `this`

`this` digunakan untuk merujuk kepada object yang sedang digunakan.

Contoh:

    class Siswa
    {
        public string Nama { get; set; }

        public Siswa(string Nama)
        {
            this.Nama = Nama;
        }
    }

`this.Nama` berarti property `Nama` milik object.

---

## 🔒 9. Public dan Private

Access modifier digunakan untuk mengatur siapa yang dapat mengakses data atau method.

### Public

Dapat diakses dari luar class.

    public string Nama;

### Private

Hanya dapat diakses dari dalam class.

    private double nilai;

Contoh:

    class Siswa
    {
        private double nilai;

        public void SetNilai(double nilai)
        {
            this.nilai = nilai;
        }

        public double GetNilai()
        {
            return nilai;
        }
    }

---

## 🛡️ 10. Encapsulation

**Encapsulation** adalah konsep membatasi akses langsung terhadap data dan menyediakan method atau property untuk mengontrol akses tersebut.

Contoh:

    class Rekening
    {
        private double saldo;

        public void Setor(double jumlah)
        {
            saldo += jumlah;
        }

        public double GetSaldo()
        {
            return saldo;
        }
    }

Dengan cara ini, data `saldo` tidak dapat diubah secara sembarangan dari luar class.

---

## 📦 11. Method dengan Parameter

Method dapat menerima data melalui parameter.

Contoh:

    class Kalkulator
    {
        public int Tambah(int a, int b)
        {
            return a + b;
        }
    }

Penggunaan:

    Kalkulator kalkulator = new Kalkulator();

    int hasil = kalkulator.Tambah(10, 20);

    Console.WriteLine(hasil);

---

## ↩️ 12. Method dengan Return Value

Method dapat mengembalikan sebuah nilai menggunakan `return`.

Contoh:

    class Matematika
    {
        public int Kuadrat(int angka)
        {
            return angka * angka;
        }
    }

Penggunaan:

    Matematika matematika = new Matematika();

    int hasil = matematika.Kuadrat(5);

    Console.WriteLine(hasil);

Output:

    25

---

## 🌟 13. Static

`static` berarti member tersebut dimiliki oleh class, bukan object tertentu.

Contoh:

    class Matematika
    {
        public static int Tambah(int a, int b)
        {
            return a + b;
        }
    }

Kita dapat memanggilnya langsung menggunakan nama class:

    int hasil = Matematika.Tambah(10, 20);

Tidak perlu membuat object terlebih dahulu.

---

# 📁 Struktur Folder

File yang akan dibuat:

    pertemuan-09/
    │
    ├── 01_class.cs
    ├── 02_object.cs
    ├── 03_property.cs
    ├── 04_method.cs
    ├── 05_constructor.cs
    ├── 06_constructor_parameter.cs
    ├── 07_this.cs
    ├── 08_method_parameter.cs
    ├── 09_method_return.cs
    ├── 10_public_private.cs
    ├── 11_encapsulation.cs
    ├── 12_static.cs
    ├── 13_class_siswa.cs
    ├── 14_class_kalkulator.cs
    ├── 15_class_rekening.cs
    └── 16_data_siswa.cs

---

# 🚀 Cara Menjalankan

Karena project menggunakan `run.ps1`, jalankan file secara individual.

Contoh:

    .\run.ps1 pertemuan-09/01_class.cs

Contoh lainnya:

    .\run.ps1 pertemuan-09/16_data_siswa.cs

---

# 🎯 Tujuan Pembelajaran

Setelah menyelesaikan pertemuan ini, diharapkan sudah memahami:

- Pengertian class
- Pengertian object
- Cara membuat class
- Cara membuat object
- Cara membuat property
- Cara membuat method
- Cara menggunakan constructor
- Cara menggunakan `this`
- Perbedaan `public` dan `private`
- Konsep dasar encapsulation
- Method dengan parameter
- Method dengan return value
- Penggunaan `static`
- Membuat program sederhana berbasis object

---

# 💡 Kesimpulan

Class adalah **cetakan**, sedangkan object adalah **hasil dari cetakan tersebut**.

Contoh sederhana:

    class Siswa
    {
        public string Nama { get; set; }
    }

Kemudian:

    Siswa siswa = new Siswa();

    siswa.Nama = "Ilham";

Di sini:

- `Siswa` → class
- `siswa` → object
- `Nama` → property

Dengan memahami konsep ini, kita mulai masuk ke dunia **Object-Oriented Programming (OOP)** di C#.

Pertemuan berikutnya dapat dilanjutkan ke konsep OOP yang lebih lanjut seperti **inheritance dan polymorphism**.