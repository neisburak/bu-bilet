using Core.Dto;

namespace Business.Session.Dto.Param;

public class BrowserForSession : IDto
{
    public string Name { get; set; } = default!;
    public string Version { get; set; } = default!;
}
