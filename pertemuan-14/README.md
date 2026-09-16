# Pertemuan 14 — Exception Handling

Pada pertemuan ini kita akan mempelajari **Exception Handling** di C#.

Exception Handling digunakan untuk menangani kondisi error yang terjadi ketika program sedang dijalankan.

Dengan Exception Handling, program dapat menangani error dengan lebih baik tanpa langsung berhenti secara tiba-tiba.

---

## 🎯 Tujuan Pembelajaran

Setelah menyelesaikan pertemuan ini, kita diharapkan dapat:

- Memahami apa itu exception
- Memahami penyebab exception
- Menggunakan `try`
- Menggunakan `catch`
- Menggunakan `finally`
- Menangani beberapa jenis exception
- Menggunakan `Exception`
- Menggunakan `throw`
- Membuat exception sederhana
- Memahami `FormatException`
- Memahami `DivideByZeroException`
- Memahami `IndexOutOfRangeException`
- Membuat validasi menggunakan exception
- Menggunakan exception dalam studi kasus sederhana

---

# 1. Apa Itu Exception?

Exception adalah kondisi error yang terjadi ketika program sedang dijalankan.

Contohnya:

- Membagi angka dengan nol
- Memasukkan teks ketika program mengharapkan angka
- Mengakses index array yang tidak tersedia
- Menggunakan data yang tidak sesuai

Contoh:

    int angka = 10;
    int hasil = angka / 0;

Kode tersebut akan menghasilkan exception karena angka tidak dapat dibagi dengan nol.

---

# 2. Mengapa Exception Handling Dibutuhkan?

Tanpa exception handling, error yang terjadi dapat menyebabkan program berhenti.

Dengan exception handling, kita dapat memberikan respons yang lebih baik kepada pengguna.

Contoh:

    try
    {
        int hasil = 10 / 0;
    }
    catch
    {
        Console.WriteLine("Terjadi kesalahan!");
    }

Program dapat menangkap error dan memberikan pesan kepada pengguna.

---

# 3. try

`try` digunakan untuk menempatkan kode yang kemungkinan menghasilkan exception.

Contoh:

    try
    {
        int hasil = 10 / 0;

        Console.WriteLine(hasil);
    }

Jika terjadi exception di dalam `try`, program dapat meneruskannya ke `catch`.

---

# 4. catch

`catch` digunakan untuk menangani exception yang terjadi di dalam `try`.

Contoh:

    try
    {
        int hasil = 10 / 0;
    }
    catch
    {
        Console.WriteLine("Terjadi error!");
    }

Jika kode di dalam `try` menghasilkan exception, bagian `catch` akan dijalankan.

---

# 5. finally

`finally` digunakan untuk kode yang ingin tetap dijalankan setelah `try` dan `catch`.

Contoh:

    try
    {
        Console.WriteLine("Program dijalankan");
    }
    catch
    {
        Console.WriteLine("Terjadi error");
    }
    finally
    {
        Console.WriteLine("Program selesai");
    }

`finally` biasanya digunakan untuk proses cleanup atau kode yang memang harus dijalankan.

---

# 6. try-catch

Bentuk dasar Exception Handling:

    try
    {
        // Kode yang berpotensi menghasilkan error
    }
    catch
    {
        // Menangani error
    }

Contoh:

    try
    {
        int angka = int.Parse("abc");
    }
    catch
    {
        Console.WriteLine("Input bukan angka!");
    }

---

# 7. Mengetahui Informasi Exception

Kita dapat menggunakan object `Exception` untuk mendapatkan informasi mengenai error.

