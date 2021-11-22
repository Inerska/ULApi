using System;

namespace WidgetIutNc.Api;

public static class DesiredRangeDateNormalizer
{
    public static Tuple<string, string> GetNormalizedRangeDateWeek(DateTime? firstDayOfWeek = null)
    {
        firstDayOfWeek ??= DateTime.Today;

        var lastDayOfWeek = firstDayOfWeek.Value.AddDays(7);

        return Tuple.Create(
            $"{firstDayOfWeek.Value.Year}/{firstDayOfWeek.Value.Month}/{firstDayOfWeek.Value.Day}",
            $"{lastDayOfWeek.Year}/{lastDayOfWeek.Month}/{lastDayOfWeek.Day}");
    }
}

