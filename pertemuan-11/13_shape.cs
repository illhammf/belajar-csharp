// Pertemuan 11 - Polymorphism Shape
// Setiap bentuk memiliki cara menghitung luas yang berbeda

Shape[] shapes =
{
    new Persegi(),
    new Lingkaran()
};

foreach (Shape shape in shapes)
{
    Console.WriteLine($"Luas: {shape.HitungLuas()}");
}

// Parent class
class Shape
{
    public virtual double HitungLuas()
    {
        return 0;
    }
}

// Child class
class Persegi : Shape
{
    public double Sisi { get; set; } = 5;

    public override double HitungLuas()
    {
        return Sisi * Sisi;
    }
}

// Child class
class Lingkaran : Shape
{
    public double JariJari { get; set; } = 7;

    public override double HitungLuas()
    {
        return Math.PI * JariJari * JariJari;
    }
}