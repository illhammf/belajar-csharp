// Pertemuan 15 - Collections
// Looping Dictionary

Dictionary<string, int> nilai = new Dictionary<string, int>
{
    { "Ilham", 90 },
    { "Budi", 80 },
    { "Andi", 85 },
    { "Rizky", 88 }
};

Console.WriteLine("=== Data Nilai Mahasiswa ===");

// Looping menggunakan foreach
foreach (var item in nilai)
{
    // Key = nama mahasiswa
    // Value = nilai mahasiswa
    Console.WriteLine($"{item.Key}: {item.Value}");
}