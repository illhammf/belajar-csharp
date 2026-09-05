# Pertemuan 05 — Looping / Perulangan

Pada pertemuan ini kita belajar tentang **looping (perulangan)** di C#.

Looping digunakan ketika kita ingin menjalankan kode yang sama beberapa kali tanpa harus menulis kode tersebut berulang-ulang.

Contohnya:

    Halo
    Halo
    Halo
    Halo
    Halo

Daripada menulis `Console.WriteLine()` sebanyak 5 kali, kita bisa menggunakan looping.

---

## 1. While

`while` digunakan untuk menjalankan kode selama kondisi bernilai `true`.

Contoh:

    int i = 1;

    while (i <= 5)
    {
        Console.WriteLine(i);
        i++;
    }

Output:

    1
    2
    3
    4
    5

Alur sederhananya:

    Cek kondisi
        ↓
    Kondisi true?
        ↓
    Jalankan kode
        ↓
    Update nilai
        ↓
    Kembali cek kondisi

Pastikan nilai yang digunakan dalam kondisi berubah agar tidak terjadi **infinite loop** atau perulangan tanpa akhir.

---

## 2. Do While

`do while` mirip dengan `while`, tetapi kode di dalam `do` akan dijalankan **minimal satu kali**.

Contoh:

    int i = 1;

    do
    {
        Console.WriteLine(i);
        i++;
    }
    while (i <= 5);

Perbedaannya:

- `while` mengecek kondisi terlebih dahulu.
- `do while` menjalankan kode terlebih dahulu, kemudian mengecek kondisi.

Contoh kondisi yang salah sejak awal:

    int i = 10;

    while (i < 5)
    {
        Console.WriteLine(i);
    }

Kode di atas tidak akan dijalankan.

Sedangkan:

    int i = 10;

    do
    {
        Console.WriteLine(i);
    }
    while (i < 5);

Tetap akan menampilkan `10` sebanyak satu kali.

---

## 3. For

`for` biasanya digunakan ketika jumlah perulangan sudah diketahui.

Contoh:

    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine(i);
    }

Output:

    1
    2
    3
    4
    5

Struktur `for`:

    for (inisialisasi; kondisi; perubahan)

Contoh:

    for (int i = 1; i <= 10; i++)

Artinya:

- `int i = 1` → nilai awal
- `i <= 10` → kondisi perulangan
- `i++` → menambah nilai `i` setiap perulangan

Urutannya:

    int i = 1
        ↓
    Cek i <= 10
        ↓
    Jalankan kode
        ↓
    i++
        ↓
    Cek kondisi lagi

---

## 4. Nested Loop

**Nested loop** adalah looping yang berada di dalam looping lainnya.

Contoh:

    for (int i = 1; i <= 3; i++)
    {
        for (int j = 1; j <= 3; j++)
        {
            Console.WriteLine($"i = {i}, j = {j}");
        }
    }

Loop luar akan menjalankan loop dalam sampai selesai.

Contoh sederhananya:

    for (int baris = 1; baris <= 3; baris++)
    {
        for (int kolom = 1; kolom <= 3; kolom++)
        {
            Console.Write("*");
        }

        Console.WriteLine();
    }

Output:

    ***
    ***
    ***

Nested loop sering digunakan untuk membuat pola atau mengolah data yang memiliki baris dan kolom.

---

## 5. Break

`break` digunakan untuk **menghentikan looping** sebelum kondisi akhirnya tercapai.

Contoh:

    for (int i = 1; i <= 10; i++)
    {
        if (i == 5)
        {
            break;
        }

        Console.WriteLine(i);
    }

Output:

    1
    2
    3
    4

Ketika `i` bernilai `5`, `break` menghentikan perulangan.

---

## 6. Continue

`continue` digunakan untuk **melewati satu iterasi** dan melanjutkan ke iterasi berikutnya.

Contoh:

    for (int i = 1; i <= 5; i++)
    {
        if (i == 3)
        {
            continue;
        }

        Console.WriteLine(i);
    }

