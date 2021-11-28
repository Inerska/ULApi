// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

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
