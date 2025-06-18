namespace ConsoleUI
{
    interface IVehicle
    {
        string Make { get; set; }
        string Model { get; set; }
        string Year { get; set; }

        void Drive();
    }
}