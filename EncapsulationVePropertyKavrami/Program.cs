namespace EncapsulationVePropertyKavrami // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci("Zorbey","Celik",1,"Ankara");
            ogrenci1.Print();
            ogrenci1.NoDecrease();
            ogrenci1.Print();

        }
    }

    class Ogrenci
    {
        private string name;
        private string surname;
        private int no;
        private string address;
        
        public Ogrenci(string name, string surname, int no, string address)
        {
            this.name = name;
            this.surname = surname;
            this.no = no;
            this.address = address;
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
            Console.WriteLine("Ogrenci Address : {0}",this.address);
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