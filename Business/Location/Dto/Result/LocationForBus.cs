using System.Text.Json.Serialization;
using Core.Dto;

namespace Business.Location.Dto.Result;

public class LocationForBus : IDto
{
    public int Id { get; set; }

    [JsonPropertyName("parent-id")]
    public int ParentId { get; set; }
    public string Type { get; set; } = default!;
    public string Name { get; set; } = default!;
    public int Zoom { get; set; }

    [JsonPropertyName("tz-code")]
    public string TzCode { get; set; } = default!;

    [JsonPropertyName("weather-code")]
    public string WeatherCode { get; set; } = default!;
    public int? Rank { get; set; }
    [JsonPropertyName("reference-code")]
    public string ReferenceCode { get; set; } = default!;
    public string Keywords { get; set; } = default!;
}
