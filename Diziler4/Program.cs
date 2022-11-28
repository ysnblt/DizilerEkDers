// See https://aka.ms/new-console-template for more information
/*
double os = { 0.4, 2.5, 3.5, 1.7 };

// foreach örnek

foreach(double e in os)
{
    Console.WriteLine(e);
}*/

int[] sayilar = { 10, 20, 30, 30, 40, 40, 40, 50, 50, 50, 50 };
int adet = 0;
int sayi;

Console.Write("lütfen bir sayı giriniz :");
sayi = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < sayilar.Length; i++)
{
    if (sayi == sayilar[i])
    {
        adet++;
    }
}

if (adet == 0)
{
    Console.WriteLine("Girdiğiniz değer dizide bulunamadı");
}
else
{
    Console.WriteLine("Girdiğiniz sayı dizide bulunmuştur ");
    Console.WriteLine("Adet    :" + adet);
}
Console.ReadLine();