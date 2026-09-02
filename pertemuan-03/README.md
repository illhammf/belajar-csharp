# 📘 Pertemuan 3 — Operator C#

> Belajar menggunakan berbagai macam operator dalam bahasa pemrograman C#.

---

## 🎯 Tujuan Pembelajaran

Pada pertemuan ini kita akan mempelajari bagaimana operator digunakan untuk melakukan operasi terhadap data dan variabel.

Setelah menyelesaikan pertemuan ini, diharapkan sudah memahami:

- Arithmetic Operator
- Assignment Operator
- Comparison Operator
- Logical Operator
- Increment dan Decrement
- Prefix dan Postfix
- Operator Precedence
- Ternary Operator
- Expression dalam C#

---

## 📚 Materi

### 1. Arithmetic Operator

Arithmetic Operator digunakan untuk melakukan operasi matematika.

| Operator | Nama | Contoh |
|---|---|---|
| `+` | Penjumlahan | `10 + 5` |
| `-` | Pengurangan | `10 - 5` |
| `*` | Perkalian | `10 * 5` |
| `/` | Pembagian | `10 / 5` |
| `%` | Modulus | `10 % 3` |

Contoh:

```csharp
int a = 10;
int b = 3;

Console.WriteLine(a + b);
Console.WriteLine(a - b);
Console.WriteLine(a * b);
Console.WriteLine(a / b);
Console.WriteLine(a % b);
```

Output:

```text
13
7
30
3
1
```

> `%` menghasilkan sisa pembagian.

---

### 2. Assignment Operator

Assignment Operator digunakan untuk memberikan atau mengubah nilai sebuah variabel.

Operator dasar:

```csharp
=
```

Contoh:

```csharp
int angka = 10;
```

Selain `=`, terdapat operator assignment lainnya.

| Operator | Contoh | Sama dengan |
|---|---|---|
| `=` | `a = 10` | `a = 10` |
| `+=` | `a += 5` | `a = a + 5` |
| `-=` | `a -= 5` | `a = a - 5` |
| `*=` | `a *= 5` | `a = a * 5` |
| `/=` | `a /= 5` | `a = a / 5` |
| `%=` | `a %= 5` | `a = a % 5` |

Contoh:

```csharp
int angka = 10;

angka += 5;

Console.WriteLine(angka);
```

Output:

```text
15
```

---

### 3. Comparison Operator

Comparison Operator digunakan untuk membandingkan dua nilai.

Hasil dari comparison operator adalah:

```csharp
true
```

atau

```csharp
false
```

Operator yang digunakan:

| Operator | Arti | Contoh |
|---|---|---|
| `==` | Sama dengan | `10 == 10` |
| `!=` | Tidak sama dengan | `10 != 5` |
| `>` | Lebih besar | `10 > 5` |
| `<` | Lebih kecil | `5 < 10` |
| `>=` | Lebih besar atau sama | `10 >= 10` |
| `<=` | Lebih kecil atau sama | `5 <= 10` |

Contoh:

```csharp
int nilaiA = 10;
int nilaiB = 5;

Console.WriteLine(nilaiA == nilaiB);
Console.WriteLine(nilaiA != nilaiB);
Console.WriteLine(nilaiA > nilaiB);
Console.WriteLine(nilaiA < nilaiB);
```

Output:

```text
False
True
True
False
```

---

## 4. Logical Operator

Logical Operator digunakan untuk menggabungkan atau membalik kondisi.

Operator utama:

| Operator | Nama | Contoh |
|---|---|---|
| `&&` | AND | `true && true` |
| `||` | OR | `true || false` |
| `!` | NOT | `!true` |

### AND `&&`

Kondisi akan bernilai `true` jika kedua kondisi bernilai `true`.

```csharp
bool memilikiKtp = true;
bool cukupUmur = true;

Console.WriteLine(memilikiKtp && cukupUmur);
```

Output:

```text
True
```

Jika salah satu kondisi `false`, hasilnya `false`.

---

### OR `||`

Kondisi akan bernilai `true` jika minimal salah satu kondisi bernilai `true`.

```csharp
bool memilikiKartu = true;
bool memilikiTiket = false;

Console.WriteLine(memilikiKartu || memilikiTiket);
```

Output:

```text
True
```

---

### NOT `!`

NOT digunakan untuk membalik nilai boolean.

```csharp
bool aktif = true;

Console.WriteLine(!aktif);
```

Output:

```text
False
```

