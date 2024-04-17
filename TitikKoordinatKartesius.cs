//2. Menentukan Letak Kuadran Kartesius

using System;
class TitikKoordinatKartesius
{
    static void Main(string[] args)
    {
        Console.WriteLine("Silahkan Masukkan Letak Titik dalam Kartesius");
        Console.Write("Masukkan titik x : ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Masukkan titik y : ");
        double y = Convert.ToDouble(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.WriteLine("Titik terletak di Kuadran I");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Titik terletak di Kuadran II");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Titik terletak di Kuadran III");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Titik terletak di Kuadran IV");
        }
        else
        {
            Console.WriteLine("Titik tidak terletak di Kuadran manapun");
        }
    }
}