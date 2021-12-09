// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Ical.Net.CalendarComponents;
using System;

namespace WidgetIutNc.Api.Services;
public static class IcalDateTimerParserService
{
    public static string Parse(this CalendarEvent source)
        => String.Format("{0:yyyy-MM-dd hh:mm tt}", source.DtStart);
}
