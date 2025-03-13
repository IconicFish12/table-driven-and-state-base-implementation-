using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace table_driven_and_state_based
{
    internal class KodeProduk
    {
        public enum Produk
        {
            LAPTOP,
            SMARTPHONE,
            TABLET,
            HEADSET,
            KEYBOARD,
            MOUSE,
            PRINTER,
            MONITOR,
            SMARTWATCH,
            CAMERA
        }

        public static string GetKodeProduk(Produk produk)
        {
            string[] kodeProduk = { "E100", "E101", "E102", "E103", "E104", "E105", "E106", "E107", "E108", "E109" };

            return kodeProduk[(int) produk];
        }
    }
}
