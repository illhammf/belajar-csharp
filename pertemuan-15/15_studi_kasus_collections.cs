// Pertemuan 15 - Collections
// Studi Kasus: Data Nilai Mahasiswa

List<int> nilai = new List<int>();

Console.WriteLine("=== DATA NILAI MAHASISWA ===");

// Meminta jumlah mahasiswa
Console.Write("Masukkan jumlah mahasiswa: ");

int jumlah = int.Parse(Console.ReadLine() ?? "");

// Input nilai
for (int i = 0; i < jumlah; i++)
{
    Console.Write($"Masukkan nilai mahasiswa ke-{i + 1}: ");

    int input = int.Parse(Console.ReadLine() ?? "");

    // Menambahkan nilai ke List
    nilai.Add(input);
}

// Menampilkan seluruh nilai
Console.WriteLine("\n=== Semua Nilai ===");

foreach (int item in nilai)
{
    Console.WriteLine(item);
}

// Menampilkan jumlah data
Console.WriteLine($"\nJumlah mahasiswa: {nilai.Count}");

// Mencari nilai terbesar
int terbesar = nilai[0];

foreach (int item in nilai)
{
    if (item > terbesar)
    {
        terbesar = item;
    }
}

// Mencari nilai terkecil
int terkecil = nilai[0];

foreach (int item in nilai)
{
    if (item < terkecil)
    {
        terkecil = item;
    }
}

// Menghitung total nilai
int total = 0;

foreach (int item in nilai)
{
    total += item;
}

// Menghitung rata-rata
double rataRata = (double)total / nilai.Count;

// Menampilkan hasil
Console.WriteLine($"Nilai terbesar : {terbesar}");
Console.WriteLine($"Nilai terkecil : {terkecil}");
Console.WriteLine($"Total nilai    : {total}");
Console.WriteLine($"Rata-rata      : {rataRata:F2}");

// Mengurutkan nilai
nilai.Sort();

Console.WriteLine("\n=== Nilai Setelah Diurutkan ===");

foreach (int item in nilai)
{
    Console.WriteLine(item);
}