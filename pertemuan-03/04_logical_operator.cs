// ==========================================
// Logical Operator
// ==========================================

bool memilikiTiket = true;
bool sudahTerdaftar = true;

// ==========================================
// AND (&&) / dan
// ==========================================

// Kedua kondisi harus true
bool bolehMasuk = memilikiTiket && sudahTerdaftar;

Console.WriteLine($"Boleh masuk : {bolehMasuk}");

// ==========================================
// OR (||) / atau
// ==========================================

bool memilikiKartu = false;
bool memilikiUndangan = true;

// Salah satu kondisi true sudah cukup
bool bolehMasuk2 = memilikiKartu || memilikiUndangan;

Console.WriteLine($"Boleh masuk 2 : {bolehMasuk2}");

// ==========================================
// NOT (!) // kebalikan
// ==========================================

bool aktif = true;

// ! digunakan untuk membalik nilai boolean
bool tidakAktif = !aktif;

Console.WriteLine($"Aktif      : {aktif}");
Console.WriteLine($"Tidak aktif: {tidakAktif}");