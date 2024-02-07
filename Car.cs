using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop
{
    internal class Car
    {
        public bool Engine;
        public bool Brakes;
        public string Model;

        public Car(bool engine, bool brakes, string model)
        {
            Engine = engine;
            Brakes = brakes;
            Model = model;
        }

        public string RepairEngine(Mechanic mechanic)
        {
            Engine = !Engine;
            return $"Defekt\n{mechanic.Name} reparerer motoren..\n";
        }

        public string RepairBrakes(Mechanic mechanic)
        {
            Brakes = !Brakes;
            return $"Defekt\n{mechanic.Name} reparerer bremsene..\n";
        }
    }
}
