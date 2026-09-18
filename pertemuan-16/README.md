# Pertemuan 16 — LINQ (Language Integrated Query)

## Pengertian LINQ

LINQ adalah singkatan dari **Language Integrated Query**.

LINQ digunakan untuk melakukan pencarian, penyaringan, pengurutan, dan pengolahan data secara lebih mudah di C#.

LINQ dapat digunakan pada berbagai jenis data seperti:

- Array
- `List<T>`
- Collection
- Object
- Database
- dan sumber data lainnya

Contoh sederhana:

    List<int> angka = new List<int>
    {
        10,
        15,
        20,
        25,
        30
    };

    var hasil = angka.Where(x => x > 20);

    foreach (int item in hasil)
    {
        Console.WriteLine(item);
    }

Output:

    25
    30

Pada contoh tersebut, LINQ digunakan untuk mengambil angka yang lebih besar dari 20.

---

# 1. Menggunakan LINQ

Untuk menggunakan sebagian besar fitur LINQ, kita membutuhkan:

    using System.Linq;

Contoh:

    using System;
    using System.Collections.Generic;
    using System.Linq;

---

# 2. Where()

`Where()` digunakan untuk melakukan filter atau penyaringan data berdasarkan kondisi tertentu.

Contoh:

    List<int> angka = new List<int>
    {
        10,
        15,
        20,
        25,
        30
    };

    var hasil = angka.Where(x => x > 20);

    foreach (int item in hasil)
    {
        Console.WriteLine(item);
    }

Output:

    25
    30

`x => x > 20` disebut **lambda expression**.

Artinya:

    x → setiap data
    > 20 → kondisi yang harus dipenuhi

---

# 3. Filter Bilangan Genap

`Where()` dapat digunakan untuk mengambil bilangan genap.

Contoh:

    List<int> angka = new List<int>
    {
        1,
        2,
        3,
        4,
        5,
        6
    };

    var genap = angka.Where(x => x % 2 == 0);

    foreach (int item in genap)
    {
        Console.WriteLine(item);
    }

Output:

    2
    4
    6

---

# 4. Select()

`Select()` digunakan untuk mengubah atau mengambil bagian tertentu dari data.

Contoh:

    List<int> angka = new List<int>
    {
        1,
        2,
        3,
        4
    };

    var kuadrat = angka.Select(x => x * x);

    foreach (int item in kuadrat)
    {
        Console.WriteLine(item);
    }

Output:

    1
    4
    9
    16

Pada contoh tersebut setiap angka diubah menjadi hasil kuadratnya.

---

# 5. Select() pada Object

`Select()` juga dapat digunakan untuk mengambil property tertentu dari object.

Contoh:

    List<Mahasiswa> mahasiswa = new List<Mahasiswa>
    {
        new Mahasiswa("Ilham", 90),
        new Mahasiswa("Budi", 80),
        new Mahasiswa("Andi", 85)
    };

    var nama = mahasiswa.Select(x => x.Nama);

    foreach (string item in nama)
    {
        Console.WriteLine(item);
    }

Output:

    Ilham
    Budi
    Andi

---

# 6. OrderBy()

`OrderBy()` digunakan untuk mengurutkan data dari kecil ke besar atau berdasarkan urutan tertentu.

Contoh:

    List<int> angka = new List<int>
    {
        40,
        10,
        30,
        20
    };

    var hasil = angka.OrderBy(x => x);

    foreach (int item in hasil)
    {
        Console.WriteLine(item);
    }

Output:

    10
    20
    30
    40

---

# 7. OrderByDescending()

`OrderByDescending()` digunakan untuk mengurutkan data secara terbalik.

Contoh:

    List<int> angka = new List<int>
    {
        40,
        10,
        30,
        20
    };

    var hasil = angka.OrderByDescending(x => x);

    foreach (int item in hasil)
    {
        Console.WriteLine(item);
    }

Output:

    40
    30
    20
    10

---

# 8. First()

