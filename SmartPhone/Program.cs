ISmartPhone hpBudi = new iPhone();

Fotographer fotografer = new Fotographer();
fotografer.Kerja(hpBudi);

hpBudi = new Samsung();
fotografer.Kerja(hpBudi);


interface ISmartPhone
{
    public void AmbilFoto();
}

class iPhone : ISmartPhone
{
    public void AmbilFoto()
    {
        Console.WriteLine("Mengaktifkan sensor kamera premium....*Cekrek!*");
    }
}

class Samsung : ISmartPhone
{
    public void AmbilFoto()
    {
        Console.WriteLine("Mengaktifkan fitur beauty.... *Cekrek!*");
    }
}

class Fotographer
{
   public void Kerja(ISmartPhone hp)
    {
        hp.AmbilFoto();
    }

}


















































