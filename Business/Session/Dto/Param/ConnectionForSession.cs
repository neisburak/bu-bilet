using System.Text.Json.Serialization;
using Core.Dto;

namespace Business.Session.Dto.Param;

public class ConnectionForSession : IDto
{
    [JsonPropertyName("ip-address")]
    public string IpAddress { get; set; } = default!;
    public string Port { get; set; } = default!;
}
