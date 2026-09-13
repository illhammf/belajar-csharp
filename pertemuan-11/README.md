# Pertemuan 11 — Polymorphism

## 📚 Materi

Pada pertemuan ini kita melanjutkan pembelajaran **Object-Oriented Programming (OOP)** dengan mempelajari **Polymorphism**.

Polymorphism berasal dari bahasa Yunani:

- Poly = banyak
- Morph = bentuk

Secara sederhana, polymorphism memungkinkan sebuah method atau object memiliki **bentuk atau perilaku yang berbeda**.

Dalam C#, polymorphism dapat digunakan bersama inheritance untuk membuat program yang lebih fleksibel.

Materi yang dipelajari:

- Pengertian polymorphism
- Polymorphism dalam OOP
- `virtual`
- `override`
- Method overriding
- Parent reference
- Child object
- Polymorphism sederhana
- Beberapa child class
- `base`
- Perbedaan method biasa dan `virtual`
- Polymorphism dengan array
- Polymorphism dengan list
- Studi kasus polymorphism

---

## 🧠 1. Apa Itu Polymorphism?

**Polymorphism** adalah kemampuan sebuah object atau method untuk memiliki perilaku yang berbeda.

Contoh:

    class Hewan
    {
        public virtual void Suara()
        {
            Console.WriteLine("Hewan mengeluarkan suara");
        }
    }

Kemudian:

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

Method yang digunakan sama:

    Suara()

Tetapi perilakunya berbeda:

    Kucing → Meong!
    Anjing → Guk guk!

Inilah salah satu bentuk polymorphism.

---

## 🔑 2. Keyword `virtual`

`virtual` digunakan pada method parent agar method tersebut dapat diubah perilakunya oleh child class.

Contoh:

    class Hewan
    {
        public virtual void Suara()
        {
            Console.WriteLine("Suara hewan");
        }
    }

Method `Suara()` sekarang dapat di-override oleh child class.

---

## 🔄 3. Keyword `override`

`override` digunakan pada child class untuk memberikan implementasi baru terhadap method `virtual` dari parent class.

Contoh:

    class Kucing : Hewan
    {
        public override void Suara()
        {
            Console.WriteLine("Meong!");
        }
    }

Artinya `Kucing` mengganti perilaku method `Suara()` milik `Hewan`.

---

## 🐱 4. Contoh Polymorphism Sederhana

Parent class:

    class Hewan
    {
        public virtual void Suara()
        {
            Console.WriteLine("Hewan bersuara");
        }
    }

Child class:

    class Kucing : Hewan
    {
        public override void Suara()
        {
            Console.WriteLine("Meong!");
        }
    }

Object:

    Kucing kucing = new Kucing();

    kucing.Suara();

Output:

    Meong!

---

## 🐶 5. Beberapa Child Class

Satu parent class dapat memiliki beberapa child class.

