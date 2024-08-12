using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. 10 adet tam sayı verisi alacak bir dizi tanımlayınız.
        int[] dizi = new int[10];

        // 2. Bu dizinin elemanlarını bir for döngüsü ile doldurup, foreach döngüsü ile tekrar ekrana yazınız.
        Console.WriteLine("Lütfen 10 adet tam sayı giriniz:");
        for (int i = 0; i < dizi.Length; i++)
        {
            Console.Write($"{i + 1}. sayı: ");
            dizi[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nGirdiğiniz sayılar:");
        foreach (int sayi in dizi)
        {
            Console.WriteLine(sayi);
        }

        // 3. Bu diziye kullanıcıdan alınan yeni bir değeri ekleyiniz (11. eleman olarak)
        Console.Write("\nEklemek istediğiniz 11. sayıyı giriniz: ");
        int yeniSayi = Convert.ToInt32(Console.ReadLine());

        Array.Resize(ref dizi, dizi.Length + 1);
        dizi[dizi.Length - 1] = yeniSayi;

        // 4. Bu diziyi büyükten küçüğe ekrana yazdırınız.
        Array.Sort(dizi);
        Array.Reverse(dizi);

        Console.WriteLine("\nDizinin son hali (büyükten küçüğe):");
        foreach (int sayi in dizi)
        {
            Console.WriteLine(sayi);
        }
    }
}





