// ==========================================
// Ternary Operator
// ==========================================

int nilai = 80;

// Bentuk ternary:
//
// kondisi ? nilaiJikaTrue : nilaiJikaFalse

string hasil = nilai >= 75
    ? "Lulus"
    : "Tidak Lulus";

Console.WriteLine($"Nilai : {nilai}");
Console.WriteLine($"Hasil : {hasil}");