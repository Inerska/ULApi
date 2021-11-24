using System;

namespace WidgetIutNc.Api;

public static class DesiredRangeDateNormalizer
{
    public static (string firstDate, string lastDate) GetNormalizedRangeDateWeek(DateTime? firstDayOfWeek = null)
    {
        var firstDay = firstDayOfWeek ?? DateTime.Today;
        var lastDayOfWeek = firstDay.AddDays(7);

        return (
            $"{firstDay.Year}-{firstDay.Month}-{firstDay.Day}",
            $"{lastDayOfWeek.Year}-{lastDayOfWeek.Month}-{lastDayOfWeek.Day}");
    }
}

