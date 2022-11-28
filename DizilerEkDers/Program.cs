// See https://aka.ms/new-console-template for more information

namespace DizilerEkDers
{
    internal class Program
    { 
        static void Main(string[] args)
        {
             int[] sayilar = { 2, 4, 6, 8 };
            
            string[] sehirler = { "İstanbul", "Ankara", "Sivas", "İzmir" };
          /*  int[] rakamlar = new int[4];     // kaç değer içereceği
            rakamlar[0] = 2;
            rakamlar[1] = 4;
            rakamlar[2] = 6;
            rakamlar[3] = 8;*/
            for (int i = 0; i < sehirler.Length; i++)
            {
                Console.WriteLine(sehirler[i]);
            }
            Console.ReadLine(); 
        }
    
    }
}