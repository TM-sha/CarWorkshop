using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop
{
    internal class Mechanic
    {
        public string Name;

        public Mechanic(string name)
        {
            Name = name;
        }

        public void CheckVehicle(Car car, string part)
        {
            Console.Write($"{Name} sjekker {part}\nTilstand på {part}: ");
            if (part == "motoren") Console.WriteLine(car.Engine ? "Virker\n" : car.RepairEngine(this));
            else Console.WriteLine(car.Brakes ? "Virker\n" : car.RepairBrakes(this));
        }
    }
}
