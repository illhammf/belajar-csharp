# 🚀 Pertemuan 1 — Pengenalan C# dan Program Pertama

Pertemuan pertama ini membahas dasar-dasar bahasa pemrograman **C# (C Sharp)** dan cara membuat program sederhana.

C# adalah bahasa pemrograman yang dikembangkan oleh Microsoft dan banyak digunakan untuk membuat berbagai jenis aplikasi, seperti:

- Desktop Application
- Web Application
- Game
- Backend / API
- Mobile Application
- Cloud Application

Pada pertemuan ini kita belum masuk ke konsep yang kompleks. Kita akan mengenal struktur dasar program C# terlebih dahulu.

---

## 🎯 Tujuan Pembelajaran

Setelah menyelesaikan pertemuan ini, diharapkan dapat:

- Mengenal bahasa pemrograman C#.
- Mengetahui fungsi `Main()`.
- Memahami penggunaan `Console.WriteLine()`.
- Memahami penggunaan `Console.Write()`.
- Mengenal komentar dalam C#.
- Membuat dan menjalankan program C# sederhana.
- Memahami struktur dasar sebuah program C#.

---

## 📚 Materi

### 1. Apa itu C#?

C# adalah bahasa pemrograman modern yang dikembangkan oleh **Microsoft**.

C# menggunakan paradigma **Object-Oriented Programming (OOP)** dan berjalan pada platform **.NET**.

Contoh sederhana program C#:

```csharp
Console.WriteLine("Hello, World!");
```

Program tersebut akan menampilkan:

```text
Hello, World!
```

---

## 2. C# dan .NET

C# dan .NET adalah dua hal yang berbeda.

**C#** adalah bahasa pemrogramannya.

**.NET** adalah platform yang digunakan untuk menjalankan dan mengembangkan aplikasi menggunakan C#.

Sederhananya:

```text
C#
↓
Bahasa Pemrograman

.NET
↓
Platform untuk menjalankan dan mengembangkan aplikasi
```

Jadi ketika belajar C#, kita biasanya juga akan berinteraksi dengan ekosistem .NET.

---

## 3. Program Pertama

Contoh program C# sederhana:

```csharp
Console.WriteLine("Hello, World!");
```

Output:

```text
Hello, World!
```

`Console.WriteLine()` digunakan untuk menampilkan teks ke console dan kemudian berpindah ke baris berikutnya.

---

## 4. Console.WriteLine()

`Console.WriteLine()` digunakan untuk menampilkan informasi ke console.

Contoh:

```csharp
Console.WriteLine("Halo!");
Console.WriteLine("Saya sedang belajar C#.");
```

Output:

```text
Halo!
Saya sedang belajar C#.
```

Setiap `WriteLine()` akan membuat baris baru setelah menampilkan teks.

---

## 5. Console.Write()

Selain `WriteLine()`, C# juga memiliki `Console.Write()`.

Perbedaannya:

```csharp
Console.Write("Halo ");
Console.Write("C#");
```

Output:

```text
Halo C#
```

`Console.Write()` tidak otomatis berpindah ke baris baru.

Sedangkan:

```csharp
Console.WriteLine("Halo");
Console.WriteLine("C#");
```

Output:

```text
Halo
C#
```

### Perbandingan

| Method | Fungsi |
|---|---|
| `Console.Write()` | Menampilkan teks tanpa pindah baris |
| `Console.WriteLine()` | Menampilkan teks dan pindah baris |

---

## 6. Komentar

Komentar adalah tulisan di dalam source code yang tidak dijalankan oleh program.

Komentar berguna untuk memberikan penjelasan pada kode.

### Single-line Comment

Gunakan `//`.

Contoh:

```csharp
// Ini adalah komentar
Console.WriteLine("Hello, World!");
```

Komentar tersebut tidak akan ditampilkan ketika program dijalankan.

### Multi-line Comment

Gunakan `/* */`.

Contoh:

```csharp
/*
    Ini adalah komentar
    yang terdiri dari
    beberapa baris.
*/

Console.WriteLine("Hello, World!");
```

---

## 7. Struktur Dasar Program C#

Pada versi C# modern, kita dapat menulis program sederhana seperti:

