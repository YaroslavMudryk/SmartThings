using SmartThings.Services;

namespace SmartThings;

public interface ISmartThingsClient
{
    string GetBearerToken();
    string GetBaseUrl();
}

public class SmartThingsClient(string token) : ISmartThingsClient
{
    protected readonly string _baseUrl = "https://api.smartthings.com/v1";
    protected readonly string _token = token;

    public SmartThingsClient() : this(null!)
    {
        LocationService = new LocationService(this);
    }

    public ILocationService LocationService { get; set; } = default!;

    public string GetBearerToken() => _token;

    public string GetBaseUrl() => _baseUrl;
}
