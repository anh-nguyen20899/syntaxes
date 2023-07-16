namespace dotnet_syntax.Abstract;

public class TaxiCab : Vehicle
{
    const int numPeopleCarry = 7;
    public TaxiCab()
    {
    }

    public override string Name
    {
        get 
        {return "Taxi";}
    }

    public override VehicleType GetVehicleType()
    {
        return VehicleType.Land;
    }
    public override string GetDescription()
    {
        return base.GetDescription() + Environment.NewLine + "TaxiCab";
    }
    public override int GetNumberCanBeCarry()
    {
        return numPeopleCarry;
    }
}