namespace ErisimBelirleyicilerVeKurucuFonksiyonlar // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Söz dizimi
            // class sinifAdi
            //{
            //[Erişim belirleyici] [Veri tipi] OzellikAdi;
            //[Erişim belirleyici] [Geri dönüş tipi] MetotAdi([Parametre Listesi])
            //{
            //Metot komutları
            //}
            //}

            //Erişim belirleyiciler
            // * Public
            // * Private
            // * Internal -> sadece bu proje içinden erişiliebilir
            // * Protected -> miras verilebilir

            Console.WriteLine("*****Çalışan 1******");
            Calisan calisan1 = new Calisan("Zorbey","Celik",1806538,"IT");
            calisan1.CalisanBilgileri();
            Console.WriteLine(" ");

            Console.WriteLine("*****Çalışan 2******");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Mert";
            calisan2.Soyad = "Ali";
            calisan2.No = 123456;
            calisan2.Departman = "SatınAlma";
            calisan2.CalisanBilgileri();
            Console.WriteLine(" ");

            Console.WriteLine("*****Çalışan 3******");
            Calisan calisan3 = new Calisan("Ali","Veli");
            calisan3.CalisanBilgileri();
        }

        class Calisan
        {
            public string Ad;
            public string Soyad;
            public int No;
            public string Departman;

            //Constructor 1 Ad+Soyad+No+Departman
            public Calisan(string ad, string soyad, int no, string departman) // Constructor 
            {
                this.Ad = ad;
                this.Soyad = soyad;
                this.No = no;	
                this.Departman = departman;	
            }
            //Constructor 2 Parametresiz
            public Calisan() { } 

            // Constructor 3 Ad+Soyad
            public Calisan(string ad, string soyad)
            {
                this.Ad = ad;
                this.Soyad = soyad;
            } 

            public void CalisanBilgileri()
            {
                Console.WriteLine("Çalışanın Adı: {0}", Ad);
                Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
                Console.WriteLine("Çalışanın Numarası: {0}", No);
                Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
            }
        }
    }
}