namespace dotnet_syntax.Abstract;

public class SpeedBoat : Vehicle
{
    const int numPeopleCarry = 3;
    public SpeedBoat()
    {
    }

    public override string Name
    {
        get 
        {return "SpeedBoat";}
    }

    public override VehicleType GetVehicleType()
    {
        return VehicleType.Water;
    }
    public override string GetDescription()
    {
        return base.GetDescription() + Environment.NewLine + "SpeedBoat";
    }
    public override int GetNumberCanBeCarry()
    {
        return numPeopleCarry;
    }
}