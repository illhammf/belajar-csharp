# Pertemuan 06 — Function / Method

Pada pertemuan ini kita belajar tentang **Function** atau **Method** di C#.

Function adalah sekumpulan kode yang dibuat untuk melakukan tugas tertentu.

Dengan function, kita tidak perlu menulis kode yang sama berulang-ulang.

Contohnya, daripada menulis proses menghitung luas berkali-kali, kita bisa membuat satu function:

    HitungLuas()

Kemudian function tersebut dapat dipanggil kapan saja.

---

## 1. Apa Itu Function?

Function adalah blok kode yang memiliki tugas tertentu dan dapat dipanggil ketika dibutuhkan.

Contoh sederhana:

    static void Sapa()
    {
        Console.WriteLine("Halo!");
    }

Untuk menjalankan function tersebut:

    Sapa();

Output:

    Halo!

Struktur dasar function:

    static void NamaFunction()
    {
        // kode yang akan dijalankan
    }

---

## 2. Memanggil Function

Function tidak akan berjalan hanya karena kita membuatnya.

Kita harus memanggil function tersebut.

Contoh:

    static void Sapa()
    {
        Console.WriteLine("Halo, selamat belajar C#!");
    }

    static void Main()
    {
        Sapa();
    }

Function `Sapa()` dipanggil dari dalam `Main()`.

---

## 3. Function dengan Parameter

Parameter digunakan untuk mengirim data ke dalam function.

Contoh:

    static void Sapa(string nama)
    {
        Console.WriteLine($"Halo, {nama}!");
    }

Kemudian:

    Sapa("Ilham");

Output:

    Halo, Ilham!

`nama` merupakan parameter.

Sedangkan `"Ilham"` merupakan nilai yang dikirim ke parameter tersebut.

---

## 4. Function dengan Beberapa Parameter

Satu function dapat memiliki lebih dari satu parameter.

Contoh:

    static void Biodata(string nama, int umur)
    {
        Console.WriteLine($"Nama: {nama}");
        Console.WriteLine($"Umur: {umur}");
    }

Pemanggilan:

    Biodata("Ilham", 20);

Output:

    Nama: Ilham
    Umur: 20

Urutan parameter harus sesuai dengan urutan nilai yang diberikan.

---

## 5. Function dengan Return

Function tidak selalu hanya menjalankan perintah.

Function juga dapat mengembalikan sebuah nilai menggunakan `return`.

Contoh:

    static int Tambah(int a, int b)
    {
        return a + b;
    }

Kemudian hasilnya dapat disimpan:

    int hasil = Tambah(10, 5);

    Console.WriteLine(hasil);

Output:

    15

Karena function mengembalikan `int`, maka tipe function ditulis sebagai `int`.

---

## 6. Void

`void` digunakan jika function **tidak mengembalikan nilai**.

Contoh:

    static void Sapa()
    {
        Console.WriteLine("Halo!");
    }

Function tersebut hanya menjalankan perintah.

Sedangkan function yang mengembalikan nilai:

    static int Tambah(int a, int b)
    {
        return a + b;
    }

Jadi:

- `void` → tidak mengembalikan nilai
- `int` → mengembalikan nilai bertipe integer
- `string` → mengembalikan nilai bertipe string
- `double` → mengembalikan nilai bertipe double
- `bool` → mengembalikan nilai `true` atau `false`

---

## 7. Function dengan Bool

Function juga dapat mengembalikan nilai `bool`.

Contoh:

    static bool Lulus(int nilai)
    {
        return nilai >= 75;
    }

Kemudian:

    bool status = Lulus(80);

    Console.WriteLine(status);

Output:

    True

Function tersebut akan menghasilkan:

    true

atau:

    false

---

## 8. Function dengan If

Function dapat dikombinasikan dengan percabangan.

Contoh:

    static string CekNilai(int nilai)
    {
        if (nilai >= 75)
        {
            return "Lulus";
        }
        else
        {
            return "Tidak Lulus";
        }
    }

Kemudian:

    string hasil = CekNilai(80);

    Console.WriteLine(hasil);

Output:

    Lulus

Dengan cara ini, logika pengecekan dapat dipisahkan dari kode utama.

---

## 9. Function dengan Looping

Function juga dapat digunakan bersama looping.

Contoh:

    static void TampilkanAngka(int batas)
    {
        for (int i = 1; i <= batas; i++)
        {
            Console.WriteLine(i);
        }
    }

Kemudian:

    TampilkanAngka(5);

Output:

    1
    2
    3
    4
    5

Function tersebut dapat digunakan kembali dengan batas yang berbeda.

Contoh:

    TampilkanAngka(10);

---

## 10. Function untuk Calculator

Kita dapat membuat function untuk operasi matematika.

Contoh:

    static int Tambah(int a, int b)
    {
        return a + b;
    }

    static int Kurang(int a, int b)
    {
        return a - b;
    }

    static int Kali(int a, int b)
    {
        return a * b;
    }

    static int Bagi(int a, int b)
    {
        return a / b;
    }

Dengan function, setiap operasi memiliki tugas masing-masing.

---

## 11. Function dengan Input User

Function dapat menerima data dari user.

Contoh:

    static int HitungLuasPersegi(int sisi)
    {
        return sisi * sisi;
    }

