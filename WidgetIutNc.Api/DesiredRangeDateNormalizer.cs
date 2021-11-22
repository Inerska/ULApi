using System;

namespace WidgetIutNc.Api;

public static class DesiredRangeDateNormalizer
{
    public static (string dateStart, string dateEnd) GetNormalizedRangeDateWeek(DateTime? firstDayOfWeek = null)
    {
        var firstDay = firstDayOfWeek ?? DateTime.Today;
        var lastDayOfWeek = firstDay.AddDays(7);

        return (
            $"{firstDayOfWeek.Value.Year}/{firstDayOfWeek.Value.Month}/{firstDayOfWeek.Value.Day}",
            $"{lastDayOfWeek.Year}/{lastDayOfWeek.Month}/{lastDayOfWeek.Day}");
    }
}

