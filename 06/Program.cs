using System.Collections.Specialized;
using System.Drawing;

class Engine
{
    public string Model;
    public string power;
    public string volume;
    public string efficiency;

    public Engine(string m, string p, string v, string e)
    {
        Model = m;
        power = p;
        volume = v;
        efficiency = e;
    }

}

class Car
{ 
    private string model;
    private Engine engine;
    private string weight;
    private string color;

    public Car(string m, Engine e, string w , string c)
    {
        model = m;
        engine = e;
        weight = w;
        color = c;
    }

    public void Display()
    {
        Console.WriteLine(model + ":");
        Console.WriteLine(" "+ engine.Model + ":");
        Console.WriteLine("   Power: " + engine.power);
        Console.WriteLine("   Displacement: " + engine.volume);
        Console.WriteLine("   Efficiency: " + engine.efficiency);
        Console.WriteLine(" Weight: " + weight);
        Console.WriteLine(" Color: " + color);
        Console.WriteLine("--------------------------------");
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // ----------------------------------------------------------------------- //

        int N = int.Parse(Console.ReadLine());
        List<Engine> engines = new List<Engine>();

        for(int i = 0; i < N; i++)
        {
            string[] a = Console.ReadLine().Split(' ');

            string model = a[0];
            string power = a[1];
            string volume = "n/a";
            string efficiency = "n/a";

            if (a.Length > 2)
            {
                volume = a[2];
            }
            if (a.Length > 3)
            {
                efficiency = a[3];
            }

            Engine engine = new Engine(model, power, volume, efficiency);
            engines.Add(engine);
        }

        Console.WriteLine();
        // ----------------------------------------------------------------------- //

        int M = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();

        for(int i = 0; i < M; i++)
        {
            string[] a = Console.ReadLine().Split(' ');
            string model = a[0];
            string engine = a[1];
            string weight = "n/a";
            string color = "n/a";

            if(a.Length > 2)
            {
                weight = a[2];
            }
            if(a.Length > 3)
            {
                color = a[3];
            }

            Engine enginemodel = null;
            for (int j = 0; j < engines.Count; j++)
            {
                if (engines[j].Model == engine)
                {
                    enginemodel = engines[j];
                    break;
                }
            }

            if(engine != null)
            {
                Car car = new Car(model, enginemodel, weight, color);
                cars.Add(car);
            }
            else
            {
                Console.Write("Зупинка програми через проблеми.");
            }
        }
        Console.WriteLine();
        // ----------------------------------------------------------------------- //

        for (int i = 0; i < cars.Count; i++)
        {
            cars[i].Display();
        }
    }
}

/*
2
V8-101 220 50
V4-33 140 28 B
3
FordFocus V4-33 1300 Silver
FordMustang V8-101
VolkswagenGolf V4-33
 */