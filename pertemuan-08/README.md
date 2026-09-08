# Pertemuan 08 — String

Pada pertemuan ini kita belajar tentang **String** di C#.

String digunakan untuk menyimpan data berupa teks, seperti:

    Nama
    Alamat
    Email
    Kalimat
    Pesan

Contoh:

    string nama = "Ilham";

String sangat sering digunakan dalam program karena hampir semua aplikasi membutuhkan pengolahan teks.

---

## 1. Membuat String

Untuk membuat string, kita menggunakan tipe data `string`.

Contoh:

    string nama = "Ilham";
    string kampus = "Universitas Contoh";

Kemudian kita dapat menampilkannya:

    Console.WriteLine(nama);
    Console.WriteLine(kampus);

Output:

    Ilham
    Universitas Contoh

String ditulis menggunakan tanda kutip ganda `" "`.

---

## 2. Input String

Kita dapat menerima input teks dari user menggunakan `Console.ReadLine()`.

Contoh:

    Console.Write("Masukkan nama: ");
    string nama = Console.ReadLine() ?? "";

    Console.WriteLine($"Halo, {nama}!");

Jika user memasukkan:

    Ilham

Output:

    Halo, Ilham!

`Console.ReadLine()` digunakan untuk membaca input dari user.

---

## 3. ReadLine dan String Kosong

`Console.ReadLine()` dapat menghasilkan `null`.

Untuk memastikan variabel memiliki string, kita dapat menggunakan:

    string nama = Console.ReadLine() ?? "";

Operator `??` digunakan untuk memberikan nilai cadangan jika nilai sebelumnya adalah `null`.

Untuk tahap awal, kamu bisa menggunakan pola tersebut saat mengambil input string.

---

## 4. String Length

Property `Length` digunakan untuk mengetahui jumlah karakter dalam string.

Contoh:

    string nama = "Ilham";

    Console.WriteLine(nama.Length);

Output:

    5

Karena:

    I
    l
    h
    a
    m

memiliki 5 karakter.

Spasi juga dihitung sebagai karakter.

Contoh:

    string nama = "Ilham MF";

    Console.WriteLine(nama.Length);

---

## 5. Mengakses Karakter String

String dapat diakses menggunakan index.

Index dimulai dari `0`.

Contoh:

    string nama = "Ilham";

    Console.WriteLine(nama[0]);
    Console.WriteLine(nama[1]);
    Console.WriteLine(nama[2]);

Output:

    I
    l
    h

Index:

    0 → I
    1 → l
    2 → h
    3 → a
    4 → m

Konsep ini mirip dengan index pada array.

---

## 6. Looping String

Karena string memiliki index dan `Length`, kita dapat menggunakan looping untuk membaca setiap karakter.

Contoh:

    string nama = "Ilham";

    for (int i = 0; i < nama.Length; i++)
    {
        Console.WriteLine(nama[i]);
    }

Output:

    I
    l
    h
    a
    m

Dengan cara ini kita dapat memproses setiap karakter satu per satu.

---

## 7. Mengubah String

String memiliki beberapa method yang dapat digunakan untuk menghasilkan versi teks yang berbeda.

Contoh mengubah menjadi huruf besar:

    string nama = "Ilham";

    Console.WriteLine(nama.ToUpper());

Output:

    ILHAM

Mengubah menjadi huruf kecil:

    Console.WriteLine(nama.ToLower());

Output:

    ilham

Method `ToUpper()` membuat string menjadi huruf besar.

Method `ToLower()` membuat string menjadi huruf kecil.

---

## 8. Concatenate String

Concatenate berarti **menggabungkan beberapa string**.

Contoh:

    string namaDepan = "Ilham";
    string namaBelakang = "Firmansyah";

    string namaLengkap = namaDepan + " " + namaBelakang;

    Console.WriteLine(namaLengkap);

Output:

    Ilham Firmansyah

Kita juga dapat menggunakan string interpolation:

    string namaLengkap = $"{namaDepan} {namaBelakang}";

Cara ini biasanya lebih mudah dibaca.

---

## 9. String Interpolation

String interpolation menggunakan `$` sebelum string.

Contoh:

    string nama = "Ilham";
    int umur = 20;

    Console.WriteLine($"Nama: {nama}");
    Console.WriteLine($"Umur: {umur}");

Output:

    Nama: Ilham
    Umur: 20

String interpolation sangat berguna ketika kita ingin memasukkan nilai variabel ke dalam teks.

---

## 10. Membandingkan String

Kita dapat membandingkan dua string menggunakan operator `==`.

Contoh:

    string nama1 = "Ilham";
    string nama2 = "Ilham";

    if (nama1 == nama2)
    {
        Console.WriteLine("Nama sama");
    }
    else
    {
        Console.WriteLine("Nama berbeda");
    }

Output:

    Nama sama

Kita juga dapat menggunakan `!=` untuk mengecek apakah dua string berbeda.

---

## 11. Contains

Method `Contains()` digunakan untuk mengecek apakah sebuah string mengandung teks tertentu.

Contoh:

    string kalimat = "Saya sedang belajar C#";

    if (kalimat.Contains("C#"))
    {
        Console.WriteLine("Teks ditemukan");
    }

Output:

    Teks ditemukan

`Contains()` menghasilkan nilai `true` atau `false`.

---

## 12. StartsWith

`StartsWith()` digunakan untuk mengecek apakah string dimulai dengan teks tertentu.

Contoh:

    string nama = "Ilham";

    if (nama.StartsWith("Il"))
    {
        Console.WriteLine("String dimulai dengan 'Il'");
    }

Output:

    String dimulai dengan 'Il'

