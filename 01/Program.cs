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
    
    }
    class Program
    {
        static void Main()
        {
            Person person1 = new Person();
            person1.Name = "Pesho";
            person1.Age = 20;

            Person person2 = new Person();
            person2.Name = "Gosho";
            person2.Age = 30;

            Person person3 = new Person();
            person2.Name = "Maria";
            person2.Age = 50;
        }
    }
}