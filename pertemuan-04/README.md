# Pertemuan 04 — Percabangan C#

Pada pertemuan ini kita belajar tentang percabangan atau conditional statement dalam C#.

Percabangan digunakan agar program dapat mengambil keputusan berdasarkan suatu kondisi.

## Materi

Materi yang dipelajari:

- if
- if else
- if else if
- Nested if
- Logical AND (&&)
- Logical OR (||)
- Logical NOT (!)
- Ternary Operator
- Percabangan dengan input

## 1. If

`if` digunakan untuk menjalankan kode jika sebuah kondisi bernilai benar.

Contoh:

if (nilai >= 75)
{
    Console.WriteLine("Lulus");
}

Jika kondisi `nilai >= 75` bernilai `true`, maka kode di dalam `if` akan dijalankan.

## 2. If Else

`if else` digunakan ketika terdapat dua kemungkinan.

Contoh:

if (nilai >= 75)
{
    Console.WriteLine("Lulus");
}
else
{
    Console.WriteLine("Tidak Lulus");
}

Jika kondisi benar, bagian `if` dijalankan.

Jika kondisi salah, bagian `else` dijalankan.

## 3. If Else If

`else if` digunakan ketika terdapat beberapa kondisi.

Contoh:

if (nilai >= 90)
{
    Console.WriteLine("Grade A");
}
else if (nilai >= 80)
{
    Console.WriteLine("Grade B");
}
else if (nilai >= 70)
{
    Console.WriteLine("Grade C");
}
else
{
    Console.WriteLine("Grade D");
}

Program akan memeriksa kondisi dari atas ke bawah.

## 4. Nested If

Nested `if` adalah `if` yang berada di dalam `if` lainnya.

Contoh:

if (umur >= 17)
{
    if (memilikiKtp)
    {
        Console.WriteLine("Syarat terpenuhi");
    }
}

Nested `if` digunakan ketika sebuah kondisi perlu diperiksa setelah kondisi lainnya terpenuhi.

## 5. Logical AND

Operator `&&` berarti AND.

Semua kondisi harus bernilai benar.

Contoh:

if (umur >= 17 && memilikiKtp)
{
    Console.WriteLine("Syarat terpenuhi");
}

Pada contoh tersebut, kedua kondisi harus benar.

## 6. Logical OR

Operator `||` berarti OR.

Minimal salah satu kondisi harus bernilai benar.

Contoh:

if (hari == "Sabtu" || hari == "Minggu")
{
    Console.WriteLine("Hari libur");
}

## 7. Logical NOT

Operator `!` digunakan untuk membalik nilai boolean.

Contoh:

if (!sudahLogin)
{
    Console.WriteLine("Silakan login");
}

Jika `sudahLogin` bernilai `false`, maka `!sudahLogin` menjadi `true`.

## 8. Ternary Operator

Ternary operator merupakan bentuk singkat dari `if else`.

Contoh:

string status = nilai >= 75 ? "Lulus" : "Tidak Lulus";

Ternary cocok digunakan untuk kondisi sederhana.

## 9. Percabangan dengan Input

Percabangan dapat digunakan bersama input dari user.

Contoh:

Console.Write("Masukkan nilai: ");
int nilai = Convert.ToInt32(Console.ReadLine());

if (nilai >= 75)
{
    Console.WriteLine("Lulus");
}
else
{
    Console.WriteLine("Tidak Lulus");
}

Program akan membaca nilai dari user kemudian menentukan hasil berdasarkan kondisi.

## Struktur Folder

pertemuan-04/
├── 01_if.cs
├── 02_if_else.cs
├── 03_if_else_if.cs
├── 04_nested_if.cs
├── 05_logical_and.cs
├── 06_logical_or.cs
├── 07_logical_not.cs
├── 08_ternary.cs
├── 09_cek_nilai.cs
├── 10_cek_bilangan.cs
├── 11_sistem_kelulusan.cs
└── README.md

## Menjalankan Program

Repository ini menggunakan `run.ps1` untuk menjalankan file C# secara langsung.

Dari root repository, gunakan:

.\run.ps1 pertemuan-04/01_if.cs

Contoh lainnya:

.\run.ps1 pertemuan-04/11_sistem_kelulusan.cs

Nama file dapat disesuaikan dengan program yang ingin dijalankan.

## Latihan

Beberapa latihan yang dapat dilakukan:

1. Membuat program cek umur.
2. Membuat program cek bilangan positif, negatif, atau nol.
3. Membuat program menentukan bilangan ganjil atau genap.
4. Membuat program menentukan grade berdasarkan nilai.
5. Membuat program sistem kelulusan sederhana.
6. Membuat program login sederhana.

## Tujuan Pembelajaran

Setelah menyelesaikan pertemuan ini, diharapkan sudah memahami:

- Cara menggunakan `if`.
- Cara menggunakan `if else`.
- Cara menggunakan `else if`.
- Cara membuat nested `if`.
- Cara menggunakan operator logika.
- Cara menggunakan ternary operator.
- Cara membuat program yang mengambil keputusan berdasarkan input.

## Kesimpulan

Percabangan merupakan konsep penting dalam pemrograman karena memungkinkan program mengambil keputusan berdasarkan kondisi tertentu.

Konsep utama pada pertemuan ini adalah:

`if` → satu kondisi.

`if else` → dua kemungkinan.

`else if` → beberapa kemungkinan.

`&&` → semua kondisi harus benar.

`||` → salah satu kondisi harus benar.

`!` → membalik nilai boolean.

`?:` → bentuk singkat dari `if else`.

## Next

Pertemuan berikutnya akan membahas:

**Pertemuan 05 — Looping / Perulangan**

Materi yang akan dipelajari:

- while
- do while
- for
- Nested loop
- break
- continue
- Latihan looping

> Belajar → Praktik → Error → Debug → Paham 🚀