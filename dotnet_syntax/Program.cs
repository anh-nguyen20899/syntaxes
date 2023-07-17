using dotnet_syntax.Abstract;
using dotnet_syntax.Strategy;

// Vehicle[] myVehicles = new Vehicle[4]
//     {
//         new TaxiCab(),
//         new FourByFour(),
//         new SpeedBoat(),
//         new Helicopter()
//     };
// foreach (var vehicle in myVehicles)
// {
//     Console.WriteLine(vehicle.Name + " goes on " + vehicle.GetVehicleType().ToString() + " It can carry: " + vehicle.GetNumberCanBeCarry());
//     Console.WriteLine("-----------------------------------");
// }

Duck mallard = new MallardDuck();
mallard.Display();
mallard.setFlyBehavior(new FlyRocketPowered());
mallard.PerformQuack();
mallard.PerformFly();
Console.WriteLine("------------------------");
Duck decoy = new DecoyDuck();
decoy.Display();
decoy.PerformQuack();
decoy.PerformFly();
