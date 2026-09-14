# Pertemuan 12 — Abstract Class & Abstraction

Pada pertemuan ini kita akan mempelajari **Abstraction** menggunakan `abstract class` dan `abstract method` di C#.

Abstraction digunakan untuk membuat struktur dasar yang harus dimiliki oleh class turunan, tanpa menentukan seluruh detail implementasinya di class parent.

---

## 🎯 Tujuan Pembelajaran

Setelah menyelesaikan pertemuan ini, kita diharapkan dapat:

- Memahami konsep abstraction
- Memahami `abstract class`
- Memahami `abstract method`
- Mengetahui perbedaan class biasa dan abstract class
- Membuat class turunan dari abstract class
- Mengimplementasikan abstract method menggunakan `override`
- Memahami hubungan abstraction dengan inheritance
- Memahami hubungan abstraction dengan polymorphism
- Menggunakan abstract class dalam studi kasus sederhana

---

# 1. Apa Itu Abstraction?

**Abstraction** adalah konsep untuk menyembunyikan detail implementasi dan hanya menampilkan bagian penting yang diperlukan.

Contohnya, ketika kita menggunakan kendaraan:

    kendaraan.Nyalakan();

Kita hanya perlu tahu bahwa kendaraan bisa dinyalakan.

Kita tidak harus mengetahui secara detail bagaimana mesin, bahan bakar, listrik, dan komponen lainnya bekerja.

Dalam pemrograman, abstraction membantu kita membuat struktur program yang lebih terorganisir.

---

# 2. Apa Itu Abstract Class?

`abstract class` adalah class yang digunakan sebagai dasar untuk class lain.

Abstract class biasanya tidak dibuat menjadi object secara langsung.

Contoh:

    abstract class Hewan
    {
        public abstract void Suara();
    }

Kita tidak dapat membuat object langsung dari `Hewan`:

    Hewan hewan = new Hewan();

Kode tersebut tidak diperbolehkan karena `Hewan` adalah abstract class.

Namun, kita dapat membuat class turunan:

    class Kucing : Hewan
    {
        public override void Suara()
        {
            Console.WriteLine("Meong!");
        }
    }

Kemudian membuat object:

    Kucing kucing = new Kucing();

---

# 3. Abstract Method

Abstract method adalah method yang hanya memiliki deklarasi tanpa isi implementasi.

Contoh:

    public abstract void Suara();

Method tersebut tidak memiliki `{ }` dan tidak memiliki isi.

Class turunan wajib memberikan implementasinya menggunakan `override`.

Contoh:

    class Kucing : Hewan
    {
        public override void Suara()
        {
            Console.WriteLine("Meong!");
        }
    }

---

# 4. Abstract Class dan Abstract Method

Abstract class dapat memiliki:

- Property
- Method biasa
- Abstract method
- Constructor

Contoh:

    abstract class Hewan
    {
        public string Nama { get; set; } = "";

        public void Makan()
        {
            Console.WriteLine($"{Nama} sedang makan");
        }

        public abstract void Suara();
    }

Pada contoh tersebut:

- `Nama` adalah property biasa
- `Makan()` adalah method biasa
- `Suara()` adalah abstract method

---

# 5. Class Turunan

Class yang mewarisi abstract class harus mengimplementasikan abstract method.

Contoh:

    abstract class Hewan
    {
        public abstract void Suara();
    }

    class Kucing : Hewan
    {
        public override void Suara()
        {
            Console.WriteLine("Meong!");
        }
    }

    class Anjing : Hewan
    {
        public override void Suara()
        {
            Console.WriteLine("Guk guk!");
        }
    }

---

# 6. Abstract Method Wajib Di-Override

Jika sebuah class mewarisi abstract class, abstract method harus diimplementasikan.

Contoh:

    abstract class Kendaraan
    {
        public abstract void Bergerak();
    }

    class Mobil : Kendaraan
    {
        public override void Bergerak()
        {
            Console.WriteLine("Mobil berjalan");
        }
    }

`Mobil` wajib memiliki implementasi `Bergerak()`.

---

# 7. Abstract Class Tidak Bisa Dibuat Menjadi Object

Abstract class tidak dapat dibuat menjadi object secara langsung.

Contoh yang salah:

    abstract class Hewan
    {
        public abstract void Suara();
    }

    Hewan hewan = new Hewan();

Kode tersebut akan menghasilkan error.

Yang dapat dibuat adalah object dari class turunannya:

    Kucing kucing = new Kucing();

---

# 8. Abstract Class Bisa Memiliki Method Biasa

Abstract class tidak berarti semua method harus abstract.

Kita dapat memiliki method biasa di dalam abstract class.

Contoh:

    abstract class Hewan
    {
        public void Makan()
        {
            Console.WriteLine("Hewan sedang makan");
        }

        public abstract void Suara();
    }

Class turunan dapat langsung menggunakan method `Makan()`.

---

# 9. Abstract Class dengan Constructor

Abstract class juga dapat memiliki constructor.

Contoh:

    abstract class Hewan
    {
        public string Nama { get; set; }

        public Hewan(string nama)
        {
            Nama = nama;
        }

        public abstract void Suara();
    }

Class turunan dapat memanggil constructor parent menggunakan `base`.

Contoh:

    class Kucing : Hewan
    {
        public Kucing(string nama) : base(nama)
        {
        }

        public override void Suara()
        {
            Console.WriteLine($"{Nama}: Meong!");
        }
    }

---

