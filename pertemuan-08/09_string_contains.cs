// Membuat string
string kalimat = "Saya sedang belajar C#";

// Mengecek apakah string mengandung kata tertentu
if (kalimat.Contains("C#"))
{
    Console.WriteLine("Kalimat mengandung C#");
}
else
{
    Console.WriteLine("C# tidak ditemukan");
}

// Mengecek awalan string
Console.WriteLine(kalimat.StartsWith("Saya"));

// Mengecek akhiran string
Console.WriteLine(kalimat.EndsWith("C#"));