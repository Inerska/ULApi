using Ical.Net.CalendarComponents;
using System;

namespace WidgetIutNc.Api.Services;
public static class IcalDateTimerParserService
{
    public static string Parse(this CalendarEvent source)
        => String.Format("{0:yyyy-MM-dd hh:mm tt}", source.DtStart);
}
