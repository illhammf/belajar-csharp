# 📦 Pertemuan 2 — Variable, Data Type, dan Input

Pada pertemuan sebelumnya kita sudah membuat program sederhana menggunakan `Console.WriteLine()` dan `Console.Write()`.

Sekarang kita mulai belajar bagaimana program **menyimpan data** dan **menerima data dari pengguna**.

Konsep yang akan dipelajari:

- Variable
- Data Type
- String
- Integer
- Decimal
- Boolean
- Input dengan `Console.ReadLine()`
- Konversi data menggunakan `int.Parse()`
- Konversi data menggunakan `double.Parse()`
- Konversi data menggunakan `bool.Parse()`
- String interpolation

---

## 🎯 Tujuan Pembelajaran

Setelah menyelesaikan pertemuan ini, diharapkan dapat:

- Memahami apa itu variable.
- Membuat variable dalam C#.
- Memahami beberapa data type dasar.
- Menyimpan teks dan angka ke dalam variable.
- Menerima input dari pengguna.
- Mengubah input menjadi tipe data tertentu.
- Menampilkan nilai variable ke console.
- Memahami penggunaan string interpolation.

---

## 📚 Materi

## 1. Apa Itu Variable?

Variable adalah tempat untuk menyimpan sebuah nilai di dalam program.

Contohnya:

```csharp
string nama = "Ilham";
```

Pada kode tersebut:

```text
string
↓
Tipe data

nama
↓
Nama variable

"Ilham"
↓
Nilai yang disimpan
```

Secara sederhana:

```text
Variable
   ↓
Tempat menyimpan data
   ↓
Memiliki tipe data dan nilai
```

---

## 2. Membuat Variable

Syntax dasar membuat variable:

```csharp
tipeData namaVariable = nilai;
```

Contoh:

```csharp
string nama = "Ilham";
int umur = 20;
```

Kita memiliki dua variable:

```text
nama → "Ilham"
umur → 20
```

---

## 3. String

`string` digunakan untuk menyimpan teks.

Contoh:

```csharp
string nama = "Ilham";
string kota = "Bogor";
```

Menampilkan variable:

```csharp
Console.WriteLine(nama);
Console.WriteLine(kota);
```

Output:

```text
Ilham
Bogor
```

Teks biasanya ditulis menggunakan tanda petik:

```csharp
"Hello"
"Ilham"
"Belajar C#"
```

---

## 4. Integer

`int` digunakan untuk menyimpan bilangan bulat.

Contoh:

```csharp
int umur = 20;
int jumlah = 10;
int nilai = 90;
```

Tidak menggunakan tanda petik:

```csharp
int umur = 20;
```

Bukan:

```csharp
int umur = "20";
```

Karena `"20"` dianggap sebagai `string`, bukan angka.

---

## 5. Double

`double` digunakan untuk menyimpan angka yang memiliki nilai desimal.

Contoh:

```csharp
double tinggi = 170.5;
double berat = 60.5;
```

Contoh lainnya:

```csharp
double harga = 15000.50;
```

---

## 6. Boolean

`bool` hanya memiliki dua nilai:

```text
true
false
```

Contoh:

```csharp
bool sudahBelajar = true;
bool sudahLulus = false;
```

Boolean biasanya digunakan untuk menyimpan kondisi.

Contoh:

```csharp
bool loginBerhasil = true;

Console.WriteLine(loginBerhasil);
```

Output:

```text
True
```

---

## 7. Beberapa Data Type Dasar

Berikut beberapa tipe data yang sering digunakan:

| Data Type | Fungsi | Contoh |
|---|---|---|
| `string` | Teks | `"Ilham"` |
| `int` | Bilangan bulat | `20` |
| `double` | Bilangan desimal | `80.5` |
| `float` | Bilangan desimal | `80.5f` |
| `bool` | Benar atau salah | `true` |
| `char` | Satu karakter | `'A'` |

Untuk tahap awal, fokus terlebih dahulu pada:

```text
string
int
double
bool
```

---

## 8. Mengubah Nilai Variable

Nilai sebuah variable dapat diubah setelah dibuat.

Contoh:

```csharp
int umur = 20;

Console.WriteLine(umur);

umur = 21;

Console.WriteLine(umur);
```

Output:

```text
20
21
```

Perhatikan bahwa kita tidak perlu menuliskan tipe data lagi ketika mengubah nilai:

```csharp
umur = 21;
```

Bukan:

```csharp
int umur = 21;
```

---

