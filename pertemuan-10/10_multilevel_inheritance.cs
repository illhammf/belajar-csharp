// Membuat object Kucing
Kucing kucing = new Kucing();

// Memanggil method dari Hewan
kucing.Makan();

// Memanggil method dari Mamalia
kucing.Menyusui();

// Memanggil method milik Kucing
kucing.Mengeong();


// ==========================================
// LEVEL 1 - PARENT
// ==========================================

class Hewan
{
    public void Makan()
    {
        Console.WriteLine(
            "Hewan sedang makan"
        );
    }
}


// ==========================================
// LEVEL 2
// ==========================================

class Mamalia : Hewan
{
    public void Menyusui()
    {
        Console.WriteLine(
            "Mamalia menyusui anaknya"
        );
    }
}


// ==========================================
// LEVEL 3 - CHILD
// ==========================================

class Kucing : Mamalia
{
    public void Mengeong()
    {
        Console.WriteLine("Meong!");
    }
}