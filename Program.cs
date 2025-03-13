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

        FanLaptop fan = new FanLaptop();

        fan.setBalanceMode(FanLaptop.Mode.BALANCE);
        fan.setBalanceMode(FanLaptop.Mode.TURBO);
        fan.setBalanceMode(FanLaptop.Mode.QUITE);
        fan.setPerformanceMode(FanLaptop.Mode.PERFORMANCE);
        fan.setPerformanceMode(FanLaptop.Mode.TURBO);
        fan.setPerformanceMode(FanLaptop.Mode.BALANCE);
        fan.setTurboMode(FanLaptop.Mode.PERFORMANCE);
        fan.setTurboMode(FanLaptop.Mode.QUITE);
    }
}