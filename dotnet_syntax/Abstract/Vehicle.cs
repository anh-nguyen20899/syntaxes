namespace dotnet_syntax.Abstract;

public abstract class Vehicle
{
    private int _numberCanBeCarry = 4;
    private string _description = " Can carry people";

    public enum VehicleType
    {
        Land, 
        Water,
        Air
    }
    public abstract string Name {get;}
    public abstract VehicleType GetVehicleType();
    public virtual string GetDescription()
    {
        return _description;
    }
    public virtual int GetNumberCanBeCarry()
    {
        return _numberCanBeCarry;
    }

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
}