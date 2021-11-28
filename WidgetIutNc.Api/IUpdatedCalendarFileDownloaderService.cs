// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

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

