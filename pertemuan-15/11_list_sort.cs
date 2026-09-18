// Pertemuan 15 - Collections
// Mengurutkan data menggunakan Sort()

List<int> angka = new List<int>
{
    40,
    10,
    30,
    20,
    50
};

Console.WriteLine("Sebelum diurutkan:");

foreach (int item in angka)
{
    Console.WriteLine(item);
}

// Mengurutkan dari kecil ke besar
angka.Sort();

Console.WriteLine("\nSetelah diurutkan:");

foreach (int item in angka)
{
    Console.WriteLine(item);
}