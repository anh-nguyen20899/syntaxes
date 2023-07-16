using dotnet_syntax.Abstract;

Vehicle[] myVehicles = new Vehicle[4]
    {
        new TaxiCab(),
        new FourByFour(),
        new SpeedBoat(),
        new Helicopter()
    };
foreach (var vehicle in myVehicles)
{
    Console.WriteLine(vehicle.Name + " goes on " + vehicle.GetVehicleType().ToString() + " It can carry: " + vehicle.GetNumberCanBeCarry());
    Console.WriteLine("-----------------------------------");
}
