using Microsoft.VisualBasic;

namespace Latih4_TipeDataObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hondajazz = new Mobil
            {
                TipeMobil = "Hatchback",
                Warna = "Merah",
                VolumeMesin = 1500,
                MaxKecepatan = 180,
                BahanBakar = "Pertamax",
                TglProduksi = new DateTime(2024, 3, 2)
            };

            Console.WriteLine($"Tipe Mobil : {hondajazz.TipeMobil}");
            Console.WriteLine($"Warna : {hondajazz.Warna}");
            Console.WriteLine($"Volume Mesin : {hondajazz.VolumeMesin}");
            Console.WriteLine($"Max Kecepatan : {hondajazz.MaxKecepatan}");
            Console.WriteLine($"Bahan Bakar : {hondajazz.BahanBakar}");
            Console.WriteLine($"Tgl Produksi : {hondajazz.TglProduksi.ToString("dd-MM-yyyy")}");
        }
    }
}
