using Core.Dto;

namespace Business.Session.Dto.Result;

public class ResponseForSession : IDto
{
    public string SessionId { get; set; } = default!;
    public string DeviceId { get; set; } = default!;
    public string Affiliate { get; set; } = default!;
    public int DeviceType { get; set; }
    public string Device { get; set; } = default!;
    public string IpCountry { get; set; } = default!;
}
