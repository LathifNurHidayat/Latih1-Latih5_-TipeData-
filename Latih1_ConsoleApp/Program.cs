namespace TipeData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Numerik
            int umur = 16;
            float tinggi = 170.5f;
            Console.WriteLine("Umur = " + umur);
            Console.WriteLine("Tinggi = " + tinggi);

            //String
            string nama = "Budi";
            Console.WriteLine("Nama = " + nama);

            //Tanggal
            DateTime HariIni = DateTime.Now;

            Console.WriteLine("Hari Ini : " + HariIni.ToString("ddd/MMM/yyyy"));

            //Boolean 
            bool isLulus = true;
            Console.WriteLine("Apakah lulus ?" + isLulus);
        }
    }
}

