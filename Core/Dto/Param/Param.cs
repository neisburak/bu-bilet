using System.Text.Json.Serialization;

namespace Core.Dto.Param;

public class Param<TParam> : IDto
{
    [JsonPropertyName("device-session")]
    public SessionForDevice DeviceSession { get; set; } = default!;
    public string Date => DateTime.Now.ToString("o");
    public string Language => "tr-TR";
    public TParam Data { get; set; } = default!;
}
