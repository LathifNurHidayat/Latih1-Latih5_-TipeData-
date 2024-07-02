using System.Linq.Expressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array
            Console.WriteLine("ARRAY");

            //Deklarasi dan inisialisasi array
            int[] angka = { 1, 2, 3, 4, 5 };

            //Akses elemen array
            Console.WriteLine("Elemen Pertama: " + angka[0]);
            Console.WriteLine("Elemen terakhir: " + angka[angka.Length - 1]);

            //Mengubah nilai elemen 
            angka[2] = 10;
            Console.WriteLine("Elemen ketiga setelah diubah : " + angka[2]);
            Console.WriteLine("\n\n");




            //List
            Console.WriteLine("LIST");

            //deklarasi dan Inisialisasi List
            List<int> angkaList = new List<int> { 1, 2, 3, 4, 5 };

            //Akses elemen List 
            Console.WriteLine("Elemen Pertama : " + angkaList[0]);
            Console.WriteLine("Elemen Terakhir : " + angkaList[angkaList.Count - 1]);

            //Menambabhkan Elemen Ke list
            angkaList.Add(6);
            Console.WriteLine("Elemen baru ditambahkan : " + angkaList[5]);

            //Hapus elemen dari list
            angkaList.RemoveAt(2); //Menghapus elemen ke-3
            Console.WriteLine("List setelah elemen ketiga dihapus : " + string.Join(",", angkaList));
            Console.WriteLine("\n\n");




            //Dictionary
            Console.WriteLine("DICTIONARY");

            Dictionary<string, int> NilaiSiswa = new Dictionary<string, int>
            {
                {"Budi", 85 },
                {"Siti", 90 },
                {"Adi", 78 },
            };

            //Akses nilai berdasarkan kunsi
            Console.WriteLine("Nilai Budi " + NilaiSiswa["Budi"]);

            // Menambah pasangan kunci-nilai baru
            NilaiSiswa["Dina"] = 92;
            Console.WriteLine("Nilai Dina: " + NilaiSiswa["Dina"]);

            //Mengubah nilai berdasarkan kunci
            NilaiSiswa["Adi"] = 80;
            Console.WriteLine("Nilai Adi setelah diubah: " + NilaiSiswa["Adi"]);

        }
    }
}