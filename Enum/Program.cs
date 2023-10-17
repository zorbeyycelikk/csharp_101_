namespace Enum // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);
            Console.WriteLine((int)Gunler.Cuma);
            Console.WriteLine(" ");

            int sicaklikDegeri = 14;

            if (sicaklikDegeri <= (int)HavaDurumu.Normal)
            {
                Console.WriteLine(HavaDurumu.Soguk);
            }else if (sicaklikDegeri >= (int)HavaDurumu.Sicak)
            {
                Console.WriteLine(HavaDurumu.CokSicak);
            }
            
            
        }

        enum Gunler
        {
            // default sıfırdan baslar
            
            Pazartesi,// 0
            Sali,     // 1
            Carsamba, // 2
            Persembe, // 3
            Cuma = 23,     // 4
            Cumartesi,// 5
            Pazar     // 6
        }

        enum HavaDurumu
        {
            Soguk = 5,
            Normal = 20,
            Sicak = 25,
            CokSicak = 30,
        }
    }
}