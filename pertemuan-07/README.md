# Pertemuan 07 — Array

Pada pertemuan ini kita belajar tentang **Array** di C#.

Array digunakan untuk menyimpan **banyak data dengan tipe yang sama** dalam satu variabel.

Contohnya, jika ingin menyimpan 5 nilai:

    int nilai1 = 80;
    int nilai2 = 75;
    int nilai3 = 90;
    int nilai4 = 85;
    int nilai5 = 70;

Cara tersebut bisa dibuat lebih sederhana menggunakan array:

    int[] nilai = { 80, 75, 90, 85, 70 };

Dengan array, banyak data dapat dikelola dengan lebih mudah.

---

## 1. Apa Itu Array?

Array adalah kumpulan data yang memiliki tipe data yang sama.

Contoh:

    int[] angka = { 10, 20, 30, 40, 50 };

Array tersebut memiliki 5 nilai bertipe `int`.

Contoh lainnya:

    string[] nama = { "Ilham", "Budi", "Andi" };

Semua data di dalam array tersebut bertipe `string`.

---

## 2. Membuat Array

Ada beberapa cara untuk membuat array.

Cara pertama:

    int[] angka = { 10, 20, 30, 40, 50 };

Cara kedua:

    int[] angka = new int[5];

Cara kedua membuat array dengan kapasitas 5 elemen.

Nilai awalnya adalah:

    0
    0
    0
    0
    0

Kita dapat mengisi nilainya satu per satu.

    angka[0] = 10;
    angka[1] = 20;
    angka[2] = 30;
    angka[3] = 40;
    angka[4] = 50;

---

## 3. Index Array

Array menggunakan **index** untuk mengakses setiap data.

Index array dimulai dari `0`, bukan `1`.

Contoh:

    int[] angka = { 10, 20, 30, 40, 50 };

Index:

    0 → 10
    1 → 20
    2 → 30
    3 → 40
    4 → 50

Untuk mengambil data:

    Console.WriteLine(angka[0]);

Output:

    10

Jika:

    Console.WriteLine(angka[3]);

Output:

    40

Jadi:

    angka[0] → elemen pertama
    angka[1] → elemen kedua
    angka[2] → elemen ketiga

---

## 4. Mengubah Nilai Array

Data di dalam array dapat diubah.

Contoh:

    int[] angka = { 10, 20, 30 };

    angka[1] = 100;

Sekarang array menjadi:

    10
    100
    30

Index `1` yang sebelumnya bernilai `20` berubah menjadi `100`.

---

## 5. Menampilkan Semua Data

Kita dapat menampilkan data array satu per satu.

Contoh:

    int[] angka = { 10, 20, 30, 40, 50 };

    Console.WriteLine(angka[0]);
    Console.WriteLine(angka[1]);
    Console.WriteLine(angka[2]);
    Console.WriteLine(angka[3]);
    Console.WriteLine(angka[4]);

Namun cara tersebut tidak praktis jika jumlah data sangat banyak.

Karena itu kita dapat menggunakan looping.

---

## 6. Array dengan For

Looping `for` sangat sering digunakan bersama array.

Contoh:

    int[] angka = { 10, 20, 30, 40, 50 };

    for (int i = 0; i < angka.Length; i++)
    {
        Console.WriteLine(angka[i]);
    }

Output:

    10
    20
    30
    40
    50

`Length` digunakan untuk mengetahui jumlah elemen dalam array.

Contoh:

    angka.Length

Jika array memiliki 5 elemen:

    angka.Length = 5

Karena index dimulai dari `0`, kondisi yang digunakan adalah:

    i < angka.Length

Bukan:

    i <= angka.Length

---

## 7. Array dengan Input User

Array juga dapat diisi berdasarkan input dari user.

Contoh:

    int[] angka = new int[5];

    for (int i = 0; i < angka.Length; i++)
    {
        Console.Write($"Masukkan angka ke-{i + 1}: ");
        angka[i] = Convert.ToInt32(Console.ReadLine());
    }

Program akan meminta user memasukkan 5 angka.

Setelah itu data dapat ditampilkan:

    for (int i = 0; i < angka.Length; i++)
    {
        Console.WriteLine(angka[i]);
    }

---

## 8. Menjumlahkan Semua Data Array

Array dapat digunakan untuk menghitung total data.

Contoh:

    int[] angka = { 10, 20, 30, 40, 50 };

    int total = 0;

    for (int i = 0; i < angka.Length; i++)
    {
        total += angka[i];
    }

    Console.WriteLine($"Total: {total}");

Output:

    Total: 150

Prosesnya:

    total = 0

    0 + 10 = 10
    10 + 20 = 30
    30 + 30 = 60
    60 + 40 = 100
    100 + 50 = 150

---

## 9. Mencari Nilai Terbesar

Kita dapat menggunakan looping untuk mencari nilai terbesar.

Contoh:

    int[] angka = { 10, 50, 30, 90, 20 };

    int terbesar = angka[0];

    for (int i = 1; i < angka.Length; i++)
    {
        if (angka[i] > terbesar)
        {
            terbesar = angka[i];
        }
    }

    Console.WriteLine($"Nilai terbesar: {terbesar}");

Output:

    Nilai terbesar: 90

Kita menggunakan elemen pertama sebagai nilai awal.

Kemudian setiap elemen dibandingkan dengan nilai terbesar sementara.

---

## 10. Mencari Nilai Terkecil

Konsepnya hampir sama dengan mencari nilai terbesar.