---

## 13. EndsWith

`EndsWith()` digunakan untuk mengecek apakah string diakhiri dengan teks tertentu.

Contoh:

    string file = "belajar.cs";

    if (file.EndsWith(".cs"))
    {
        Console.WriteLine("File adalah file C#");
    }

Output:

    File adalah file C#

---

## 14. Find / IndexOf

Method `IndexOf()` digunakan untuk mencari posisi sebuah karakter atau teks.

Contoh:

    string nama = "Ilham";

    int posisi = nama.IndexOf("h");

    Console.WriteLine(posisi);

Output:

    2

Karakter `h` berada pada index `2`.

Jika teks tidak ditemukan, `IndexOf()` akan menghasilkan `-1`.

---

## 15. Replace

`Replace()` digunakan untuk mengganti bagian tertentu dari string.

Contoh:

    string kalimat = "Saya belajar Java";

    string hasil = kalimat.Replace("Java", "C#");

    Console.WriteLine(hasil);

Output:

    Saya belajar C#

`Replace()` tidak mengubah string asli secara langsung, tetapi menghasilkan string baru.

---

## 16. Substring

`Substring()` digunakan untuk mengambil sebagian teks dari sebuah string.

Contoh:

    string nama = "Ilham";

    string bagian = nama.Substring(0, 3);

    Console.WriteLine(bagian);

Output:

    Ilh

Angka pertama menentukan index awal.

Angka kedua menentukan jumlah karakter yang diambil.

---

## 17. Trim

`Trim()` digunakan untuk menghapus spasi di awal dan akhir string.

Contoh:

    string nama = "   Ilham   ";

    string hasil = nama.Trim();

    Console.WriteLine(hasil);

Hasilnya:

    Ilham

Ini berguna ketika user memasukkan input yang memiliki spasi tambahan.

---

## 18. String Array

String juga dapat disimpan dalam array.

Contoh:

    string[] nama = { "Ilham", "Budi", "Andi", "Siti" };

Kita dapat menampilkan semua nama menggunakan looping:

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

## 19. Menghitung Jumlah Karakter

Kita dapat menggunakan looping untuk menghitung karakter tertentu.

Contoh menghitung jumlah huruf `a`:

    string teks = "Saya belajar C#";

    int jumlah = 0;

    for (int i = 0; i < teks.Length; i++)
    {
        if (teks[i] == 'a')
        {
            jumlah++;
        }
    }

    Console.WriteLine($"Jumlah huruf a: {jumlah}");

Perhatikan bahwa:

    'a'

menggunakan tanda kutip satu karena merupakan satu karakter (`char`).

Sedangkan:

    "a"

merupakan string.

---

## 20. String dan Function

String dapat dikirim sebagai parameter ke function.

Contoh:

    static void TampilkanNama(string nama)
    {
        Console.WriteLine($"Nama: {nama}");
    }

Kemudian:

    TampilkanNama("Ilham");

Function juga dapat mengembalikan string.

Contoh:

    static string UbahHurufBesar(string teks)
    {
        return teks.ToUpper();
    }

Kemudian:

    string hasil = UbahHurufBesar("belajar c#");

    Console.WriteLine(hasil);

Output:

    BELAJAR C#

---

## 21. Contoh Program Data Siswa

Kita dapat menggabungkan string dengan input dan kondisi.

Contoh:

    Console.Write("Masukkan nama: ");
    string nama = Console.ReadLine() ?? "";

    Console.Write("Masukkan kelas: ");
    string kelas = Console.ReadLine() ?? "";

    Console.WriteLine();
    Console.WriteLine("=== DATA SISWA ===");
    Console.WriteLine($"Nama  : {nama}");
    Console.WriteLine($"Kelas : {kelas}");

Konsep ini merupakan dasar dari program yang menerima dan mengolah data teks.

---

## 22. Kesimpulan

Pada pertemuan ini kita telah mempelajari:

- Membuat string
- Input string
- `Console.ReadLine()`
- `Length`
- Index string
- Looping string
- `ToUpper()`
- `ToLower()`
- Concatenate
- String interpolation
- Membandingkan string
- `Contains()`
- `StartsWith()`
- `EndsWith()`
- `IndexOf()`
- `Replace()`
- `Substring()`
- `Trim()`
- String array
- Menghitung karakter
- String dengan function
- Mengolah data siswa

String merupakan salah satu tipe data yang paling sering digunakan dalam aplikasi karena digunakan untuk menangani berbagai macam data teks.

---

## Struktur File

    pertemuan-08/
    ├── README.md
    ├── 01_string.cs
    ├── 02_input_string.cs
    ├── 03_string_length.cs
    ├── 04_string_char.cs
    ├── 05_string_loop.cs
    ├── 06_string_modify.cs
    ├── 07_string_concatenate.cs
    ├── 08_string_compare.cs
    ├── 09_string_contains.cs
    ├── 10_string_find.cs
    ├── 11_string_replace.cs
    ├── 12_string_substring.cs
    ├── 13_string_trim.cs
    ├── 14_string_array.cs
    ├── 15_count_character.cs
    ├── 16_string_function.cs
    └── 17_data_siswa.cs

---

## Cara Menjalankan

Gunakan `run.ps1` dari folder utama project.

Contoh:

    .\run.ps1 pertemuan-08/01_string.cs

Contoh lainnya:

    .\run.ps1 pertemuan-08/05_string_loop.cs

    .\run.ps1 pertemuan-08/10_string_find.cs

    .\run.ps1 pertemuan-08/17_data_siswa.cs

---

## Next

➡️ **Pertemuan 09 — Object-Oriented Programming dasar / Class & Object**