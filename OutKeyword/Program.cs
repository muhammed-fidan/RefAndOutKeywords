using System;

namespace OutKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("i'nin önceki değeri:" + i);
            SonrakiAdiAl(i);
            Console.WriteLine("i'nin mevcut değeri:" + i);
            Console.WriteLine("------------OUT KEYWORD-----------");
            Console.WriteLine("i'nin önceki değeri::" + i);
            SonrakiAdiAl2(out i);
            Console.WriteLine("i'nin mevcut değeri:" + i);


        }
        public static string SonrakiAdiAl(int sayi)
        {
            sayi = 1;
            string returnText = "Next-" + sayi.ToString();
            return returnText;
        }

        //Şimdi out keywordu ile görelim birde..
        public static string SonrakiAdiAl2(out int sayi)
        {
            sayi = 1;
            string returnText = "Next-" + sayi.ToString();
            return returnText;
        }
        //out ve ref keyword birbirine çok benzer. Out keywordu kullanabilmek için kesinlikle metot içinde değişkene bir değer ataması yapılmak zorundadır. 
    }

   
}
