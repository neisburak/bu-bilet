namespace Core.Options;

public class ApiConfigurationOptions
{
    public string Token { get; set; } = default!;
    public string BaseUrl { get; set; } = default!;
    public string SessionUrl { get; set; } = default!;
    public string LocationUrl { get; set; } = default!;
    public string JourneyUrl { get; set; } = default!;
    public string PartnerLogo { get; set; } = default!;
    public int SessionTimeout { get; set; }
}
