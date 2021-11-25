namespace WidgetIutNc.Api.Entities;
public class ParsedConcreteCalendar
{
    public ParsedConcreteCalendar(
        string startDate, 
        string endDate, 
        string summary, 
        string location, 
        string description)
    {
        StartDate = startDate;
        EndDate = endDate;
        Summary = summary;
        Location = location;
        Description = description;
    }

    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public string Summary { get; set; }
    public string Location { get; set; }
    public string Description { get; set; }
}


