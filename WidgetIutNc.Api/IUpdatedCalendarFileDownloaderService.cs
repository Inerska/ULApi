using Ical.Net;
using System.Threading.Tasks;

namespace WidgetIutNc.Api;

public interface IUpdatedCalendarFileDownloaderService
{
    /// <summary>
    /// Retrieve with GET HttpClient request the weekly updated calendar of all semester groups.
    /// </summary>
    /// <returns>The weekly updated calendar of all semester groups.</returns>
    public Task<Calendar> GetUpdatedCalendarFileAsync();
}

