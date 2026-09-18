// Pertemuan 15 - Collections
// Membalik urutan data menggunakan Reverse()

List<int> angka = new List<int>
{
    10,
    20,
    30,
    40,
    50
};

Console.WriteLine("Sebelum dibalik:");

foreach (int item in angka)
{
    Console.WriteLine(item);
}

// Membalik urutan List
angka.Reverse();

Console.WriteLine("\nSetelah dibalik:");

foreach (int item in angka)
{
    Console.WriteLine(item);
}