---

## 5. Increment Operator

Increment digunakan untuk menambahkan nilai sebesar `1`.

Operator:

```csharp
++
```

Contoh:

```csharp
int angka = 10;

angka++;

Console.WriteLine(angka);
```

Output:

```text
11
```

Secara konsep:

```csharp
angka++;
```

sama dengan:

```csharp
angka = angka + 1;
```

---

## 6. Decrement Operator

Decrement digunakan untuk mengurangi nilai sebesar `1`.

Operator:

```csharp
--
```

Contoh:

```csharp
int angka = 10;

angka--;

Console.WriteLine(angka);
```

Output:

```text
9
```

Secara konsep:

```csharp
angka--;
```

sama dengan:

```csharp
angka = angka - 1;
```

---

## 7. Prefix dan Postfix

Increment dan decrement dapat digunakan sebelum atau sesudah variabel.

### Prefix

```csharp
++angka;
```

Nilai akan dinaikkan terlebih dahulu, kemudian digunakan.

Contoh:

```csharp
int angka = 10;

Console.WriteLine(++angka);
```

Output:

```text
11
```

---

### Postfix

```csharp
angka++;
```

Nilai digunakan terlebih dahulu, kemudian dinaikkan.

Contoh:

```csharp
int angka = 10;

Console.WriteLine(angka++);
Console.WriteLine(angka);
```

Output:

```text
10
11
```

---

### Perbandingan

Prefix:

```csharp
int angka = 10;

int hasil = ++angka;
```

Hasil:

```text
angka = 11
hasil = 11
```

Postfix:

```csharp
int angka = 10;

int hasil = angka++;
```

Hasil:

```text
angka = 11
hasil = 10
```

---

## 8. Expression

Expression adalah kombinasi dari nilai, variabel, operator, dan elemen lainnya yang menghasilkan sebuah nilai.

Contoh:

```csharp
int a = 10;
int b = 5;

int hasil = a + b;
```

Bagian:

```csharp
a + b
```

merupakan sebuah expression.

Contoh lainnya:

```csharp
int hasil = (10 + 5) * 2;
```

Expression tersebut menghasilkan:

```text
30
```

---

## 9. Operator Precedence

Jika terdapat beberapa operator dalam satu expression, C# memiliki aturan prioritas.

Contoh:

```csharp
int hasil = 10 + 5 * 2;
```

Hasilnya:

```text
20
```

Bukan:

```text
30
```

Karena perkalian memiliki prioritas lebih tinggi daripada penjumlahan.

Urutan sederhana:

1. `()`
2. `*`, `/`, `%`
3. `+`, `-`
4. Comparison
5. Logical

Contoh:

```csharp
int hasil = (10 + 5) * 2;
```

Hasil:

```text
30
```

Tanda kurung dapat digunakan untuk mengatur urutan operasi.

---

## 10. Ternary Operator

Ternary Operator merupakan cara singkat untuk membuat kondisi sederhana.

Bentuk dasar:

```csharp
kondisi ? nilaiJikaTrue : nilaiJikaFalse;
```

Contoh:

```csharp
int nilai = 80;

string hasil = nilai >= 75 ? "Lulus" : "Tidak Lulus";

Console.WriteLine(hasil);
```

Output:

```text
Lulus
```

Jika:

```csharp
int nilai = 60;
```

Output:

```text
Tidak Lulus
```

Ternary cocok digunakan untuk kondisi sederhana.

---

# 📂 Struktur File

Folder pertemuan ini akan berisi beberapa contoh program.

Contoh struktur:

```text
pertemuan-03/
│
├── 01_arithmetic_operator.cs
├── 02_assignment_operator.cs
├── 03_comparison_operator.cs
├── 04_logical_operator.cs
├── 05_increment_decrement.cs
├── 06_prefix_postfix.cs
├── 07_expression.cs
├── 08_operator_precedence.cs
├── 09_ternary_operator.cs
├── 10_kalkulator_sederhana.cs
├── 11_cek_nilai.cs
│
└── README.md
```

---

# 🧪 Latihan

## Latihan 1 — Arithmetic Operator

Buat program yang memiliki dua angka:

```text
Angka pertama : 20
Angka kedua   : 6
```

Kemudian tampilkan:

```text
Penjumlahan
Pengurangan
Perkalian
Pembagian
Sisa pembagian
```

---

## Latihan 2 — Comparison

Buat program untuk membandingkan dua nilai.