`First()` digunakan untuk mengambil data pertama dari sebuah collection.

Contoh:

    List<int> angka = new List<int>
    {
        10,
        20,
        30
    };

    int hasil = angka.First();

    Console.WriteLine(hasil);

Output:

    10

Perhatikan bahwa `First()` akan menghasilkan exception jika collection kosong.

---

# 9. FirstOrDefault()

`FirstOrDefault()` digunakan untuk mengambil data pertama.

Jika tidak ada data, method ini akan memberikan nilai default sesuai tipe datanya.

Contoh:

    List<int> angka = new List<int>();

    int hasil = angka.FirstOrDefault();

    Console.WriteLine(hasil);

Untuk `int`, nilai default adalah:

    0

---

# 10. Any()

`Any()` digunakan untuk mengecek apakah terdapat data yang memenuhi kondisi.

Contoh:

    List<int> angka = new List<int>
    {
        10,
        20,
        30
    };

    bool ada = angka.Any(x => x > 25);

    Console.WriteLine(ada);

Output:

    True

Artinya terdapat setidaknya satu angka yang lebih besar dari 25.

---

# 11. Count()

LINQ juga dapat menggunakan `Count()` untuk menghitung jumlah data yang memenuhi kondisi.

Contoh:

    List<int> angka = new List<int>
    {
        10,
        15,
        20,
        25,
        30
    };

    int jumlah = angka.Count(x => x >= 20);

    Console.WriteLine(jumlah);

Output:

    3

Data yang memenuhi kondisi:

    20
    25
    30

---

# 12. Sum()

`Sum()` digunakan untuk menghitung total nilai.

Contoh:

    List<int> angka = new List<int>
    {
        10,
        20,
        30
    };

    int total = angka.Sum();

    Console.WriteLine(total);

Output:

    60

---

# 13. Average()

`Average()` digunakan untuk menghitung rata-rata.

Contoh:

    List<int> nilai = new List<int>
    {
        80,
        90,
        70
    };

    double rataRata = nilai.Average();

    Console.WriteLine(rataRata);

Output:

    80

---

# 14. Min() dan Max()

`Min()` digunakan untuk mendapatkan nilai terkecil.

`Max()` digunakan untuk mendapatkan nilai terbesar.

Contoh:

    List<int> nilai = new List<int>
    {
        80,
        90,
        70,
        85
    };

    int terkecil = nilai.Min();
    int terbesar = nilai.Max();

    Console.WriteLine($"Nilai terkecil: {terkecil}");
    Console.WriteLine($"Nilai terbesar: {terbesar}");

Output:

    Nilai terkecil: 70
    Nilai terbesar: 90

---

# 15. Contains()

`Contains()` digunakan untuk mengecek apakah suatu data terdapat di dalam collection.

Contoh:

    List<string> nama = new List<string>
    {
        "Ilham",
        "Budi",
        "Andi"
    };

    bool ditemukan = nama.Contains("Ilham");

    Console.WriteLine(ditemukan);

Output:

    True

---

# 16. String dalam LINQ

LINQ juga dapat digunakan untuk melakukan filter pada data string.

Contoh:

    List<string> nama = new List<string>
    {
        "Ilham",
        "Budi",
        "Andi",
        "Irfan"
    };

    var hasil = nama.Where(x => x.StartsWith("I"));

    foreach (string item in hasil)
    {
        Console.WriteLine(item);
    }

Output:

    Ilham
    Irfan

---

# 17. Where() dan Select()

`Where()` dan `Select()` dapat digunakan secara berurutan.

Contoh:

    List<Mahasiswa> mahasiswa = new List<Mahasiswa>
    {
        new Mahasiswa("Ilham", 90),
        new Mahasiswa("Budi", 55),
        new Mahasiswa("Andi", 80)
    };

    var hasil = mahasiswa
        .Where(x => x.Nilai >= 60)
        .Select(x => x.Nama);

    foreach (string nama in hasil)
    {
        Console.WriteLine(nama);
    }

Output:

    Ilham
    Andi