## 9. Input dari Pengguna

Program tidak hanya menampilkan informasi.

Program juga dapat menerima input dari pengguna.

Untuk membaca input dari console, kita dapat menggunakan:

```csharp
Console.ReadLine();
```

Contoh:

```csharp
Console.Write("Masukkan nama: ");

string nama = Console.ReadLine();

Console.WriteLine("Halo, " + nama);
```

Contoh ketika program dijalankan:

```text
Masukkan nama: Ilham
Halo, Ilham
```

---

## 10. Console.ReadLine()

`Console.ReadLine()` digunakan untuk membaca input dari pengguna sampai pengguna menekan tombol Enter.

Contoh:

```csharp
Console.Write("Masukkan nama: ");
string nama = Console.ReadLine();
```

Jika pengguna memasukkan:

```text
Ilham
```

Maka variable:

```text
nama
```

akan berisi:

```text
"Ilham"
```

---

## 11. Input Selalu Berupa String

Hal penting yang harus dipahami:

```csharp
Console.ReadLine()
```

membaca input sebagai `string`.

Contohnya:

```csharp
Console.Write("Masukkan umur: ");

string umur = Console.ReadLine();
```

Walaupun pengguna mengetik:

```text
20
```

data tersebut masih dianggap sebagai:

```text
"20"
```

bukan:

```text
20
```

Karena itu, jika ingin menggunakan input sebagai angka, kita perlu melakukan konversi.

---

## 12. Konversi String ke Integer

Untuk mengubah string menjadi `int`, kita dapat menggunakan:

```csharp
int.Parse()
```

Contoh:

```csharp
Console.Write("Masukkan umur: ");

int umur = int.Parse(Console.ReadLine());

Console.WriteLine("Umur kamu adalah " + umur);
```

Jika input:

```text
20
```

Maka nilai `umur` menjadi integer:

```text
20
```

---

## 13. Konversi String ke Double

Untuk mengubah input menjadi `double`:

```csharp
double.Parse()
```

Contoh:

```csharp
Console.Write("Masukkan tinggi badan: ");

double tinggi = double.Parse(Console.ReadLine());

Console.WriteLine("Tinggi kamu: " + tinggi);
```

Contoh input:

```text
170.5
```

Output:

```text
Tinggi kamu: 170.5
```

---

## 14. Konversi String ke Boolean

Untuk mengubah string menjadi `bool`:

```csharp
bool.Parse()
```

Contoh:

```csharp
Console.Write("Apakah kamu mahasiswa? ");

bool mahasiswa = bool.Parse(Console.ReadLine());

Console.WriteLine("Status mahasiswa: " + mahasiswa);
```

Input:

```text
true
```

Output:

```text
Status mahasiswa: True
```

Untuk saat ini, cukup pahami konsep konversinya terlebih dahulu.

---

## 15. String Concatenation

Kita dapat menggabungkan beberapa string menggunakan operator `+`.

Contoh:

```csharp
string nama = "Ilham";
int umur = 20;

Console.WriteLine("Nama saya " + nama);
Console.WriteLine("Umur saya " + umur);
```

Output:

```text
Nama saya Ilham
Umur saya 20
```

---

## 16. String Interpolation

C# juga menyediakan cara yang lebih nyaman untuk menggabungkan variable dengan teks menggunakan **string interpolation**.

Caranya menggunakan tanda `$` sebelum string.

Contoh:

```csharp
string nama = "Ilham";
int umur = 20;

Console.WriteLine($"Nama saya {nama}");
Console.WriteLine($"Umur saya {umur}");
```

Output:

```text
Nama saya Ilham
Umur saya 20
```

Kita juga dapat memasukkan beberapa variable sekaligus:

```csharp
string nama = "Ilham";
int umur = 20;
string kota = "Bogor";

Console.WriteLine($"Nama: {nama}, Umur: {umur}, Kota: {kota}");
```

Output:

```text
Nama: Ilham, Umur: 20, Kota: Bogor
```

String interpolation akan sering kita gunakan pada program C#.

---

## 17. Contoh Program Biodata

Sekarang kita gabungkan beberapa konsep:

```csharp
string nama = "Ilham";
int umur = 20;
string kota = "Bogor";
double tinggi = 170.5;
bool mahasiswa = true;

Console.WriteLine($"Nama      : {nama}");
Console.WriteLine($"Umur      : {umur}");
Console.WriteLine($"Kota      : {kota}");
Console.WriteLine($"Tinggi    : {tinggi}");
Console.WriteLine($"Mahasiswa : {mahasiswa}");
```

