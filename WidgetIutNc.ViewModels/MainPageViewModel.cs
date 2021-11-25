using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System.Reactive;
using WidgetIutNc.Api;

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
            var calendar = await calendarFileDownloaderService.GetUpdatedCalendarFileAsync().ConfigureAwait(true);
            var parsedCalendar = calendarParserService.Parse(calendar.Events[1]);

            return parsedCalendar.ToString();
        });
        RefreshDataAsync.BindTo(this, x => x.Description);
    }

    [Reactive]
    public string Description { get; set; }

    public ReactiveCommand<Unit, string> RefreshDataAsync { get; }
}

