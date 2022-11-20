using System.Text.Json.Serialization;

namespace Core.Dto.Param;

public class SessionForDevice : IDto
{
    [JsonPropertyName("session-id")]
    public string SessionId { get; set; } = default!;
    
    [JsonPropertyName("device-id")]
    public string DeviceId { get; set; } = default!;
}
