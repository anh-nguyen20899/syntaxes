namespace dotnet_syntax.Abstract;

public class Helicopter : Vehicle
{
    const int numPeopleCarry = 4;
    public Helicopter()
    {
    }

    public override string Name
    {
        get 
        {return "Helicopter";}
    }

    public override VehicleType GetVehicleType()
    {
        return VehicleType.Air;
    }
    public override string GetDescription()
    {
        return base.GetDescription() + Environment.NewLine + "Helicopter";
    }
    public override int GetNumberCanBeCarry()
    {
        return numPeopleCarry;
    }
}