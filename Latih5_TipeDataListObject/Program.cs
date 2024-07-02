namespace Latih5_TipeDataListObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var honda = new Mobil
            {
                TipeMobil = "Hatchback",
                Warna = "Hijau",
                VolumeMesin = 1000,
                BahanBakar = "Pertamax",
                MaxKecepatan = 200,
                TglProduksi = new DateTime(2023, 2, 12)
            };

           var suzuki = new Mobil
           {
               TipeMobil = "Ertiga",
               Warna = "Putih",
               VolumeMesin = 1500,
               BahanBakar = "Pertamax",
               MaxKecepatan = 200,
               TglProduksi = new DateTime(2022, 5, 12)
           };

           var pajero = new Mobil
           {
               TipeMobil = "Pajero Sport",
               Warna = "Hitam",
               VolumeMesin = 1600,
               BahanBakar = "Dexlite",
               MaxKecepatan = 400,
               TglProduksi = new DateTime(2024, 5, 1)
           };

            var ListJenis = new List<Mobil>();
            
                ListJenis.Add(honda);
                ListJenis.Add(suzuki);
                ListJenis.Add(pajero);


            foreach(var item in ListJenis)
            {
                Console.WriteLine($"Tipe Mobil : {item.TipeMobil}");
                Console.WriteLine($"Warna : {item.Warna}");
                Console.WriteLine($"Volume Mesin : {item.VolumeMesin}");
                Console.WriteLine($"Bahan Bakar : {item.BahanBakar}");
                Console.WriteLine($"Max Kecepatan: {item.MaxKecepatan}");
                Console.WriteLine($"Tgl Produksi: {item.TglProduksi.ToString("dd-MM-yyyy")}\n\n");


                
            }

        }
    }
}
