namespace _Esercizio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.GetName();
            person.GetSurname();
            person.GetAge();
            person.GetMusicTaste();
            person.GetInfo();
            Console.ReadLine();
        }
    }

    class Person
    {
        private string _name;
        private string _surname;
        private int _age;
        private string _musicTaste;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Surname
        {
            get
            {
                return _surname; }

            set
            {
                _surname = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        public string MusicTaste
        {
            get
            {
                return _musicTaste;
            }
            set
            {
                _musicTaste = value;
            }
        }

        public void GetName()
        {
            Console.WriteLine("Insert name: ");
            _name = Console.ReadLine();
        }

        public void GetSurname()
        {
            Console.WriteLine("Insert surname: ");
            _surname = Console.ReadLine();
        }

        public void GetAge()
        {
            Console.WriteLine("Insert age: ");
            _age = int.Parse(Console.ReadLine());
        }

        public void GetMusicTaste()
        {
            Console.WriteLine("Insert favourite music: ");
            _musicTaste = Console.ReadLine();
        }

        public void GetInfo()
        {

            Console.WriteLine($"Details submitted: {Name} {Surname} {Age} {MusicTaste}");
        }
    }
}