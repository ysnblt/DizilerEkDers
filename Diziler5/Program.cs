// See https://aka.ms/new-console-template for more information

using System;

int[] sayilar = new int[10];
int tekSayilarinToplami = 0;
int ciftSayilarintoplami = 0;
int tekAdet = 0;
int ciftAdet = 0;
int kullanıcıDeger;

for(int i = 0; i < sayilar.Length; i++)
{
    Console.Write("İndex değerini giriniz :");
    kullanıcıDeger = int.Parse(Console.ReadLine());  // kullanıcıDeger = Convert.ToInt32(Console.Write(sayilar[i]);  dönüşüm yapmak için Pars da kullanılılabilir
    // Dizinin içini kullanıcıdan aldığımız değerle dolduruyoruz
    sayilar[i] = kullanıcıDeger;
}
for(int i = 0; i < sayilar.Length; i++)
{
    if(sayilar[i]%2 == 0)
    {
        ciftAdet++;
        ciftSayilarintoplami += sayilar[i];
    }//ikiye bölümünden kalan demek, çift sayıları böyle buluruz
    else
    {
        tekAdet++;
        tekSayilarinToplami += sayilar[i];
    }
}
Console.WriteLine("***************************");
Console.WriteLine("Çift sayıların toplamı");
Console.WriteLine(ciftSayilarintoplami);
Console.WriteLine("***************************");

Console.WriteLine("***************************");
Console.WriteLine("Tek sayıların toplamı");
Console.WriteLine(tekSayilarinToplami);
Console.WriteLine("***************************");

Console.WriteLine("***************************");
Console.WriteLine("Çift sayıların adeti");
Console.WriteLine(ciftAdet);
Console.WriteLine("***************************");

Console.WriteLine("***************************");
Console.WriteLine("Tek sayıların adeti");
Console.WriteLine(tekAdet);
Console.WriteLine("***************************");

if(ciftSayilarintoplami>tekSayilarinToplami)
{
    Console.WriteLine("Çift sayıların toplamı, tek sayıların toplamından daha fazladır");
}
else
{
    Console.WriteLine("Tek sayıların toplamı, çift sayıların toplamından daha fazladır");
}