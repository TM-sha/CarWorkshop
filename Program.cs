namespace CarWorkshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Init();
        }

        private static void Init()
        {
            List<Car> cars = new List<Car>
            {
                new Car(true, false, "BMW 330i"),
                new Car(false, false, "Ford Focus RS"),
                new Car(true, true, "Mercedes Gelandewagen"),
                new Car(false, true, "Mazda RX8"),
                new Car(true, false, "Audi RS3"),
                new Car(false, false, "Nissan GTR"),
                new Car(false, true, "Porsche 911 Turbo"),
            };

            List<Mechanic> mechanic = new List<Mechanic>
            {
                new Mechanic("Tore"),
                new Mechanic("Tina"),
                new Mechanic("Kjetil"),
                new Mechanic("Kamilla"),
                new Mechanic("Leif"),
                new Mechanic("Line"),
            };

            Workshop workshop = new(mechanic);

            foreach (Car car in cars)
            {
                workshop.RunWorkshop(car);
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}