Contoh:

    int[] angka = { 10, 50, 30, 90, 20 };

    int terkecil = angka[0];

    for (int i = 1; i < angka.Length; i++)
    {
        if (angka[i] < terkecil)
        {
            terkecil = angka[i];
        }
    }

    Console.WriteLine($"Nilai terkecil: {terkecil}");

Output:

    Nilai terkecil: 10

---

## 11. Mencari Data dalam Array

Kita dapat mengecek apakah sebuah nilai terdapat di dalam array.

Contoh:

    int[] angka = { 10, 20, 30, 40, 50 };

    int cari = 30;
    bool ditemukan = false;

    for (int i = 0; i < angka.Length; i++)
    {
        if (angka[i] == cari)
        {
            ditemukan = true;
            break;
        }
    }

    if (ditemukan)
    {
        Console.WriteLine("Data ditemukan");
    }
    else
    {
        Console.WriteLine("Data tidak ditemukan");
    }

---

## 12. Menghitung Rata-rata Array

Kita juga dapat menghitung rata-rata dari semua data.

Contoh:

    int[] nilai = { 80, 75, 90, 85, 70 };

    int total = 0;

    for (int i = 0; i < nilai.Length; i++)
    {
        total += nilai[i];
    }

    double rataRata = (double)total / nilai.Length;

    Console.WriteLine($"Rata-rata: {rataRata}");

Output:

    Rata-rata: 80

Perhatikan penggunaan `(double)` agar hasil pembagian dapat memiliki nilai desimal.

---

## 13. Array dengan Function

Array dapat dikirim sebagai parameter ke dalam function.

Contoh:

    static void TampilkanArray(int[] angka)
    {
        for (int i = 0; i < angka.Length; i++)
        {
            Console.WriteLine(angka[i]);
        }
    }

Kemudian:

    int[] data = { 10, 20, 30, 40, 50 };

    TampilkanArray(data);

Function tersebut menerima seluruh array sebagai parameter.

---

## 14. Function untuk Menghitung Total Array

Kita juga dapat membuat function yang mengembalikan total nilai array.

Contoh:

    static int HitungTotal(int[] angka)
    {
        int total = 0;

        for (int i = 0; i < angka.Length; i++)
        {
            total += angka[i];
        }

        return total;
    }

Kemudian:

    int[] data = { 10, 20, 30, 40, 50 };

    int total = HitungTotal(data);

    Console.WriteLine($"Total: {total}");

Output:

    Total: 150

---

## 15. Array String

Array tidak hanya dapat digunakan untuk angka.

Kita juga dapat membuat array `string`.

Contoh:

    string[] nama = { "Ilham", "Budi", "Andi", "Siti" };

Untuk menampilkan semua nama:

    for (int i = 0; i < nama.Length; i++)
    {
        Console.WriteLine(nama[i]);
    }

Output:

    Ilham
    Budi
    Andi
    Siti

---

## 16. Array dan Kondisi

Array dapat digabungkan dengan `if`.

Contoh mencari nilai yang lulus:

    int[] nilai = { 60, 80, 75, 50, 90 };

    for (int i = 0; i < nilai.Length; i++)
    {
        if (nilai[i] >= 75)
        {
            Console.WriteLine($"Nilai {nilai[i]}: Lulus");
        }
        else
        {
            Console.WriteLine($"Nilai {nilai[i]}: Tidak Lulus");
        }
    }

Output:

    Nilai 60: Tidak Lulus
    Nilai 80: Lulus
    Nilai 75: Lulus
    Nilai 50: Tidak Lulus
    Nilai 90: Lulus

---

## 17. Array dan Looping

Array sangat sering digunakan bersama looping.

Konsep dasarnya:

    Array
        ↓
    Ambil index
        ↓
    Proses data
        ↓
    Pindah ke index berikutnya
        ↓
    Selesai

Contoh:

    int[] angka = { 10, 20, 30 };

    for (int i = 0; i < angka.Length; i++)
    {
        Console.WriteLine(angka[i]);
    }

Array menyimpan datanya, sedangkan looping membantu kita mengakses setiap data.

---

## 18. Kesimpulan

Pada pertemuan ini kita telah mempelajari:

- Apa itu array
- Membuat array
- Index array
- Mengakses data array
- Mengubah data array
- `Length`
- Array dengan `for`
- Array dengan input user
- Menjumlahkan data
- Mencari nilai terbesar
- Mencari nilai terkecil
- Mencari data
- Menghitung rata-rata
- Array dengan function
- Array `string`
- Array dengan `if`
- Array dengan looping

Array merupakan konsep penting karena hampir semua program yang mengolah banyak data akan membutuhkan struktur seperti ini.

---

## Struktur File

    pertemuan-07/
    ├── README.md
    ├── 01_array.cs
    ├── 02_index_array.cs
    ├── 03_ubah_array.cs
    ├── 04_array_loop.cs
    ├── 05_input_array.cs
    ├── 06_jumlah_array.cs
    ├── 07_nilai_terbesar.cs
    ├── 08_nilai_terkecil.cs
    ├── 09_cari_data.cs
    ├── 10_rata_rata.cs
    ├── 11_array_function.cs
    ├── 12_total_function.cs
    ├── 13_array_string.cs
    └── 14_array_nilai.cs

---

## Cara Menjalankan

Gunakan `run.ps1` dari folder utama project.

Contoh:

    .\run.ps1 pertemuan-07/01_array.cs

Contoh lainnya:

    .\run.ps1 pertemuan-07/05_input_array.cs

    .\run.ps1 pertemuan-07/09_cari_data.cs

    .\run.ps1 pertemuan-07/14_array_nilai.cs

---

## Next

➡️ **Pertemuan 08 — String**