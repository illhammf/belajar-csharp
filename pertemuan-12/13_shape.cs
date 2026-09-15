// Pertemuan 12 - Studi Kasus Shape
// Setiap bentuk memiliki cara menghitung luas yang berbeda

Shape[] shapes =
{
    new Persegi(5),
    new Lingkaran(7)
};

foreach (Shape shape in shapes)
{
    Console.WriteLine($"Luas: {shape.HitungLuas():F2}");
}

// Abstract class
abstract class Shape
{
    // Setiap shape wajib memiliki cara menghitung luas
    public abstract double HitungLuas();
}

// Persegi
class Persegi : Shape
{
    public double Sisi { get; set; }

    public Persegi(double sisi)
    {
        Sisi = sisi;
    }

    public override double HitungLuas()
    {
        return Sisi * Sisi;
    }
}

// Lingkaran
class Lingkaran : Shape
{
    public double JariJari { get; set; }

    public Lingkaran(double jariJari)
    {
        JariJari = jariJari;
    }

    public override double HitungLuas()
    {
        return Math.PI * JariJari * JariJari;
    }
}