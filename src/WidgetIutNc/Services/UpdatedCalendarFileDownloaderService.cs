// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Ical.Net;
using System;
using System.Net.Http;
using System.Threading.Tasks;
namespace WidgetIutNc.Api;

public class UpdatedCalendarFileDownloaderService
    : IUpdatedCalendarFileDownloaderService
{
    public async Task<Calendar> GetUpdatedCalendarFileAsync()
    {
        var range = DesiredRangeDateNormalizer.GetNormalizedRangeDateWeek();
        var firstDate = range.firstDate;
        var lastDate = range.lastDate;
        var baseUrl = AppSecretsProviderService.API_BASE_URL;
        var remoteUri = baseUrl + $"&firstDate={firstDate}&lastDate={lastDate}";
        var url = new Uri(remoteUri);
        var handler = new HttpClientHandler() {
            AllowAutoRedirect = false
        };
        using var client = new HttpClient(handler);
        var responseString = await client.GetStringAsync(url);
        var calendar = Calendar.Load(responseString);

        return calendar ??
            throw new Exception("Cannot load load responseString during calendar parsing.");
    }
}