Contoh:

    try
    {
        int angka = int.Parse("abc");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

`ex.Message` digunakan untuk mendapatkan pesan error.

---

# 8. FormatException

`FormatException` dapat terjadi ketika format data tidak sesuai dengan yang diharapkan.

Contoh:

    try
    {
        int angka = int.Parse("abc");
    }
    catch (FormatException)
    {
        Console.WriteLine("Input harus berupa angka!");
    }

Karena `"abc"` bukan angka, proses konversi akan menghasilkan `FormatException`.

---

# 9. DivideByZeroException

`DivideByZeroException` terjadi ketika program mencoba melakukan pembagian dengan angka nol.

Contoh:

    try
    {
        int hasil = 10 / 0;
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Tidak dapat membagi dengan nol!");
    }

---

# 10. IndexOutOfRangeException

Exception ini dapat terjadi ketika kita mengakses index array yang berada di luar batas.

Contoh:

    int[] angka = { 10, 20, 30 };

    try
    {
        Console.WriteLine(angka[5]);
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("Index array tidak tersedia!");
    }

Index array tersebut hanya tersedia dari `0` sampai `2`.

---

# 11. Multiple catch

Satu `try` dapat memiliki beberapa `catch`.

Contoh:

    try
    {
        // Kode
    }
    catch (FormatException)
    {
        Console.WriteLine("Format data salah");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Tidak dapat membagi dengan nol");
    }
    catch (Exception)
    {
        Console.WriteLine("Terjadi error lainnya");
    }

Exception yang lebih spesifik biasanya ditangani terlebih dahulu.

---

# 12. finally

`finally` tetap dijalankan baik terjadi exception maupun tidak.

Contoh:

    try
    {
        Console.WriteLine("Mencoba menjalankan program");
    }
    catch
    {
        Console.WriteLine("Terjadi error");
    }
    finally
    {
        Console.WriteLine("Blok finally dijalankan");
    }

---

# 13. throw

`throw` digunakan untuk menghasilkan exception secara manual.

Contoh:

    int umur = 15;

    if (umur < 17)
    {
        throw new Exception("Umur belum mencukupi.");
    }

Kita dapat membuat kondisi tertentu yang dianggap sebagai error.

---

# 14. Custom Exception Sederhana

Kita juga dapat membuat class exception sendiri.

Contoh:

    class SaldoTidakCukupException : Exception
    {
        public SaldoTidakCukupException(string message)
            : base(message)
        {
        }
    }

Kemudian digunakan:

    throw new SaldoTidakCukupException("Saldo tidak mencukupi.");

Pembahasan custom exception akan dibuat sederhana terlebih dahulu.

---

# 15. Exception Handling dengan Input

Exception Handling sangat berguna ketika menerima input dari pengguna.

Contoh:

    try
    {
        Console.Write("Masukkan umur: ");

        int umur = int.Parse(Console.ReadLine() ?? "");

        Console.WriteLine($"Umur: {umur}");
    }
    catch (FormatException)
    {
        Console.WriteLine("Masukkan angka yang valid!");
    }

Dengan begitu, program dapat memberikan pesan yang sesuai ketika input salah.

---

# 16. Exception vs Validasi

Exception Handling bukan berarti semua validasi harus menggunakan exception.

Contohnya, untuk input sederhana kita dapat menggunakan pengecekan biasa:

    if (umur < 0)
    {
        Console.WriteLine("Umur tidak valid");
    }

Sedangkan exception digunakan untuk kondisi error yang memang perlu ditangani sebagai exception.

Dalam program nyata, pemilihan antara validasi biasa dan exception perlu disesuaikan dengan situasinya.

---

# 17. Studi Kasus

Pada pertemuan ini kita akan membuat beberapa studi kasus.

### Kalkulator

Menangani:

- Input bukan angka
- Pembagian dengan nol

### Array

Menangani:

- Index di luar batas

### Data Mahasiswa

Menangani:

- Input tidak sesuai format

### Rekening

Menangani:

- Saldo tidak mencukupi

### Sistem Login

Menangani:

- Data login yang tidak sesuai

---

# 📁 Struktur Folder

File latihan pada pertemuan ini:

    pertemuan-14/
    │
    ├── 01_try.cs
    ├── 02_catch.cs
    ├── 03_finally.cs
    ├── 04_exception.cs
    ├── 05_format_exception.cs
    ├── 06_divide_by_zero.cs
    ├── 07_index_out_of_range.cs
    ├── 08_multiple_catch.cs
    ├── 09_exception_message.cs
    ├── 10_try_catch_finally.cs
    ├── 11_throw.cs
    ├── 12_input_exception.cs
    ├── 13_kalkulator.cs
    ├── 14_rekening.cs
    └── 15_studi_kasus_exception.cs

---

# ▶️ Cara Menjalankan

Gunakan `run.ps1` untuk menjalankan setiap file.

Contoh:

    .\run.ps1 pertemuan-14/01_try.cs

Contoh lainnya:

    .\run.ps1 pertemuan-14/05_format_exception.cs

Untuk studi kasus:

    .\run.ps1 pertemuan-14/15_studi_kasus_exception.cs

---

# 🧠 Ringkasan

Pada pertemuan ini kita mempelajari:

1. Exception adalah error yang terjadi saat program berjalan.
2. `try` digunakan untuk kode yang berpotensi menghasilkan exception.
3. `catch` digunakan untuk menangani exception.
4. `finally` digunakan untuk kode yang tetap dijalankan.
5. `Exception` dapat memberikan informasi mengenai error.
6. `FormatException` berkaitan dengan format data yang tidak sesuai.
7. `DivideByZeroException` terjadi ketika membagi dengan nol.
8. `IndexOutOfRangeException` terjadi ketika index berada di luar batas.
9. Satu `try` dapat memiliki beberapa `catch`.
10. `throw` digunakan untuk menghasilkan exception secara manual.
11. Exception Handling membantu membuat program lebih aman dalam menghadapi error.

---

# 🔥 Pola Dasar Exception Handling

Pola paling dasar yang perlu diingat:

    try
    {
        // Kode yang berpotensi error
    }
    catch (Exception ex)
    {
        // Menangani error
        Console.WriteLine(ex.Message);
    }
    finally
    {
        // Kode yang tetap dijalankan
    }

---

# 🚀 Tantangan

Buat program kalkulator sederhana yang menerima dua angka dari user.

Program harus:

1. Meminta angka pertama.
2. Meminta angka kedua.
3. Meminta operator `+`, `-`, `*`, atau `/`.
4. Menghitung hasil.
5. Menangani input yang bukan angka.
6. Menangani pembagian dengan nol.
7. Menampilkan pesan error yang sesuai.

Contoh:

    Masukkan angka pertama: 10
    Masukkan operator: /
    Masukkan angka kedua: 2

    Hasil: 5

Jika user memasukkan angka yang tidak valid:

    Input harus berupa angka!

Jika user mencoba membagi dengan nol:

    Tidak dapat membagi dengan nol!

Tujuannya adalah memahami bagaimana Exception Handling digunakan dalam program yang menerima input dari pengguna.