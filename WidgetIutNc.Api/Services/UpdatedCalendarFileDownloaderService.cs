using Ical.Net;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WidgetIutNc.Api;

public class UpdatedCalendarFileDownloaderService
    : IUpdatedCalendarFileDownloaderService
{
    private readonly IConfiguration _configuration;

    public UpdatedCalendarFileDownloaderService(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    public async Task<Calendar> GetUpdatedCalendarFileAsync()
    {
        var range = DesiredRangeDateNormalizer.GetNormalizedRangeDateWeek();
        var firstDate = range.firstDate;
        var lastDate = range.lastDate;
        var baseUrl = _configuration["Api:Schedule:BaseUrl"] ??
            throw new ArgumentNullException("Cannot retrieve secrets Api Schedule BaseUrl.");
        var remoteUri = baseUrl + $"&firstDate={firstDate}&lastDate={lastDate}";
        var url = new Uri(remoteUri);

        var handler = new HttpClientHandler()
        {
            AllowAutoRedirect = false
        };
        using var client = new HttpClient(handler);
        var responseString = await client.GetStringAsync(url);
        var calendar = Calendar.Load(responseString);
        return calendar ??
            throw new Exception("Cannot load load responseString during calendar parsing.");
    }
}
