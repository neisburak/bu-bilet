using Core.Options;

namespace Business.ApiClient;

public static class ApiClientConstants
{
    public const string Name = "OBilet";
    public static string SessionUrl { get; set; } = default!;
    public static string LocationUrl { get; set; } = default!;
    public static string JourneyUrl { get; set; } = default!;

    public static void SetUrls(this ApiConfigurationOptions options)
    {
        SessionUrl = options.SessionUrl;
        LocationUrl = options.LocationUrl;
        JourneyUrl = options.JourneyUrl;
    }
}
