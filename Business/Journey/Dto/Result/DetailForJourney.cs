using System.Text.Json.Serialization;
using Core.Dto;

namespace Business.Journey.Dto.Result;


public class DetailForJourney : IDto
{
    public string Kind { get; set; } = default!;
    public string Code { get; set; } = default!;
    public string Origin { get; set; } = default!;
    public string Destination { get; set; } = default!;
    public DateTime Departure { get; set; } = default!;
    public DateTime Arrival { get; set; } = default!;
    public string Currency { get; set; } = default!;
    public string Duration { get; set; } = default!;

    [JsonPropertyName("original-price")]
    public decimal OriginalPrice { get; set; }

    [JsonPropertyName("internet-price")]
    public decimal InternetPrice { get; set; }

    [JsonPropertyName("provider-internet-price")]
    public decimal? ProviderInternetPrice { get; set; }

    [JsonPropertyName("bus-name")]
    public string BusName { get; set; } = default!;
    public string Description { get; set; } = default!;
    public IList<string> Features { get; set; } = new List<string>();
}
