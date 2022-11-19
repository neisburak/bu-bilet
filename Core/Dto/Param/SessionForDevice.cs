namespace Core.Dto.Param;

public class SessionForDevice : IDto
{
    public string SessionId { get; set; } = default!;
    public string DeviceId { get; set; } = default!;
}