Prosesnya:

    Data Mahasiswa
          ↓
    Where()
          ↓
    Filter nilai >= 60
          ↓
    Select()
          ↓
    Ambil Nama

---

# 18. Method Chaining

LINQ dapat menggunakan beberapa method sekaligus.

Contoh:

    var hasil = angka
        .Where(x => x > 10)
        .OrderByDescending(x => x)
        .Select(x => x * 2);

Urutan proses:

    angka
      ↓
    Where()
      ↓
    OrderByDescending()
      ↓
    Select()
      ↓
    hasil

Cara seperti ini disebut **method chaining**.

---

# 19. Lambda Expression

LINQ sering menggunakan lambda expression.

Contoh:

    x => x > 10

Artinya:

    Ambil x jika x lebih besar dari 10.

Contoh lainnya:

    x => x * 2

Artinya:

    Ambil x lalu kalikan dengan 2.

Contoh pada object:

    x => x.Nilai >= 60

Artinya:

    Ambil data jika nilai lebih besar atau sama dengan 60.

Lambda expression menjadi bagian penting dalam penggunaan LINQ.

---

# 20. LINQ vs Looping Biasa

Tanpa LINQ:

    foreach (int angka in data)
    {
        if (angka > 10)
        {
            Console.WriteLine(angka);
        }
    }

Dengan LINQ:

    var hasil = data.Where(x => x > 10);

    foreach (int angka in hasil)
    {
        Console.WriteLine(angka);
    }

Keduanya dapat menghasilkan hasil yang sama.

LINQ membuat operasi pengolahan data tertentu menjadi lebih ringkas dan deklaratif.

Namun, penggunaan LINQ tidak berarti semua `foreach` harus diganti.

Gunakan cara yang paling mudah dipahami untuk kasus yang sedang dikerjakan.

---

# 21. Method LINQ yang Dipelajari

Beberapa method penting dalam pertemuan ini:

    Where()
    Select()
    OrderBy()
    OrderByDescending()
    First()
    FirstOrDefault()
    Any()
    Count()
    Sum()
    Average()
    Min()
    Max()
    Contains()

Method-method tersebut sering digunakan ketika mengolah data dalam aplikasi C#.

---

# 22. Struktur Program

Pada pertemuan ini kita akan menggunakan beberapa file:

    01_where.cs
    02_where_genap.cs
    03_select.cs
    04_select_object.cs
    05_order_by.cs
    06_order_by_descending.cs
    07_first.cs
    08_first_or_default.cs
    09_any.cs
    10_count.cs
    11_sum.cs
    12_average.cs
    13_min_max.cs
    14_string_linq.cs
    15_studi_kasus_linq.cs

---

# 23. Contoh Studi Kasus

Misalnya kita memiliki data mahasiswa:

    Ilham → 90
    Budi → 55
    Andi → 80
    Rizky → 70

Kita ingin mendapatkan mahasiswa yang lulus.

Dengan LINQ:

    var lulus = mahasiswa
        .Where(x => x.Nilai >= 60)
        .OrderByDescending(x => x.Nilai);

Kemudian ditampilkan:

    foreach (var item in lulus)
    {
        Console.WriteLine($"{item.Nama}: {item.Nilai}");
    }

LINQ akan melakukan:

    Data Mahasiswa
          ↓
    Filter nilai >= 60
          ↓
    Urutkan nilai terbesar
          ↓
    Tampilkan data

---

# 24. Kesimpulan

Pada pertemuan terakhir ini kita belajar **LINQ (Language Integrated Query)**.

Konsep utama yang dipelajari:

