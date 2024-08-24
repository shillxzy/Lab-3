using System;
using System.ComponentModel;
using System.Numerics;
using System.Xml.Linq;

namespace Program
{
    class Employee
    {
        private string name;
        private float salary;
        private string position;
        private string department;
        private string email;
        private int age;


        public Employee(string n, float s, string p, string d, string e = "n/a", int a = -1)
        {
            name = n;
            salary = s;
            position = p;
            department = d;
            email = e;
            age = a;
        }

      

        public void Display()
        {
            Console.WriteLine(name + " " + salary + " " + email + " " + age);
        }

       
        public void HighAverageSalary(List<Employee> list)
        {
            string higherdept = "";
            float highersal = 0;

            for(int i = 0; i < list.Count; i++)
            {
                float total = 0;
                int count = 0;
                string depart = list[i].department;

                for(int j = 0; j < list.Count; j++)
                {
                    total += list[i].salary;
                    count++;
                }

                float average = total / count;

                if (average > highersal)
                {
                    highersal = average;
                    higherdept = depart;
                }
            }

            Console.WriteLine("Highest Average Salary: " + higherdept);

            for(int i = 0; i < list.Count; i++)
            {
                if(list[i].department == higherdept)
                list[i].Display();
            }

        }


    }


    class Prog
    {

        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();
            Employee employee = new Employee("", 0, "", "", "", -1);


            for (int i = 0; i < N; i++)
            {
                string[] a = Console.ReadLine().Split(' ');

                string name = a[0];
                float salary = float.Parse(a[1]);
                string position = a[2];
                string department = a[3];
                string email = "n/a";
                int age = -1;

                if (a.Length > 4) email = a[4];
                if (a.Length > 5) age = int.Parse(a[5]);
                
                employee = new Employee(name, salary, position, department, email, age);
                list.Add(employee);
            }
            Console.WriteLine();

            employee.HighAverageSalary(list);
            

        }
    }
}

/*
3
Pesho 120,00 Dev Development pesho@abv.bg 28
Toncho 333,33 Manager Marketing 33
Ivan 840,20 ProjectLeader Development ivan@ivan.com
 
 */