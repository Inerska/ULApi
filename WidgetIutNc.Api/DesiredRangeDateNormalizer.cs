using System;

namespace WidgetIutNc.Api;

public static class DesiredRangeDateNormalizer
{
    public static string GetNormalizedRangeDateWeek(DateTime? firstDayOfWeek = null)
    {
        // Si pas d'argument, je récupère la semaine actuelle
        firstDayOfWeek ??= DateTime.Today;

        // Sinon je récupère firstDayOfWeek + 7
        var rangeWeekDate = firstDayOfWeek.Value.AddDays(7);

        // je retourne le string sous forme normalisé : YYYY-MM-DD

        var wayO = rangeWeekDate.ToShortDateString();
        var way1 = rangeWeekDate.ToString();

        return "";
    }
}

