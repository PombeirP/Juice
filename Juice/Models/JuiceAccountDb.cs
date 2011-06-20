using System;
using System.Collections.Generic;

namespace Juice.Models
{
    public class JuiceAccountDb
    {
        public JuiceAccountDb()
        {
            Vehicles = new List<Vehicle>
                           {
                               new Vehicle
                                   {
                                       EnginePower = 140,
                                       ExactModelName = "2.2 i-CTDi Executive Navi",
                                       FuelType = FuelType.Diesel,
                                       GearingType = GearingType.Manual,
                                       Make = "Honda",
                                       Model = "Accord",
                                       OdometerUnit = DistanceUnit.Kilometers,
                                       PowerUnit = PowerUnit.PS,
                                       YearOfManufacture = 2004,
                                       TankCapacity = 65,
                                       Fuelings = new List<Fueling>()
                                   }
                           };
        }

        public int AccountId { get; set; }
        public IList<Vehicle> Vehicles { get; set; }

        public string CurrencyUnit { get; set; }
        public VolumeUnit VolumeUnit { get; set; }
        public MassUnit MassUnit { get; set; }
    }

    public enum VolumeUnit
    {
        KmPerLiter,
        LitersPer100Kms,
        MpgUS,
        MpgImperial
    }

    public enum MassUnit
    {
        KmPerKg,
        KgsPer100Kms,
        MilesPerKg
    }

    public class Vehicle
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public FuelType FuelType { get; set; }
        public string ExactModelName { get; set; }
        public GearingType GearingType { get; set; }
        public int YearOfManufacture { get; set; }
        public int EnginePower { get; set; }
        public PowerUnit PowerUnit { get; set; }

        public DistanceUnit OdometerUnit { get; set; }
        public float TankCapacity { get; set; }

        public IList<Fueling> Fuelings { get; set; }
    }

    public class Fueling
    {
        public DateTime Date { get; set; }
        public float Odometer { get; set; }
        public float TripOdometer { get; set; }
        public float Quantity { get; set; }
        public float TotalPrice { get; set; }
        public string Currency { get; set; }
        public FuelingType Type { get; set; }
        public TireType Tires { get; set; }
        public RoadType Roads { get; set; }
        public DrivingStyle DrivingStyle { get; set; }
        public FuelSort Fuel { get; set; }
        public string Notes { get; set; }
    }

    public enum FuelSort
    {
        Diesel = 1,
        Biodiesel,
        VegetableOil,
        PremiumDiesel,
        NormalGasoline = 6,
        SuperGasoline,
        SuperPlusGasoline,
        PremiumGasoline100,
        LPG = 12,
        CNG_H,
        CNG_L,
        BioAlcohol,
        TwoStroke,
        PremiumGasoline95,
        Electricity,
        E10
    }

    public enum DrivingStyle
    {
        Moderate = 1,
        Normal = 2,
        Fast = 3
    }

    [Flags]
    public enum RoadType
    {
        Motorway = 0x02,
        City = 0x04,
        CountryRoads = 0x08
    }

    public enum TireType
    {
        WinterTires,
        SummerTires,
        AllYearTires
    }

    public enum FuelingType
    {
        Invalid,
        Full,
        Partial,
        Initial
    }

    public enum DistanceUnit
    {
        Kilometers,
        Miles
    }

    public enum PowerUnit
    {
        kW,
        PS,
        hp
    }

    public enum GearingType
    {
        Manual,
        Automatic,
        ContinuouslyVariable,
        DirectShiftGearbox
    }

    public enum FuelType
    {
        Petrol,
        Diesel
    }
}