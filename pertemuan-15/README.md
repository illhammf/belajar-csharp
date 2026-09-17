# Pertemuan 15 — Collections

## Pengertian Collections

Collections adalah kumpulan data yang digunakan untuk menyimpan banyak nilai dalam satu variabel.

Sebelumnya kita sudah belajar **Array**:

    int[] angka = { 10, 20, 30 };

Array memiliki ukuran yang tetap. Jika kita membutuhkan kumpulan data yang lebih fleksibel, C# menyediakan berbagai jenis **Collections**.

Contoh Collection yang akan dipelajari:

- `List<T>`
- `Dictionary<TKey, TValue>`

Pada pertemuan ini kita akan fokus terlebih dahulu pada `List<T>` dan `Dictionary<TKey, TValue>`.

---

# 1. List<T>

`List<T>` digunakan untuk menyimpan banyak data dengan tipe yang sama.

Contoh:

    List<int> angka = new List<int>();

Artinya kita membuat sebuah `List` yang hanya dapat menyimpan data bertipe `int`.

Jangan lupa menggunakan:

    using System.Collections.Generic;

---

# 2. Membuat List

Contoh membuat List kosong:

    List<int> angka = new List<int>();

Kita juga bisa langsung memberikan data:

    List<int> angka = new List<int> { 10, 20, 30 };

Contoh:

    using System;
    using System.Collections.Generic;

    List<int> angka = new List<int> { 10, 20, 30 };

    Console.WriteLine(angka[0]);

Output:

    10

---

# 3. Menambahkan Data dengan Add()

Untuk menambahkan data ke dalam `List`, gunakan `Add()`.

Contoh:

    List<string> nama = new List<string>();

    nama.Add("Ilham");
    nama.Add("Budi");
    nama.Add("Andi");

Sekarang List berisi:

    Ilham
    Budi
    Andi

---

# 4. Mengakses Data List

Data dalam `List` dapat diakses menggunakan index.

Index dimulai dari `0`.

Contoh:

    List<string> nama = new List<string>
    {
        "Ilham",
        "Budi",
        "Andi"
    };

    Console.WriteLine(nama[0]);
    Console.WriteLine(nama[1]);
    Console.WriteLine(nama[2]);

Output:

    Ilham
    Budi
    Andi

---

# 5. Mengubah Data List

Data dalam List dapat diubah menggunakan index.

Contoh:

    List<string> nama = new List<string>
    {
        "Ilham",
        "Budi",
        "Andi"
    };

    nama[1] = "Rizky";

    Console.WriteLine(nama[1]);

Output:

    Rizky

Data `"Budi"` berubah menjadi `"Rizky"`.

---

# 6. Menghapus Data dengan Remove()

`Remove()` digunakan untuk menghapus data berdasarkan nilainya.

Contoh:

    List<string> nama = new List<string>
    {
        "Ilham",
        "Budi",
        "Andi"
    };

    nama.Remove("Budi");

Sekarang List menjadi:

    Ilham
    Andi

`Remove()` akan menghapus data yang sesuai dengan nilai yang diberikan.

---

# 7. Menghapus Data dengan RemoveAt()

`RemoveAt()` digunakan untuk menghapus data berdasarkan index.

Contoh:

    List<string> nama = new List<string>
    {
        "Ilham",
        "Budi",
        "Andi"
    };

    nama.RemoveAt(1);

Index `1` adalah `"Budi"`, sehingga data tersebut dihapus.

Hasil:

    Ilham
    Andi

Perbedaan:

- `Remove()` → berdasarkan nilai
- `RemoveAt()` → berdasarkan index

---

# 8. Menghitung Jumlah Data dengan Count

Untuk mengetahui jumlah data dalam `List`, gunakan `Count`.

Contoh:

    List<int> angka = new List<int>
    {
        10,
        20,
        30,
        40
    };

    Console.WriteLine(angka.Count);

Output:

    4

Berbeda dengan Array yang menggunakan `Length`, `List` menggunakan `Count`.

---

# 9. Looping List

List dapat digunakan bersama `for`.

Contoh:

    List<string> nama = new List<string>
    {
        "Ilham",
        "Budi",
        "Andi"
    };

    for (int i = 0; i < nama.Count; i++)
    {
        Console.WriteLine(nama[i]);
    }

Kita juga dapat menggunakan `foreach`.

Contoh:

    foreach (string item in nama)
    {
        Console.WriteLine(item);
    }

`foreach` sangat cocok digunakan ketika kita hanya ingin membaca semua data.

