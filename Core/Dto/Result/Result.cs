using System.Text.Json.Serialization;

namespace Core.Dto.Result;

public class Result<TResult> : IDto
{
    public string Status { get; set; } = default!;
    public TResult Data { get; set; } = default!;
    public string Message { get; set; } = default!;

    [JsonPropertyName("user-message")]
    public string UserMessage { get; set; } = default!;

    [JsonPropertyName("api-request-id")]
    public string ApiRequestId { get; set; } = default!;
    public string Controller { get; set; } = default!;
    
    [JsonPropertyName("client-request-id")]
    public string ClientRequestId { get; set; } = default!;

    [JsonIgnore]
    public bool IsSuccess => Status == "Success";
}
