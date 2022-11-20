using System.Text.Json.Serialization;
using Core.Dto;
using Core.Dto.Param;

namespace Business.Session.Dto.Result;

public class ResponseForSession : SessionForDevice, IDto
{
    public string Affiliate { get; set; } = default!;

    [JsonPropertyName("device-type")]
    public int DeviceType { get; set; }
    public string Device { get; set; } = default!;

    [JsonPropertyName("ip-country")]
    public string IpCountry { get; set; } = default!;
}