Contoh:

```text
Nilai A : 80
Nilai B : 75

A == B : False
A != B : True
A > B  : True
A < B  : False
```

---

## Latihan 3 — Logical Operator

Buat program sederhana untuk menentukan apakah seseorang dapat mengikuti sebuah kegiatan berdasarkan dua kondisi.

Contoh:

```text
Memiliki tiket : true
Terdaftar      : true

Boleh masuk : true
```

Gunakan:

```csharp
&&
```

---

## Latihan 4 — Increment dan Decrement

Buat program:

```text
int angka = 10;
```

Kemudian lakukan:

```text
angka++
angka++
angka--
```

Tampilkan hasil akhirnya.

---

## Latihan 5 — Ternary

Buat program untuk menentukan apakah nilai mahasiswa lulus.

Ketentuan:

```text
Nilai >= 75 → Lulus
Nilai < 75  → Tidak Lulus
```

Gunakan ternary operator.

---

# 🏆 Mini Project — Kalkulator Sederhana

Buat program kalkulator menggunakan operator arithmetic.

Input:

```text
Angka pertama
Operator
Angka kedua
```

Contoh:

```text
==============================
       KALKULATOR C#
==============================

Masukkan angka pertama : 20
Masukkan operator      : *
Masukkan angka kedua   : 5

Hasil : 100
```

Operator yang didukung:

```text
+
-
*
/
%
```

Gunakan operator dan percabangan sederhana untuk menentukan operasi.

---

# 💡 Catatan Penting

### `=` berbeda dengan `==`

```csharp
=
```

digunakan untuk assignment.

Contoh:

```csharp
int angka = 10;
```

Sedangkan:

```csharp
==
```

digunakan untuk comparison.

Contoh:

```csharp
angka == 10
```

---

### `++` dan `+= 1`

Keduanya dapat menaikkan nilai sebesar satu.

```csharp
angka++;
```

dan:

```csharp
angka += 1;
```

Namun prefix dan postfix memiliki perbedaan ketika digunakan dalam expression.

---

### Hati-hati dengan pembagian integer

Contoh:

```csharp
int a = 5;
int b = 2;

Console.WriteLine(a / b);
```

Hasil:

```text
2
```

Karena kedua variabel bertipe `int`.

Jika ingin hasil desimal:

```csharp
double a = 5;
double b = 2;

Console.WriteLine(a / b);
```

Hasil:

```text
2.5
```

---

# ▶️ Menjalankan Program

Karena setiap file `.cs` kita buat sebagai file latihan terpisah dan bukan project `.NET`, kita menggunakan script:

```text
run.ps1
```

Dari root repository:

```powershell
.\run.ps1 pertemuan-03/01_arithmetic_operator.cs
```

Contoh:

```powershell
.\run.ps1 pertemuan-03/10_kalkulator_sederhana.cs
```

Script akan melakukan proses compile dan menjalankan file C# tersebut.

---

# 🧠 Konsep yang Harus Dipahami

Sebelum lanjut ke pertemuan berikutnya, pastikan sudah memahami:

- [x] Arithmetic Operator
- [x] Assignment Operator
- [x] Comparison Operator
- [x] Logical Operator
- [x] Increment
- [x] Decrement
- [x] Prefix
- [x] Postfix
- [x] Expression
- [x] Operator Precedence
- [x] Ternary Operator

---

# 🚀 Roadmap Selanjutnya

Setelah memahami operator, kita akan masuk ke:

**Pertemuan 4 — Percabangan / Conditional Statement**

Materi:

```text
if
if-else
else-if
nested if
logical condition
ternary
```

Kemudian mulai membuat program yang dapat mengambil keputusan berdasarkan kondisi.

---

## 📌 Kesimpulan

Operator merupakan salah satu dasar penting dalam pemrograman C#.

Dengan operator, kita dapat:

- Melakukan perhitungan.
- Mengubah nilai variabel.
- Membandingkan data.
- Menggabungkan kondisi.
- Menambah atau mengurangi nilai.
- Membuat expression.
- Membuat kondisi sederhana menggunakan ternary.

Konsep operator akan terus digunakan pada materi berikutnya, terutama ketika mulai mempelajari **percabangan, perulangan, function, array, dan OOP**.

---

> 📚 **Belajar sedikit demi sedikit, pahami konsepnya, lalu praktikkan dengan kode.**
>
> **Next: Pertemuan 4 — Conditional Statement 🚀**