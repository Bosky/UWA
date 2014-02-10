namespace UWA.Core.BL.Interfaces
{
    public interface IBusinessEntity
    {
        int Id { get; set; }
    }

    public interface IMapsObject
    {
        double Longitude { get; set; }
        double Latitude { get; set; }
    }
}
