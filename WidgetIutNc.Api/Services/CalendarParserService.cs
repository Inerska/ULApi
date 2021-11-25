using Ical.Net.CalendarComponents;
using System;
using WidgetIutNc.Api.Entities;

namespace WidgetIutNc.Api.Services;
public class CalendarParserService
    : ICalendarParserService
{
    public ParsedConcreteCalendar Parse(CalendarEvent @event)
    {
        if (@event is null)
            throw new ArgumentNullException(nameof(@event));

        return new ParsedConcreteCalendar(
            @event.DtStart.ToString(),
            @event.DtEnd.ToString(),
            @event.Summary,
            @event.Location,
            @event.Description);
    }
}
