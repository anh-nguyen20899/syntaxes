namespace dotnet_syntax.Abstract;

public class FourByFour : Vehicle
{
    const int numPeopleCarry = 6;
    public FourByFour()
    {
    }

    public override string Name
    {
        get 
        {return "FourByFour";}
    }

    public override VehicleType GetVehicleType()
    {
        return VehicleType.Land;
    }
    public override string GetDescription()
    {
        return base.GetDescription() + Environment.NewLine + "FourByFour";
    }
    public override int GetNumberCanBeCarry()
    {
        return numPeopleCarry;
    }
}