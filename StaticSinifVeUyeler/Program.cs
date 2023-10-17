namespace StaticSinifVeUyeler // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci("Zorbey","Celik",1);
            ogrenci1.Print();
            ogrenci1.NoDecrease();
            ogrenci1.Print();
            
            // Nesne ile address'e erişmedik.
            Console.WriteLine(Ogrenci.address);
            
            // Nesne aracılığıyla no ' ya eriştik.Public ile alakalı değil static ile alakalı
            Console.WriteLine(ogrenci1.no);

        }
    }

    class Ogrenci
    {
        private string name;
        private string surname;
        public int no;
        public static string address;
        
        public Ogrenci(string name, string surname, int no)
        {
            this.name = name;
            this.surname = surname;
            this.no = no;
        }

        public Ogrenci(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public string Name
        {
            get { return name; }
            set => name = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Surname
        {
            get => surname;
            set => surname = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int No
        {
            get => no;
            set => no = value;
        }
        
        public string Address
        {
            get => address;
            set => address = value ?? throw new ArgumentNullException(nameof(value));
        }
        

        public void Print()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("Ogrenci Adi : {0}",this.name);
            Console.WriteLine("Ogrenci Soyadi : {0}",this.surname);
            Console.WriteLine("Ogrenci No : {0}",this.no);
            Console.WriteLine(" ");
        }

        public void NoIncrease()
        {
            this.no++;
        }
        public void NoDecrease()
        {
            if (!(this.no <= 1))
            {
                this.no--;
            }
            else
            {
                Console.WriteLine("No 1 'den daha dusuk olamaz ! ");
            }
        }
    }
}