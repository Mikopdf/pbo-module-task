using System;
using System.Collections.Generic;


class Hewan
{
    public string Nama;
    public int Umur;

    public Hewan(string nama, int umur)
    {
        Nama = nama;
        Umur = umur;
    }

    public virtual string Suara()
    {
        return "Hewan membuat suara.";
    }

    public virtual string InfoHewan()
    {
        return $"{Nama}, {Umur} tahun";
    }
}


class Mamalia : Hewan
{
    public int JumlahKaki;

    public Mamalia(string nama, int umur, int jumlahKaki) : base(nama, umur)
    {
        JumlahKaki = jumlahKaki;
    }

    public override string InfoHewan()
    {
        return $"{base.InfoHewan()}, Mamalia dengan {JumlahKaki} kaki";
    }
}


class Reptil : Hewan
{
    public double PanjangTubuh;

    public Reptil(string nama, int umur, double panjangTubuh) : base(nama, umur)
    {
        PanjangTubuh = panjangTubuh;
    }

    public override string InfoHewan()
    {
        return $"{base.InfoHewan()}, Reptil dengan panjang tubuh {PanjangTubuh} meter";
    }
}


class Singa : Mamalia
{
    public Singa(string nama, int umur) : base(nama, umur, 4) { }

    public override string Suara()
    {
        return "Singa mengaum";
    }

    public void Mengaum()
    {
        Console.WriteLine($"{Nama} sedang mengaum keras!");
    }
}


class Gajah : Mamalia
{
    public Gajah(string nama, int umur) : base(nama, umur, 4) { }

    public override string Suara()
    {
        return "Gajah mengeluarkan suara terompet";
    }
}


class Ular : Reptil
{
    public Ular(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) { }

    public override string Suara()
    {
        return "Ular mendesis";
    }

    public void Merayap()
    {
        Console.WriteLine($"{Nama} merayap dengan perlahan.");
    }
}


class Buaya : Reptil
{
    public Buaya(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) { }

    public override string Suara()
    {
        return "Buaya menggeram";
    }
}


class KebunBinatang
{
    private List<Hewan> daftarHewan = new List<Hewan>();

    public void TambahHewan(Hewan hewan)
    {
        daftarHewan.Add(hewan);
    }

    public void DaftarHewan()
    {
        Console.WriteLine("Daftar Hewan di Kebun Binatang:");
        foreach (Hewan hewan in daftarHewan)
        {
            Console.WriteLine(hewan.InfoHewan());
        }
    }

    public void SuaraHewan()
    {
        Console.WriteLine("\nSuara Hewan di Kebun Binatang:");
        foreach (Hewan hewan in daftarHewan)
        {
            Console.WriteLine($"{hewan.Nama} bersuara: {hewan.Suara()}");
        }
    }
}


class Program
{
    static void Main()
    {
        KebunBinatang zoo = new KebunBinatang();

        Singa roxy = new Singa("windah", 3);
        Gajah jeje = new Gajah("patrik", 4);
        Ular snake = new Ular("cere", 2, 7);
        Buaya croko = new Buaya("croksi", 6, 3);

        zoo.TambahHewan(roxy);
        zoo.TambahHewan(jeje);
        zoo.TambahHewan(snake);
        zoo.TambahHewan(croko);

        // Menampilkan informasi hewan
        zoo.DaftarHewan();

        // Memanggil suara hewan menggunakan polymorphism
        zoo.SuaraHewan();

        //demonstrasi mengaum untuk singa
        roxy.Mengaum();

        // soal 1
        Console.WriteLine("\n[Soal 1]");
        Console.WriteLine(jeje.Suara());
        Console.WriteLine(snake.Suara());

        // soal 2
        Console.WriteLine("\n[Soal 2]");
        roxy.Mengaum();

        // soal 3
        Console.WriteLine("\n[Soal 3]");
        Console.WriteLine(roxy.InfoHewan());

        // soal 4
        Console.WriteLine("\n[Soal 4]");
        snake.Merayap();

        // soal 5
        Reptil reptil = new Buaya("crocksi", 8, 3);
        Console.WriteLine("\n[Soal 5]");
        Console.WriteLine(reptil.Suara());

    }
}
