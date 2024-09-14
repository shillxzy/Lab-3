using System.ComponentModel.DataAnnotations;

class Car
{
    private string model;
    private float fuelamount;
    private float fuelkm;
    private float distance;

    public Car(string m, float fa, float fkm)
    {
        model = m;
        fuelamount = fa;
        fuelkm = fkm;
        distance = 0;
    }

    public void Display()
    {
        Console.WriteLine(model + " " + fuelamount + " "  + distance);
    }

    public bool Drive(float disttraveled)
    {
        float need = distance * fuelkm;

        if (need <= fuelamount)
        {
            fuelamount -= need;
            distance += disttraveled;
            return true;
        }
        else
        {
            Console.Write("Недостатньо палива для руху.");
            return false;
        }
    }

    public string Model
    {
        get { return model; }
    }

}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int N = int.Parse(Console.ReadLine());
        List<Car> list = new List<Car>();
        Car car = new Car("", 0, 0);

        for (int i = 0; i < N; i++)
        {
            string[] a = Console.ReadLine().Split(' ');

            string model = a[0];
            float fuelamount = float.Parse(a[1]);
            float fuelkm = float.Parse(a[2]);

            car = new Car(model, fuelamount, fuelkm);
            list.Add(car);
        }

        string command = null;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] input = command.Split();

            string currentModel = input[1];
            int currentDistanse = int.Parse(input[2]);

            Car currentCar = null;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Model == currentModel)
                {
                    currentCar = list[i];
                    break;
                }
            }

            if (currentCar != null)
            {
                currentCar.Drive(currentDistanse);
            }
            else
            {
                Console.WriteLine(currentModel + " не знайдено.");
            }

          
        } 

        for(int i = 0; i < list.Count; i++)
        {
            list[i].Display();
        }


    }
}

/*
2
AudiA4 23 0,3
BMW-M2 45 0,42
Drive BMW-M2 56
Drive AudiA4 5
Drive AudiA4 13
End
 */
