using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System.Collections.Generic;
using System.Reactive;
using WidgetIutNc.Api;
using WidgetIutNc.Api.Entities;

namespace WidgetIutNc.ViewModels;

public class MainPageViewModel
    : ReactiveObject
{
    public MainPageViewModel(
        IUpdatedCalendarFileDownloaderService calendarFileDownloaderService,
        ICalendarParserService calendarParserService)
    {
        RefreshDataAsync = ReactiveCommand.CreateFromTask(async () =>
        {
            var updatedCalendar = await calendarFileDownloaderService.GetUpdatedCalendarFileAsync().ConfigureAwait(true);
            var parsedCalendarEvents = new List<ParsedConcreteCalendar>();

            foreach(var @event in updatedCalendar.Events)
            {
                parsedCalendarEvents.Add(calendarParserService.Parse(@event));
            }

            return parsedCalendarEvents;
        });
        RefreshDataAsync.BindTo(this, x => x.Calendar);
    }

    [Reactive]
    public List<ParsedConcreteCalendar> Calendar { get; set; }

    public ReactiveCommand<Unit, List<ParsedConcreteCalendar>> RefreshDataAsync { get; }
}