Output:

    1
    2
    4
    5

Angka `3` tidak ditampilkan karena iterasi tersebut dilewati oleh `continue`.

Perbedaan sederhana:

- `break` → menghentikan seluruh looping.
- `continue` → melewati iterasi saat ini.

---

## 7. Looping + If

Looping dapat digabungkan dengan `if` untuk melakukan pengecekan pada setiap perulangan.

Contoh mencari angka genap:

    for (int i = 1; i <= 10; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    }

Output:

    2
    4
    6
    8
    10

Operator `%` digunakan untuk mendapatkan sisa hasil pembagian.

Jika:

    10 % 2 = 0

Maka angka tersebut adalah bilangan genap.

---

## 8. Menjumlahkan Angka dengan Looping

Looping juga bisa digunakan untuk menghitung jumlah beberapa angka.

Contoh:

    int total = 0;

    for (int i = 1; i <= 5; i++)
    {
        total += i;
    }

    Console.WriteLine($"Total: {total}");

Output:

    Total: 15

Prosesnya:

    total = 0

    total = 0 + 1
    total = 1 + 2
    total = 3 + 3
    total = 6 + 4
    total = 10 + 5

Hasil akhirnya adalah `15`.

---

## 9. Looping dengan Input User

Looping dapat digunakan bersama input dari user.

Contoh:

    Console.Write("Masukkan angka: ");
    int angka = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= angka; i++)
    {
        Console.WriteLine(i);
    }

Jika user memasukkan:

    5

Maka output:

    1
    2
    3
    4
    5

---

## 10. Contoh Program Tabel Perkalian

Kita bisa menggunakan looping untuk membuat tabel perkalian.

Contoh:

    Console.Write("Masukkan angka: ");
    int angka = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{angka} x {i} = {angka * i}");
    }

Jika user memasukkan `5`, hasilnya:

    5 x 1 = 5
    5 x 2 = 10
    5 x 3 = 15
    5 x 4 = 20
    5 x 5 = 25
    5 x 6 = 30
    5 x 7 = 35
    5 x 8 = 40
    5 x 9 = 45
    5 x 10 = 50

---

## 11. Perbandingan Jenis Looping

| Loop | Kapan digunakan? |
|---|---|
| `while` | Saat kondisi menjadi fokus utama |
| `do while` | Saat kode harus dijalankan minimal satu kali |
| `for` | Saat jumlah perulangan sudah diketahui |
| `break` | Saat ingin menghentikan loop |
| `continue` | Saat ingin melewati iterasi tertentu |
| Nested loop | Saat membutuhkan perulangan di dalam perulangan |

---

## 12. Kesimpulan

Pada pertemuan ini kita telah mempelajari:

- `while`
- `do while`
- `for`
- nested loop
- `break`
- `continue`
- Looping dengan `if`
- Menjumlahkan data menggunakan looping
- Menggunakan looping bersama input
- Membuat tabel perkalian

Looping merupakan konsep yang sangat penting dalam pemrograman karena memungkinkan kita menjalankan proses yang sama berkali-kali secara otomatis.

---

## Struktur File

    pertemuan-05/
    ├── README.md
    ├── 01_while.cs
    ├── 02_do_while.cs
    ├── 03_for.cs
    ├── 04_nested_loop.cs
    ├── 05_break.cs
    ├── 06_continue.cs
    ├── 07_loop_if.cs
    ├── 08_jumlah_angka.cs
    └── 09_tabel_perkalian.cs

---

## Cara Menjalankan

Gunakan `run.ps1` dari folder utama project.

Contoh:

    .\run.ps1 pertemuan-05/01_while.cs

Untuk menjalankan program lainnya:

    .\run.ps1 pertemuan-05/03_for.cs

    .\run.ps1 pertemuan-05/07_loop_if.cs

    .\run.ps1 pertemuan-05/09_tabel_perkalian.cs

---

## Next

➡️ **Pertemuan 06 — Function / Method**