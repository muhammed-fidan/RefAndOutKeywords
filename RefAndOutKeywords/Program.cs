using System;

namespace RefAndOutKeywords
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine("Metot çağırılmadan önce a'nın değeri: " + a);
            VeriyiAl(a);
            Console.WriteLine("Metot çağırıldıktan sonra a'nın değeri: " + a);
            Console.WriteLine("-------REF KEYWORD----------");
            Console.WriteLine("Metot çağırılmadan önce a'nın değeri: " + a);
            VeriyiAl2(ref a);
            Console.WriteLine("Metot çağırıldıktan sonra a'nın değeri: " + a);
            Console.ReadKey();
        }

        public static void VeriyiAl(int a)
        {
            a = a + 20;
            Console.WriteLine("a'nın metot içindeki değeri: " + a);
        }

        //Şimdi a'değerini ref keywordu ile çağırıp farkı göreceğiz.
        public static void VeriyiAl2(ref int a)
        {
            
            a = a + 20;
            Console.WriteLine("a'nın metot içindeki değeri: " + a);
        }
        //Gördüğünüz gibi a'nın değeri bu sefer 30 oldu. Aslında biz a'nın değerini değiştirmedik, metot ile paylaşılan a'nın orjinal değerini güncellemiş olduk. 
        //Ref keywordu kullanımı; parametrenin gerçek değerle değil, referansla geçmesine neden olmasıdır.
    }
}

