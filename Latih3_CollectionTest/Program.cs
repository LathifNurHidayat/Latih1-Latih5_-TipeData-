namespace Latih3_CollectionTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Deklarasi dan inisialisasi list
            List<string> NamaSiswa = new List<string> 
            {
                "Nanda", "Ridho", "Doni", "Budi", "Lani"
            };

            //Menampilkan semua nama siswa
            Console.WriteLine("Daftar nama siswa : " + string.Join(",", NamaSiswa));
        }
    }
}












