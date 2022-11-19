namespace Core.Dto.Result;

public class Result<TResult> : IDto
{
    public string Status { get; set; } = default!;
    public TResult Data { get; set; } = default!;
    public string Message { get; set; } = default!;
    public string UserMessage { get; set; } = default!;
    public string ApiRequestId { get; set; } = default!;
    public string Controller { get; set; } = default!;
    public string ClientRequestId { get; set; } = default!;
}
