namespace Core.Dto.Param;

public class Param<TParam> : IDto
{
    public SessionForDevice DeviceSession { get; set; } = default!;
    public string Date { get; set; } = default!;
    public string Language { get; set; } = default!;
    public TParam Data { get; set; } = default!;
}
