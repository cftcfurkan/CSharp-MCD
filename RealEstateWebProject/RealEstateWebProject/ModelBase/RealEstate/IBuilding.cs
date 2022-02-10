using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebProject.ModelBase.RealEstate
{
    interface IBuilding
    {
        int SqNet { get; set; }
        string NumberOfRooms { get; set; }
        string AgeOfBuilding { get; set; }
        Heating Heating { get; set; }
        UserStatus UserStatus { get; set; }
        string ApartmentComplexName { get; set; }
        string Dues { get; set; }
    }
    public enum Heating
    {
        None,
        HeatingStoves,
        NaturalGasStove,
        RoomHeater,
        CentralHeating,
        CentralHeatingShareMeter,
        CentralHeatingBoilers,
        FloorHeating,
        AirConditioning,
        FanCoilUnit,
        SolarEnergy,
        Fireplace,
        Geothermal,
        VRV,
        HeatPump
    }
    public enum UserStatus
    {
        Empty,
        Renting,
        Proprietor
    }
}
