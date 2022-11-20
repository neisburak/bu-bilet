using System.Text.Json.Serialization;
using Core.Dto;

namespace Business.Journey.Dto.Result;

public class JourneyForBus : IDto
{
    public int Id { get; set; }

    [JsonPropertyName("partner-id")]
    public int PartnerId { get; set; }

    [JsonPropertyName("partner-name")]
    public string PartnerName { get; set; } = default!;

    [JsonPropertyName("route-id")]
    public int RouteId { get; set; }

    [JsonPropertyName("bus-type")]
    public string BusType { get; set; } = default!;

    [JsonPropertyName("bus-type-name")]
    public string BusTypeName { get; set; } = default!;

    [JsonPropertyName("total-seats")]
    public int TotalSeats { get; set; }

    [JsonPropertyName("available-seats")]
    public int AvailableSeats { get; set; }

    [JsonPropertyName("origin-location")]
    public string OriginLocation { get; set; } = default!;

    [JsonPropertyName("destination-location")]
    public string DestinationLocation { get; set; } = default!;
    public DetailForJourney Journey { get; set; } = default!;
}