```csharp
Console.WriteLine("Hello, World!");
```

C# juga mendukung bentuk program dengan struktur yang lebih lengkap:

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
    }
}
```

Untuk sementara, fokus terlebih dahulu pada bagian:

```csharp
Console.WriteLine("Hello, World!");
```

Struktur `class` dan `Main()` akan kita pelajari lebih dalam pada materi berikutnya ketika konsepnya sudah diperlukan.

---

## 8. Case Sensitive

C# bersifat **case-sensitive**.

Artinya, huruf besar dan huruf kecil dianggap berbeda.

Contoh:

```csharp
Console.WriteLine("Hello");
```

Berbeda dengan:

```csharp
console.writeline("Hello");
```

Penulisan yang kedua tidak dianggap sama dan dapat menyebabkan error.

Karena itu, perhatikan penulisan kode dengan baik.

---

## 9. Tanda Semicolon `;`

Sebagian besar statement dalam C# diakhiri dengan tanda titik koma `;`.

Contoh:

```csharp
Console.WriteLine("Hello");
Console.WriteLine("Saya belajar C#");
```

Jangan lupa tanda:

```text
;
```

Jika tanda tersebut diperlukan tetapi tidak ditulis, program dapat menghasilkan error saat dikompilasi.

---

## 10. Struktur Folder

Pada repository ini, setiap pertemuan memiliki folder masing-masing.

Contoh:

```text
belajar-csharp/
│
├── pertemuan-01/
│   ├── README.md
│   ├── 01_hello_world.cs
│   ├── 02_output.cs
│   ├── 03_write.cs
│   └── 04_comment.cs
│
├── pertemuan-02/
├── pertemuan-03/
└── ...
```

File `.cs` merupakan source code dari bahasa C#.

---

## 🧠 Konsep Penting

Pada pertemuan pertama, ingat beberapa hal berikut:

```text
C#
↓
Bahasa Pemrograman

.NET
↓
Platform untuk menjalankan dan mengembangkan aplikasi

Console.WriteLine()
↓
Menampilkan teks + pindah baris

Console.Write()
↓
Menampilkan teks tanpa pindah baris

//
↓
Komentar satu baris

/*
   ...
*/
↓
Komentar beberapa baris

;
↓
Mengakhiri statement
```

---

## 💡 Jika Pernah Belajar C++

Jika sebelumnya pernah belajar C++, beberapa konsep dasar akan terasa familiar.

Contoh C++:

```cpp
#include <iostream>
using namespace std;

int main()
{
    cout << "Hello, World!";
    return 0;
}
```

Sedangkan C#:

```csharp
Console.WriteLine("Hello, World!");
```

Keduanya sama-sama dapat digunakan untuk menampilkan teks ke console, tetapi syntax dan ekosistemnya berbeda.

Jangan terlalu fokus menghafal perbedaannya terlebih dahulu. Pahami konsep dasarnya satu per satu.

---

## 📝 Latihan

Coba buat program yang menampilkan:

```text
================================
        BELAJAR C#
================================

Nama    : Nama Kamu
Status  : Mahasiswa
Bahasa  : C#

Saya sedang belajar bahasa C#.
Semangat belajar!
```

Gunakan beberapa `Console.WriteLine()` untuk membuat output tersebut.

---

## ✅ Checklist

- [ ] Mengenal C#
- [ ] Mengenal .NET
- [ ] Memahami `Console.WriteLine()`
- [ ] Memahami `Console.Write()`
- [ ] Memahami komentar `//`
- [ ] Memahami komentar `/* */`
- [ ] Memahami konsep case-sensitive
- [ ] Memahami penggunaan `;`
- [ ] Membuat program C# sederhana
- [ ] Mengerjakan latihan

---

## 🚀 Selanjutnya

Pada **Pertemuan 2**, kita akan mulai masuk ke konsep yang lebih penting dalam pemrograman:

> **Variable, Data Type, dan Input**

Kita akan mulai belajar bagaimana program menyimpan data dan menerima data dari pengguna.

---

**Happy Coding! 🚀**

> Repository ini dibuat sebagai dokumentasi proses belajar C# dari dasar hingga intermediate.