- `Where()` untuk filter data.
- `Select()` untuk mengambil atau mengubah data.
- `OrderBy()` untuk mengurutkan data.
- `OrderByDescending()` untuk mengurutkan secara menurun.
- `First()` untuk mengambil data pertama.
- `FirstOrDefault()` untuk mengambil data pertama dengan nilai default jika kosong.
- `Any()` untuk mengecek keberadaan data berdasarkan kondisi.
- `Count()` untuk menghitung data.
- `Sum()` untuk menghitung total.
- `Average()` untuk menghitung rata-rata.
- `Min()` untuk mencari nilai terkecil.
- `Max()` untuk mencari nilai terbesar.
- `Contains()` untuk mengecek keberadaan data.
- Lambda expression untuk membuat kondisi dan operasi data.

---

# 25. Challenge Akhir

Buat sebuah program **Sistem Data Mahasiswa** menggunakan `List<Mahasiswa>` dan LINQ.

Setiap mahasiswa memiliki:

    Nama
    Nilai

Contoh data:

    Ilham → 90
    Budi → 55
    Andi → 80
    Rizky → 70
    Fajar → 65

Program harus dapat:

1. Menampilkan seluruh mahasiswa.
2. Menampilkan mahasiswa yang lulus.
3. Menampilkan mahasiswa yang tidak lulus.
4. Mengurutkan mahasiswa berdasarkan nilai terbesar.
5. Mengurutkan mahasiswa berdasarkan nilai terkecil.
6. Menampilkan mahasiswa dengan nilai tertinggi.
7. Menampilkan mahasiswa dengan nilai terendah.
8. Menghitung jumlah mahasiswa.
9. Menghitung jumlah mahasiswa yang lulus.
10. Menghitung rata-rata nilai.
11. Mengecek apakah ada mahasiswa dengan nilai tertentu.
12. Menampilkan hanya nama mahasiswa yang lulus.

Gunakan LINQ sebanyak mungkin untuk proses pengolahan datanya.

---

# 26. Perjalanan Belajar C#

Dengan selesainya Pertemuan 16, perjalanan belajar dasar C# di repository ini telah selesai.

Urutan materi yang telah dipelajari:

    Pertemuan 01
    Dasar-Dasar C#

          ↓

    Pertemuan 02
    Variable, Data Type & Input

          ↓

    Pertemuan 03
    Operator

          ↓

    Pertemuan 04
    Percabangan

          ↓

    Pertemuan 05
    Perulangan

          ↓

    Pertemuan 06
    Function / Method

          ↓

    Pertemuan 07
    Array

          ↓

    Pertemuan 08
    String

          ↓

    Pertemuan 09
    Class & Object

          ↓

    Pertemuan 10
    Inheritance

          ↓

    Pertemuan 11
    Polymorphism

          ↓

    Pertemuan 12
    Abstract Class & Abstraction

          ↓

    Pertemuan 13
    Interface

          ↓

    Pertemuan 14
    Exception Handling

          ↓

    Pertemuan 15
    Collections

          ↓

    Pertemuan 16
    LINQ

---

# 27. Penutup

Repository ini dibuat sebagai catatan perjalanan belajar C# dari dasar hingga konsep Object-Oriented Programming dan pengolahan data.

Tujuan utama repository ini bukan hanya menghafal syntax, tetapi memahami konsep dan membangun kebiasaan belajar melalui contoh program sederhana.

Materi yang telah dipelajari mencakup:

- Fundamental C#
- Variable dan Data Type
- Input dan Output
- Operator
- Conditional
- Looping
- Function / Method
- Array
- String
- Class dan Object
- Encapsulation
- Inheritance
- Polymorphism
- Abstraction
- Interface
- Exception Handling
- Collections
- LINQ

Setelah menyelesaikan seluruh pertemuan, langkah selanjutnya bukan lagi menambah materi dasar sebanyak-banyaknya, tetapi mulai **menerapkan C# untuk membuat project nyata**.

Contohnya:

- Aplikasi Console
- Sistem Data Mahasiswa
- Sistem Perpustakaan
- Sistem Kasir
- Aplikasi CRUD
- Desktop Application
- Web Application
- Game
- Backend/API

Belajar tidak berhenti di sini.

    Learn → Practice → Build → Improve

**Selamat, kamu telah menyelesaikan perjalanan belajar dasar C#! 🚀**