# 10. Abstract Class dan Polymorphism

Abstract class juga dapat digunakan sebagai reference untuk object class turunannya.

Contoh:

    Hewan hewan = new Kucing("Milo");

    hewan.Suara();

Walaupun variable bertipe `Hewan`, object sebenarnya adalah `Kucing`.

Ini merupakan contoh penggunaan **polymorphism**.

---

# 11. Array dengan Abstract Class

Kita juga dapat menggunakan abstract class sebagai tipe array.

Contoh:

    Hewan[] hewan =
    {
        new Kucing("Milo"),
        new Anjing("Buddy"),
        new Burung("Rio")
    };

    foreach (Hewan item in hewan)
    {
        item.Suara();
    }

Setiap object memiliki implementasi `Suara()` masing-masing.

---

# 12. Perbedaan Class Biasa dan Abstract Class

| Class Biasa | Abstract Class |
|---|---|
| Bisa dibuat object langsung | Tidak bisa dibuat object langsung |
| Bisa memiliki method biasa | Bisa memiliki method biasa |
| Bisa memiliki abstract method? | Bisa memiliki abstract method |
| Tidak harus diwariskan | Biasanya digunakan sebagai parent |
| Implementasi dapat langsung dibuat | Dapat memaksa child mengimplementasikan method tertentu |

---

# 13. Abstract Class vs Interface

Abstract class dan interface sama-sama dapat digunakan untuk membuat abstraksi, tetapi memiliki konsep yang berbeda.

### Abstract Class

Digunakan ketika beberapa class memiliki hubungan yang kuat dan ingin berbagi property atau method.

Contoh:

    abstract class Hewan
    {
        public string Nama { get; set; } = "";

        public abstract void Suara();
    }

### Interface

Interface lebih berfokus pada kemampuan atau kontrak yang harus dimiliki sebuah class.

Contoh:

    interface IBisaTerbang
    {
        void Terbang();
    }

Pembahasan interface akan dipelajari lebih lanjut pada pertemuan berikutnya.

---

# 14. Studi Kasus

Pada pertemuan ini kita akan membuat beberapa studi kasus:

### Hewan

Parent:

    abstract class Hewan

Child:

    Kucing
    Anjing
    Burung

Setiap hewan memiliki suara yang berbeda.

### Kendaraan

Parent:

    abstract class Kendaraan

Child:

    Mobil
    Motor
    Sepeda

Setiap kendaraan memiliki cara bergerak yang berbeda.

### Pembayaran

Parent:

    abstract class Pembayaran

Child:

    Cash
    EWallet
    Transfer

Setiap metode pembayaran memiliki proses yang berbeda.

---

# 📁 Struktur Folder

File latihan pada pertemuan ini:

    pertemuan-12/
    │
    ├── 01_abstract_class.cs
    ├── 02_abstract_method.cs
    ├── 03_abstract_property.cs
    ├── 04_method_biasa.cs
    ├── 05_abstract_override.cs
    ├── 06_constructor_abstract.cs
    ├── 07_base_abstract.cs
    ├── 08_polymorphism_abstract.cs
    ├── 09_array_abstract.cs
    ├── 10_hewan.cs
    ├── 11_kendaraan.cs
    ├── 12_pembayaran.cs
    ├── 13_shape.cs
    ├── 14_employee.cs
    └── 15_studi_kasus_abstract.cs

---

# ▶️ Cara Menjalankan

Karena setiap file dibuat sebagai file C# yang dapat dijalankan secara terpisah, gunakan `run.ps1`.

Contoh:

    .\run.ps1 pertemuan-12/01_abstract_class.cs

Contoh lainnya:

    .\run.ps1 pertemuan-12/10_hewan.cs

Dan studi kasus:

    .\run.ps1 pertemuan-12/15_studi_kasus_abstract.cs

---

# 🧠 Ringkasan

Pada pertemuan ini kita mempelajari:

1. Abstraction adalah konsep untuk menyembunyikan detail implementasi.
2. `abstract class` digunakan sebagai class dasar.
3. Abstract class tidak dapat dibuat menjadi object secara langsung.
4. `abstract method` tidak memiliki implementasi.
5. Abstract method wajib diimplementasikan oleh class turunan.
6. Implementasi abstract method menggunakan `override`.
7. Abstract class dapat memiliki property dan method biasa.
8. Abstract class dapat memiliki constructor.
9. Abstract class dapat digunakan bersama polymorphism.
10. Abstract class membantu membuat struktur program yang lebih terorganisir.

---

# 🔥 Hubungan Materi OOP

Sampai tahap ini, konsep OOP yang sudah dipelajari:

    Class & Object
          ↓
    Encapsulation
          ↓
    Inheritance
          ↓
    Polymorphism
          ↓
    Abstraction

Keempat konsep tersebut merupakan bagian penting dari **Object-Oriented Programming (OOP)**.

---

# 🚀 Tantangan

Setelah menyelesaikan seluruh latihan, coba buat sistem sederhana menggunakan abstract class.

Contoh:

    abstract class Produk
    {
        public string Nama { get; set; } = "";

        public abstract void TampilkanHarga();
    }

Kemudian buat beberapa class turunan seperti:

    ProdukMakanan
    ProdukElektronik
    ProdukPakaian

Masing-masing class memiliki cara berbeda untuk menampilkan harga.

Tujuannya bukan hanya menghafal `abstract`, tetapi memahami **kapan dan mengapa abstraction digunakan**.