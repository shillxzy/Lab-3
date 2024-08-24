namespace MyProgram
{

    class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person()
        {
            name = "No name";
            age = 1;
        }

        public Person(int age1)
        {
            name = "No name";
            age = age1;
        }

        public Person(string name1, int age1)
        {
            name = name1;
            age = age1;
        }



    }
    class Program
    {
        static void Main()
        {
            Person person1 = new Person();
            person1.Name = "Pesho";
            person1.Age = 20;

            Person person2 = new Person();

            Person person3 = new Person(30);
            Person person4 = new Person("Petro", 25);

            Console.WriteLine("Name: " + person1.Name + "; Age: " + person1.Age);
            Console.WriteLine("Name: " + person2.Name + "; Age: " + person2.Age);
            Console.WriteLine("Name: " + person3.Name + "; Age: " + person3.Age);
            Console.WriteLine("Name: " + person4.Name + "; Age: " + person4.Age);




        }
    }
}