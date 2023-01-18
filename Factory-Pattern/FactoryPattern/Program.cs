namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myNewVehicle = VehicleFactory.GetVehicle();
            
            Console.WriteLine($"The vehicle you created is pretty awesome, here are the details about your vehicle");
            myNewVehicle.Name();
            myNewVehicle.NumberOfWheels();
            myNewVehicle.Drive();
            myNewVehicle.WhichLaneToTravelIn();

        }
    }
}