Di `Main()`:

    Console.Write("Masukkan sisi: ");
    int sisi = Convert.ToInt32(Console.ReadLine());

    int luas = HitungLuasPersegi(sisi);

    Console.WriteLine($"Luas: {luas}");

Jika user memasukkan:

    5

Output:

    Luas: 25

---

## 12. Function untuk Mengecek Bilangan

Kita dapat membuat function untuk mengecek apakah sebuah angka genap.

Contoh:

    static bool IsGenap(int angka)
    {
        return angka % 2 == 0;
    }

Kemudian:

    Console.Write("Masukkan angka: ");
    int angka = Convert.ToInt32(Console.ReadLine());

    if (IsGenap(angka))
    {
        Console.WriteLine("Bilangan genap");
    }
    else
    {
        Console.WriteLine("Bilangan ganjil");
    }

Function `IsGenap()` menghasilkan `true` atau `false`.

---

## 13. Function untuk Menghitung Rata-rata

Function juga dapat digunakan untuk melakukan proses yang lebih kompleks.

Contoh:

    static double HitungRataRata(int nilai1, int nilai2, int nilai3)
    {
        return (nilai1 + nilai2 + nilai3) / 3.0;
    }

Pemanggilan:

    double rataRata = HitungRataRata(80, 75, 90);

    Console.WriteLine($"Rata-rata: {rataRata}");

Output:

    Rata-rata: 81.66666666666667

---

## 14. Function Prototype / Deklarasi Method

Di C#, function biasanya didefinisikan di dalam class.

Contoh:

    class Program
    {
        static void Sapa()
        {
            Console.WriteLine("Halo!");
        }

        static void Main()
        {
            Sapa();
        }
    }

Struktur sederhananya:

    class Program
    {
        static returnType NamaFunction(parameter)
        {
            // kode
        }

        static void Main()
        {
            // program utama
        }
    }

---

## 15. Mengapa Menggunakan Function?

Tanpa function, program yang besar bisa menjadi sulit dibaca.

Contoh:

    Console.WriteLine("Menghitung luas...");
    // banyak kode
    // banyak kode
    // banyak kode

Dengan function:

    HitungLuas();

Kode menjadi lebih terstruktur.

Beberapa keuntungan function:

- Membuat kode lebih rapi
- Mengurangi pengulangan kode
- Memudahkan debugging
- Memudahkan pengembangan program
- Membuat program lebih mudah dibaca
- Function dapat digunakan berkali-kali

---

## 16. Contoh Program Terstruktur

Contoh program sederhana menggunakan beberapa function:

    static void TampilkanJudul()
    {
        Console.WriteLine("=== PROGRAM NILAI ===");
    }

    static string CekKelulusan(int nilai)
    {
        if (nilai >= 75)
        {
            return "Lulus";
        }

        return "Tidak Lulus";
    }

    static void Main()
    {
        TampilkanJudul();

        Console.Write("Masukkan nilai: ");
        int nilai = Convert.ToInt32(Console.ReadLine());

        string status = CekKelulusan(nilai);

        Console.WriteLine($"Nilai: {nilai}");
        Console.WriteLine($"Status: {status}");
    }

Program menjadi lebih mudah dibaca karena setiap function memiliki tugas masing-masing.

---

## 17. Perbedaan Function dan Method

Dalam C#, istilah yang sering digunakan adalah **method**.

Secara sederhana untuk tahap belajar:

- Function → istilah umum untuk blok kode yang dapat dipanggil.
- Method → function yang berada di dalam sebuah class atau struct.

Karena C# menggunakan konsep OOP, kamu akan lebih sering menemukan istilah **method**.

Untuk sekarang, kamu bisa menganggap function dan method sebagai konsep yang hampir sama.

---

## 18. Kesimpulan

Pada pertemuan ini kita telah mempelajari:

- Apa itu function
- Membuat function
- Memanggil function
- Parameter
- Multiple parameter
- `void`
- `return`
- Function dengan `int`
- Function dengan `string`
- Function dengan `bool`
- Function dengan `if`
- Function dengan looping
- Function dengan input user
- Membuat calculator menggunakan function
- Membuat program yang lebih terstruktur

Konsep function akan menjadi dasar penting sebelum kita masuk ke konsep yang lebih besar seperti **array, class, object, dan OOP**.

---

## Struktur File

    pertemuan-06/
    ├── README.md
    ├── 01_function.cs
    ├── 02_parameter.cs
    ├── 03_multiple_parameter.cs
    ├── 04_return.cs
    ├── 05_bool_function.cs
    ├── 06_function_if.cs
    ├── 07_function_loop.cs
    ├── 08_calculator.cs
    ├── 09_input_function.cs
    ├── 10_cek_bilangan.cs
    ├── 11_rata_rata.cs
    └── 12_program_terstruktur.cs

---

## Cara Menjalankan

Gunakan `run.ps1` dari folder utama project.

Contoh:

    .\run.ps1 pertemuan-06/01_function.cs

Contoh lainnya:

    .\run.ps1 pertemuan-06/08_calculator.cs

atau:

    .\run.ps1 pertemuan-06/12_program_terstruktur.cs

---

## Next

➡️ **Pertemuan 07 — Array**