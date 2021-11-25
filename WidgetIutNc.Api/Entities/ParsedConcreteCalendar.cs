using System;
using System.ComponentModel;

namespace WidgetIutNc.Api.Entities
{
    public record class ParsedConcreteCalendar(
        string StartDate,
        string EndDate,
        string Summary,
        string Location,
        string Description);
}

namespace System.Runtime.CompilerServices
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class IsExternalInit { }
}