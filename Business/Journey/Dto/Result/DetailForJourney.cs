using System.Text.Json.Serialization;
using Core.Dto;

namespace Business.Journey.Dto.Result;


public class DetailForJourney : IDto
{
    [JsonPropertyName("id")]
    public string Kind { get; set; } = default!;
    public string Code { get; set; } = default!;
    public string Origin { get; set; } = default!;
    public string Destination { get; set; } = default!;
    public string Departure { get; set; } = default!;
    public string Arrival { get; set; } = default!;
    public string Currency { get; set; } = default!;
    public string Duration { get; set; } = default!;
    public decimal OriginalPrice { get; set; }
    public decimal InternetPrice { get; set; }
    public decimal ProviderInternetPrice { get; set; }
    public string BusName { get; set; } = default!;
    public string Description { get; set; } = default!;
    public PolicyForDetail Policy { get; set; } = default!;
    public IList<string> Features { get; set; } = new List<string>();
}