Output:

```text
Nama      : Ilham
Umur      : 20
Kota      : Bogor
Tinggi    : 170.5
Mahasiswa : True
```

---

## 18. Contoh Program dengan Input

Sekarang kita buat program yang datanya berasal dari pengguna.

```csharp
Console.Write("Masukkan nama: ");
string nama = Console.ReadLine();

Console.Write("Masukkan umur: ");
int umur = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("=== DATA ===");
Console.WriteLine($"Nama : {nama}");
Console.WriteLine($"Umur : {umur}");
```

Contoh penggunaan:

```text
Masukkan nama: Ilham
Masukkan umur: 20

=== DATA ===
Nama : Ilham
Umur : 20
```

---

## ⚠️ Kesalahan yang Sering Terjadi

### 1. Salah tipe data

Contoh:

```csharp
int umur = "20";
```

Ini salah karena `"20"` adalah string.

Yang benar:

```csharp
int umur = 20;
```

---

### 2. Lupa melakukan parsing

Contoh:

```csharp
int umur = Console.ReadLine();
```

Ini tidak sesuai karena `Console.ReadLine()` menghasilkan string.

Gunakan:

```csharp
int umur = int.Parse(Console.ReadLine());
```

---

### 3. Memasukkan teks ketika program meminta angka

Jika program menggunakan:

```csharp
int umur = int.Parse(Console.ReadLine());
```

kemudian pengguna memasukkan:

```text
dua puluh
```

program dapat menghasilkan error karena `"dua puluh"` bukan angka integer.

Penanganan input yang lebih aman akan kita pelajari pada materi **Exception Handling**.

---

## 🧠 Ringkasan

```text
Variable
↓
Tempat menyimpan data

string
↓
Menyimpan teks

int
↓
Menyimpan bilangan bulat

double
↓
Menyimpan bilangan desimal

bool
↓
Menyimpan true / false

Console.ReadLine()
↓
Membaca input dari pengguna sebagai string

int.Parse()
↓
Mengubah string menjadi int

double.Parse()
↓
Mengubah string menjadi double

bool.Parse()
↓
Mengubah string menjadi bool

$"...{variable}"
↓
String interpolation
```

---

## 📝 Latihan

### Latihan 1 — Biodata

Buat program yang meminta pengguna memasukkan:

```text
Nama
Umur
Kota
```

Kemudian tampilkan kembali datanya.

Contoh:

```text
Masukkan nama: Ilham
Masukkan umur: 20
Masukkan kota: Bogor

=== BIODATA ===
Nama : Ilham
Umur : 20
Kota : Bogor
```

---

### Latihan 2 — Persegi Panjang

Buat program yang meminta:

```text
Panjang
Lebar
```

Kemudian hitung luas persegi panjang.

Rumus:

```text
Luas = Panjang × Lebar
```

Contoh:

```text
Masukkan panjang: 10
Masukkan lebar: 5

Luas = 50
```

---

### Latihan 3 — Nilai Mahasiswa

Buat program yang meminta pengguna memasukkan:

```text
Nama
Nilai
```

Kemudian tampilkan:

```text
=== DATA MAHASISWA ===
Nama  : Ilham
Nilai : 90
```

Untuk saat ini belum perlu menentukan grade atau lulus/tidak lulus.

Konsep percabangan akan kita pelajari pada pertemuan berikutnya.

---

## ✅ Checklist

- [ ] Memahami variable
- [ ] Memahami `string`
- [ ] Memahami `int`
- [ ] Memahami `double`
- [ ] Memahami `bool`
- [ ] Memahami `Console.ReadLine()`
- [ ] Memahami `int.Parse()`
- [ ] Memahami `double.Parse()`
- [ ] Memahami `bool.Parse()`
- [ ] Memahami string concatenation
- [ ] Memahami string interpolation
- [ ] Membuat program dengan input pengguna
- [ ] Mengerjakan latihan

---

## 🚀 Selanjutnya

Pada **Pertemuan 3**, kita akan mempelajari:

> **Operator dalam C#**

Kita akan belajar bagaimana melakukan operasi matematika, perbandingan, dan logika di dalam program.

Materi utama:

```text
Arithmetic Operator
Assignment Operator
Comparison Operator
Logical Operator
Increment & Decrement
```

---

**Happy Coding! 🚀**

> Repository ini dibuat sebagai dokumentasi proses belajar C# dari dasar hingga intermediate.