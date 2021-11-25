using System;
using System.ComponentModel;

namespace WidgetIutNc.Api.Entities
{
    public record class ParsedConcreteCalendar(
        DateTime StartDate,
        DateTime EndDate,
        string Summary,
        string Location,
        string Description);
}

namespace System.Runtime.CompilerServices
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class IsExternalInit { }
}