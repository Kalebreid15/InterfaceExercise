using ConsoleUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    class Truck : IVehicle , ICompany
    {
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool HasFlatBed { get; set; }
        public string Logo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DateEstablished { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Drive()

        {
            Console.WriteLine($"Driving in my {GetType().Name}");

        }
    }
}
