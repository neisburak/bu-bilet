using Core.Dto;

namespace Business.Journey.Dto.Param;

public class LocationForJourney : IDto
{
    public int OriginId { get; set; }
    public int DestinationId { get; set; }
    public string DepartureDate { get; set; } = default!;
}
