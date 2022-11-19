using Core.Dto;

namespace Business.Location.Dto.Result;

public class GeoForLocation : IDto
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public int Zoom { get; set; }
}
