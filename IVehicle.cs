using System;

namespace InterfaceExercise.interfaces
{
	public interface IVehicle
	{
		int NumberOfwheels { get; set; }
		string Color { get; set; }
		bool HasEngine { get; set; }
		string FuelType { get; set; }


		void DisplayDetails();

    }
}
public class Class1
{
	public Class1()
	{
	}
}
