// Pertemuan 15 - Collections
// Looping data di dalam List

List<string> nama = new List<string>
{
    "Ilham",
    "Budi",
    "Andi",
    "Rizky"
};

// Looping menggunakan for
Console.WriteLine("=== Menggunakan for ===");

for (int i = 0; i < nama.Count; i++)
{
    Console.WriteLine($"{i}: {nama[i]}");
}

// Looping menggunakan foreach
Console.WriteLine("\n=== Menggunakan foreach ===");

foreach (string item in nama)
{
    Console.WriteLine(item);
}