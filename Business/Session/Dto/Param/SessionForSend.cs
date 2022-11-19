using Core.Dto;

namespace Business.Session.Dto.Param;

public class SessionForSend : IDto
{
    public int Type { get; set; }
    public ConnectionForSession Connection { get; set; } = default!;
    public BrowserForSession Browser { get; set; } = default!;
}