---

# 10. Contains()

`Contains()` digunakan untuk mengecek apakah suatu data terdapat di dalam List.

Contoh:

    List<string> nama = new List<string>
    {
        "Ilham",
        "Budi",
        "Andi"
    };

    if (nama.Contains("Ilham"))
    {
        Console.WriteLine("Ilham ditemukan.");
    }

`Contains()` menghasilkan nilai:

- `true` jika data ditemukan
- `false` jika data tidak ditemukan

---

# 11. IndexOf()

`IndexOf()` digunakan untuk mencari posisi index suatu data.

Contoh:

    List<string> nama = new List<string>
    {
        "Ilham",
        "Budi",
        "Andi"
    };

    int index = nama.IndexOf("Budi");

    Console.WriteLine(index);

Output:

    1

Jika data tidak ditemukan, `IndexOf()` akan menghasilkan `-1`.

Contoh:

    int index = nama.IndexOf("Rizky");

    Console.WriteLine(index);

Output:

    -1

---

# 12. Sort()

`Sort()` digunakan untuk mengurutkan data.

Contoh:

    List<int> angka = new List<int>
    {
        40,
        10,
        30,
        20
    };

    angka.Sort();

    foreach (int item in angka)
    {
        Console.WriteLine(item);
    }

Output:

    10
    20
    30
    40

Secara default, `Sort()` mengurutkan dari kecil ke besar untuk angka.

---

# 13. Reverse()

`Reverse()` digunakan untuk membalik urutan data.

Contoh:

    List<int> angka = new List<int>
    {
        10,
        20,
        30,
        40
    };

    angka.Reverse();

    foreach (int item in angka)
    {
        Console.WriteLine(item);
    }

Output:

    40
    30
    20
    10

`Reverse()` membalik urutan data yang sedang ada.

---

# 14. Dictionary<TKey, TValue>

Selain `List`, C# juga memiliki `Dictionary`.

`Dictionary` digunakan untuk menyimpan data dalam bentuk:

    Key → Value

Contoh:

    Dictionary<string, int> umur = new Dictionary<string, int>();

Artinya:

- `string` → tipe Key
- `int` → tipe Value

Contoh:

    umur["Ilham"] = 20;
    umur["Budi"] = 21;
    umur["Andi"] = 19;

Kita dapat mengakses data menggunakan Key.

    Console.WriteLine(umur["Ilham"]);

Output:

    20

---

# 15. Menambahkan Data ke Dictionary

Kita juga dapat menggunakan `Add()`.

Contoh:

    Dictionary<string, int> nilai = new Dictionary<string, int>();

    nilai.Add("Ilham", 90);
    nilai.Add("Budi", 80);
    nilai.Add("Andi", 85);

Strukturnya:

    Key     Value
    Ilham   90
    Budi    80
    Andi    85

---

# 16. Mengakses Data Dictionary

Untuk mengambil Value, gunakan Key.

Contoh:

    Dictionary<string, int> nilai = new Dictionary<string, int>
    {
        { "Ilham", 90 },
        { "Budi", 80 },
        { "Andi", 85 }
    };

    Console.WriteLine(nilai["Ilham"]);

Output:

    90

---

# 17. Looping Dictionary

Dictionary dapat di-loop menggunakan `foreach`.

Contoh:

    Dictionary<string, int> nilai = new Dictionary<string, int>
    {
        { "Ilham", 90 },
        { "Budi", 80 },
        { "Andi", 85 }
    };

    foreach (var item in nilai)
    {
        Console.WriteLine($"{item.Key}: {item.Value}");
    }

Output:

    Ilham: 90
    Budi: 80
    Andi: 85

`item.Key` digunakan untuk mengambil Key.

`item.Value` digunakan untuk mengambil Value.

---

# 18. List vs Array

Array:

    int[] angka = { 10, 20, 30 };

List:

    List<int> angka = new List<int>
    {
        10,
        20,
        30
    };

Perbedaan sederhana:

| Array | List |
|---|---|
| Ukuran tetap | Ukuran fleksibel |
| Menggunakan `Length` | Menggunakan `Count` |
| Tidak memiliki `Add()` | Memiliki `Add()` |
| Tidak memiliki `Remove()` | Memiliki `Remove()` |
| Cocok untuk data dengan ukuran tetap | Cocok untuk data yang dapat berubah |

---

# 19. Kapan Menggunakan List?

Gunakan `List<T>` ketika jumlah data dapat bertambah atau berkurang.

Contohnya:

