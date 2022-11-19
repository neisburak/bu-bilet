using Core.Dto;

namespace Business.Session.Dto.Param;

public class ConnectionForSession : IDto
{
    public string IpAddress { get; set; } = default!;
    public string Port { get; set; } = default!;
}
