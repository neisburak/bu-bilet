using Core.Dto;

namespace Business.Location.Dto.Result;

public class LocationForBus : IDto
{
    public int Id { get; set; }
    public int ParentId { get; set; }
    public string Type { get; set; } = default!;
    public string Name { get; set; } = default!;
    public GeoForLocation GeoLocation { get; set; } = default!;
    public int Zoom { get; set; }
    public string TzCode { get; set; } = default!;
    public string WeatherCode { get; set; } = default!;
    public int Rank { get; set; }
    public string ReferenceCode { get; set; } = default!;
    public string Keywords { get; set; } = default!;
}
