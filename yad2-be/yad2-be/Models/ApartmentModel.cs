namespace yad2_be.Models
{
    public enum PropertyType
    {
        Apartment,
        GardenApartment,
        PrivateHouse,
        Cottage,
        Penthouse,
        Land,
        Duplex,
        VacationApartment,
        SemiDetachedHouse,
        Basement,
        Triplex,
        HousingUnit,
        AgriculturalFarm,
        AuxiliaryFarm,
        ShelteredHousing,
        ResidentialBuilding,
        StudioLoft,
        Warehouse,
        Parking,
        PurchaseGroup,
        General
    }

    public enum PropertyCondition
    {
        NewFromContractor,
        New,
        Renovated,
        WellMaintained,
        NeedsRenovation
    }

    public enum View
    {
        None,
        Sea,
        Park,
        City
    }


    public class ApartmentModel
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public int Floor { get; set; }
        public int TotalFloors { get; set; }
        public string Neighborhood { get; set; }
        public string Region { get; set; }
        public PropertyType PropertyType { get; set; }
        public PropertyCondition PropertyCondition { get; set; }
        public int AirDirections { get; set; } // בין 1 ל-4
        public View OpenView { get; set; }
        public bool IsBackProperty { get; set; }
        public float NumberOfRooms { get; set; } // בין 0 ל-12.5
        public int NumberOfBathrooms { get; set; }
        public bool HasParking { get; set; }
        public bool HasBalcony { get; set; }
        public List<string> Features { get; set; }
        public string PropertyDescription { get; set; }
        public float BuiltArea { get; set; }
        public float TotalArea { get; set; }
        public decimal Price { get; set; }
        public decimal PricePerMeter { get; set; }
        public DateTime EntryDate { get; set; }
        public bool IsImmediate { get; set; }
        public bool IsFlexible { get; set; }
        public string OwnerName { get; set; }
        public string PhoneNumber { get; set; }
        public bool HasVirtualNumber { get; set; }
        public bool AcceptsCallsOnShabbat { get; set; }
    }
}
