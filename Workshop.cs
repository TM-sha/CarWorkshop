using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop
{
    internal class Workshop
    {
        private List<Mechanic> _mechanics = new();

        public Workshop(List<Mechanic> list)
        {
            _mechanics = list;
        }

        public void RunWorkshop(Car car)
        {
            Console.WriteLine($"En {car.Model} ruller inn på verkstedet.\n");

            Random mech = new();
            int randomNum = mech.Next(0, _mechanics.Count -1);

            _mechanics[randomNum].CheckVehicle(car, "motoren");
            _mechanics[randomNum].CheckVehicle(car, "bremsene");

            if (car.Engine && car.Brakes) Console.WriteLine("Bilen er klar for å hentes.\n");
        }
    }
}