Contoh:

    class Hewan
    {
        public virtual void Suara()
        {
            Console.WriteLine("Suara hewan");
        }
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

Sekarang kita memiliki:

    Hewan
      │
      ├── Kucing
      │
      └── Anjing

Masing-masing memiliki implementasi `Suara()` yang berbeda.

---

## 🧩 6. Parent Reference dan Child Object

Salah satu hal penting dalam polymorphism adalah object child dapat disimpan dalam reference parent.

Contoh:

    Hewan hewan = new Kucing();

Walaupun tipe reference-nya `Hewan`, object sebenarnya adalah `Kucing`.

Jika `Suara()` menggunakan `virtual` dan `override`:

    hewan.Suara();

Maka C# akan menjalankan:

    Meong!

Ini adalah salah satu inti dari runtime polymorphism.

---

## 🔄 7. Parent Reference untuk Beberapa Child

Kita dapat membuat beberapa object child menggunakan reference parent.

Contoh:

    Hewan hewan1 = new Kucing();
    Hewan hewan2 = new Anjing();

Kemudian:

    hewan1.Suara();
    hewan2.Suara();

Hasil:

    Meong!
    Guk guk!

Method yang dipanggil sama:

    Suara()

Tetapi hasilnya berbeda berdasarkan object sebenarnya.

---

## 🆚 8. Tanpa `virtual` dan `override`

Jika method parent tidak menggunakan `virtual`, child tidak dapat melakukan overriding dengan `override`.

Contoh:

    class Hewan
    {
        public void Suara()
        {
            Console.WriteLine("Suara hewan");
        }
    }

Method tersebut merupakan method biasa.

Untuk polymorphism melalui overriding, kita menggunakan:

    public virtual void Suara()

dan pada child:

    public override void Suara()

---

## 🧱 9. Method Overriding

**Method overriding** berarti child class memberikan implementasi baru untuk method parent.

Contoh:

    class Hewan
    {
        public virtual void Suara()
        {
            Console.WriteLine("Suara hewan");
        }
    }

    class Kucing : Hewan
    {
        public override void Suara()
        {
            Console.WriteLine("Meong!");
        }
    }

Method yang diubah:

    Suara()

Parent:

    Suara hewan

Child:

    Meong!

---

## 🔙 10. Menggunakan `base`

Child class dapat tetap menjalankan method parent menggunakan `base`.

Contoh:

    class Hewan
    {
        public virtual void Suara()
        {
            Console.WriteLine("Hewan mengeluarkan suara");
        }
    }

    class Kucing : Hewan
    {
        public override void Suara()
        {
            base.Suara();

            Console.WriteLine("Kucing berkata: Meong!");
        }
    }

Dengan:

    base.Suara();

method parent tetap dijalankan.

---

## 📦 11. Polymorphism dengan Array

Object dari beberapa child class dapat disimpan dalam array bertipe parent.

Contoh:

    Hewan[] hewan =
    {
        new Kucing(),
        new Anjing(),
        new Burung()
    };

Kemudian:

    foreach (Hewan item in hewan)
    {
        item.Suara();
    }

Setiap object akan menjalankan implementasi `Suara()` masing-masing.

---

## 📋 12. Polymorphism dengan List

Polymorphism juga dapat digunakan dengan `List`.

Contoh:

    List<Hewan> hewan = new List<Hewan>();

    hewan.Add(new Kucing());
    hewan.Add(new Anjing());

Kemudian:

    foreach (Hewan item in hewan)
    {
        item.Suara();
    }

Keuntungan pendekatan ini adalah kita dapat menyimpan berbagai child object dalam satu collection bertipe parent.

---

## 🏎️ 13. Studi Kasus Kendaraan

Polymorphism dapat digunakan untuk berbagai jenis kendaraan.

Parent:

    class Kendaraan
    {
        public virtual void Bergerak()
        {
            Console.WriteLine("Kendaraan bergerak");
        }
    }

Child:

    class Mobil : Kendaraan
    {
        public override void Bergerak()
        {
            Console.WriteLine("Mobil berjalan di jalan raya");
        }
    }

    class Motor : Kendaraan
    {
        public override void Bergerak()
        {
            Console.WriteLine("Motor berjalan di jalan raya");
        }
    }

Kemudian:

    Kendaraan kendaraan1 = new Mobil();
    Kendaraan kendaraan2 = new Motor();

    kendaraan1.Bergerak();
    kendaraan2.Bergerak();

Method yang dipanggil sama:

    Bergerak()

Tetapi perilakunya berbeda.

---

## 💳 14. Studi Kasus Pembayaran

Contoh lain adalah sistem pembayaran.

Parent:

    class Pembayaran
    {
        public virtual void Bayar(double jumlah)
        {
            Console.WriteLine("Melakukan pembayaran");
        }
    }

Child:

    class Cash : Pembayaran
    {
        public override void Bayar(double jumlah)
        {
            Console.WriteLine("Bayar cash: Rp" + jumlah);
        }
    }

    class EWallet : Pembayaran
    {
        public override void Bayar(double jumlah)
        {
            Console.WriteLine("Bayar menggunakan e-wallet: Rp" + jumlah);
        }
    }

Dengan polymorphism:

    Pembayaran pembayaran1 = new Cash();
    Pembayaran pembayaran2 = new EWallet();

    pembayaran1.Bayar(50000);
    pembayaran2.Bayar(75000);

Satu method:

    Bayar()

Tetapi implementasinya berbeda.

---

# 📁 Struktur Folder

File yang akan dibuat:

    pertemuan-11/
    │
    ├── 01_polymorphism.cs
    ├── 02_virtual.cs
    ├── 03_override.cs
    ├── 04_method_overriding.cs
    ├── 05_parent_reference.cs
    ├── 06_multiple_child.cs
    ├── 07_base_override.cs
    ├── 08_array_polymorphism.cs
    ├── 09_list_polymorphism.cs
    ├── 10_kendaraan.cs
    ├── 11_hewan.cs
    ├── 12_pembayaran.cs
    ├── 13_shape.cs
    ├── 14_employee.cs
    └── 15_studi_kasus_polymorphism.cs

---

# 🚀 Cara Menjalankan

Gunakan `run.ps1` untuk menjalankan file secara individual.

Contoh:

    .\run.ps1 pertemuan-11/01_polymorphism.cs

Contoh lainnya:

    .\run.ps1 pertemuan-11/15_studi_kasus_polymorphism.cs

---

# 🎯 Tujuan Pembelajaran

Setelah menyelesaikan pertemuan ini, diharapkan sudah memahami:

- Pengertian polymorphism
- Konsep method overriding
- Penggunaan `virtual`
- Penggunaan `override`
- Penggunaan `base`
- Parent reference
- Child object
- Polymorphism dengan beberapa child class
- Polymorphism menggunakan array
- Polymorphism menggunakan `List`
- Penggunaan polymorphism dalam studi kasus

---

# 💡 Kesimpulan

Polymorphism memungkinkan sebuah method memiliki perilaku yang berbeda berdasarkan object yang digunakan.

Contoh:

    class Hewan
    {
        public virtual void Suara()
        {
            Console.WriteLine("Suara hewan");
        }
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

Kemudian:

    Hewan hewan1 = new Kucing();
    Hewan hewan2 = new Anjing();

    hewan1.Suara();
    hewan2.Suara();

Output:

    Meong!
    Guk guk!

Walaupun keduanya menggunakan reference `Hewan` dan memanggil method yang sama, yaitu `Suara()`, hasilnya berbeda sesuai object sebenarnya.

Jadi secara sederhana:

    Inheritance
         ↓
    Parent & Child
         ↓
    virtual
         ↓
    override
         ↓
    Polymorphism

Setelah memahami polymorphism, materi berikutnya dapat dilanjutkan ke **Abstraction dan Interface**, sehingga konsep OOP C# menjadi semakin lengkap.