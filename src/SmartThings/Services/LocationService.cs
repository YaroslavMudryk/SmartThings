namespace SmartThings.Services;

public interface ILocationService
{

}

public class LocationService : ILocationService
{
    private readonly SmartThingsClient _smartThingsClient;
    private readonly string _locationUrl;
    private readonly string _token;

    public LocationService(SmartThingsClient smartThingsClient)
    {
        _smartThingsClient = smartThingsClient;
        _token = _smartThingsClient.GetBearerToken();
        _locationUrl = _smartThingsClient.GetBaseUrl() + "/locations";
    }
}
