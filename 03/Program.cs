using System.ComponentModel;

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

    class Family : Person
    {
        private List<Person> members;
        public Family()
        {
            members = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.members.Add(member);
        }

        public Person GetOldestMember()
        {
            Person oldest = members[0];

            for (int i = 1; i < members.Count; i++) 
            {
                if (members[i].Age > oldest.Age)
                {
                    oldest = members[i];
                }
            }
            return oldest;

        }
    }

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();


            for(int i = 0; i < n; i++)
            {
                string[] a = Console.ReadLine().Split(' ');
                string name = a[0]; 
                int age = int.Parse(a[1]);  

                Person person = new Person(name, age);
                family.AddMember(person);
            }
            Console.WriteLine();

            Person older = family.GetOldestMember();
            Console.WriteLine(older.Name + " " + older.Age);











        }
    }
}