- Daftar mahasiswa
- Daftar produk
- Daftar barang
- Daftar nilai
- Daftar tugas
- Daftar pengguna

Contoh:

    List<string> mahasiswa = new List<string>();

    mahasiswa.Add("Ilham");
    mahasiswa.Add("Budi");
    mahasiswa.Add("Andi");

    mahasiswa.Remove("Budi");

---

# 20. Kapan Menggunakan Dictionary?

Gunakan `Dictionary<TKey, TValue>` ketika setiap data memiliki pasangan Key dan Value.

Contohnya:

- Nama → Nilai
- Username → Password
- Kode barang → Nama barang
- ID mahasiswa → Nama mahasiswa
- Kode produk → Harga

Contoh:

    Dictionary<string, int> nilai = new Dictionary<string, int>();

    nilai["Ilham"] = 90;
    nilai["Budi"] = 80;

---

# 21. Struktur Program

Pada pertemuan ini kita akan menggunakan beberapa file:

    01_list.cs
    02_list_add.cs
    03_list_access.cs
    04_list_change.cs
    05_list_remove.cs
    06_list_remove_at.cs
    07_list_count.cs
    08_list_loop.cs
    09_list_contains.cs
    10_list_index_of.cs
    11_list_sort.cs
    12_list_reverse.cs
    13_dictionary.cs
    14_dictionary_loop.cs
    15_studi_kasus_collections.cs

Setiap file dibuat untuk mempelajari satu konsep secara bertahap.

---

# 22. Konsep Penting

Setelah menyelesaikan pertemuan ini, pahami fungsi dasar berikut:

    List<T>
    Add()
    Remove()
    RemoveAt()
    Count
    Contains()
    IndexOf()
    Sort()
    Reverse()

Dan untuk Dictionary:

    Dictionary<TKey, TValue>
    Add()
    Key
    Value

---

# 23. Contoh Sederhana

Contoh penggunaan List:

    List<string> buah = new List<string>();

    buah.Add("Apel");
    buah.Add("Mangga");
    buah.Add("Jeruk");

    foreach (string item in buah)
    {
        Console.WriteLine(item);
    }

Output:

    Apel
    Mangga
    Jeruk

Contoh penggunaan Dictionary:

    Dictionary<string, int> stok = new Dictionary<string, int>();

    stok["Apel"] = 10;
    stok["Mangga"] = 20;

    Console.WriteLine($"Stok Apel: {stok["Apel"]}");

---

# 24. Kesimpulan

Pada pertemuan ini kita belajar **Collections** pada C#.

Konsep utama yang dipelajari:

- `List<T>` untuk menyimpan kumpulan data yang fleksibel.
- `Add()` untuk menambahkan data.
- `Remove()` untuk menghapus berdasarkan nilai.
- `RemoveAt()` untuk menghapus berdasarkan index.
- `Count` untuk menghitung jumlah data.
- `Contains()` untuk mengecek keberadaan data.
- `IndexOf()` untuk mencari index data.
- `Sort()` untuk mengurutkan data.
- `Reverse()` untuk membalik urutan data.
- `Dictionary<TKey, TValue>` untuk menyimpan pasangan Key dan Value.
- `foreach` untuk melakukan looping pada Collections.

Collections sangat sering digunakan dalam aplikasi nyata karena data yang kita kelola biasanya tidak selalu memiliki jumlah yang tetap.

---

# 25. Challenge

Buat program **Daftar Nilai Mahasiswa** menggunakan `List<int>`.

Program harus dapat:

1. Memiliki beberapa nilai mahasiswa.
2. Menampilkan semua nilai.
3. Menampilkan jumlah mahasiswa.
4. Menampilkan nilai terbesar.
5. Menampilkan nilai terkecil.
6. Mengurutkan nilai.
7. Mengecek apakah nilai tertentu ada.
8. Menghitung rata-rata nilai.

Setelah itu, buat program kedua menggunakan:

    Dictionary<string, int>

Dengan format:

    Nama Mahasiswa → Nilai

Contoh:

    Ilham → 90
    Budi → 80
    Andi → 85

Kemudian tampilkan seluruh data menggunakan `foreach`.

---

# 26. Target Pertemuan

Setelah menyelesaikan Pertemuan 15, kamu diharapkan sudah memahami:

    Array
        ↓
    List<T>
        ↓
    Dictionary<TKey, TValue>
        ↓
    Collections

Materi berikutnya akan menjadi langkah lanjutan untuk mengolah Collections dengan lebih praktis menggunakan **LINQ**.