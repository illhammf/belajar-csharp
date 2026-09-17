// Pertemuan 14 - Exception Handling
// Studi kasus kalkulator sederhana

Console.Write("Masukkan angka pertama: ");
string input1 = Console.ReadLine() ?? "";

Console.Write("Masukkan operator (+ - * /): ");
string operasi = Console.ReadLine() ?? "";

Console.Write("Masukkan angka kedua: ");
string input2 = Console.ReadLine() ?? "";

try
{
    // Mengubah input menjadi angka
    double angka1 = double.Parse(input1);
    double angka2 = double.Parse(input2);

    double hasil = 0;

    // Menentukan operasi
    switch (operasi)
    {
        case "+":
            hasil = angka1 + angka2;
            break;

        case "-":
            hasil = angka1 - angka2;
            break;

        case "*":
            hasil = angka1 * angka2;
            break;

        case "/":
            // Mengecek pembagian dengan 0
            if (angka2 == 0)
            {
                throw new DivideByZeroException();
            }

            hasil = angka1 / angka2;
            break;

        default:
            throw new Exception("Operator tidak dikenali.");
    }

    Console.WriteLine($"Hasil: {hasil}");
}
catch (FormatException)
{
    Console.WriteLine("Angka yang dimasukkan tidak valid.");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Tidak bisa membagi dengan 0.");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}