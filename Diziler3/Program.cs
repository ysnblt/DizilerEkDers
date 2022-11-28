namespace Diziler3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5];
            for(int i = 0; i < sayilar.Length; i++)
            {
                Console.Write("sayılar index değeri girin"); //WriteLine ile yazarsak yeni satıra yazıyor, Write yazarsak yanına yazıyor
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("_______________________________");
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
                
            }
            Console.ReadLine(); 
        }
    }
}