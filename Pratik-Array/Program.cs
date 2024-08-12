using System;
using System.Linq;

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. 10 adet tam sayı verisi alacak bir dizi tanımlayınız.
        int[] dizi = new int[10] { 5, 8, 2, 14, 9, 3, 7, 1, 12, 6 };

        // 2. Bu dizinin elemanlarını foreach döngüsü ile ekrana yazınız.
        Console.WriteLine("Dizinin elemanları:");
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





