// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Ical.Net.CalendarComponents;
using WidgetIutNc.Api.Entities;

namespace WidgetIutNc.Api;
public interface ICalendarParserService
{
    /// <summary>
    /// Parse a source ICAL.NET Calendar Event to a ParsedConcreteCalendar ready to use.
    /// </summary>
    /// <returns>A parsed concrete calendar from a Calendar object source.</returns>
    public ParsedConcreteCalendar Parse(CalendarEvent @event);
}
