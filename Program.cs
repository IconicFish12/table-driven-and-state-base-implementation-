using System;
using table_driven_and_state_based;


public class Program
{
    public static void Main()
    {
        Console.WriteLine("Kode Produk Camera : " + KodeProduk.GetKodeProduk(KodeProduk.Produk.CAMERA));
        Console.WriteLine("Kode Produk Headset : " + KodeProduk.GetKodeProduk(KodeProduk.Produk.HEADSET));
        Console.WriteLine("Kode Produk Monitor : " + KodeProduk.GetKodeProduk(KodeProduk.Produk.MONITOR));
        Console.WriteLine("Kode Produk Keyboard : " + KodeProduk.GetKodeProduk(KodeProduk.Produk.KEYBOARD));

    }
}