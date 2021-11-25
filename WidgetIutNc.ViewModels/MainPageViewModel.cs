using Ical.Net;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System.Reactive;
using WidgetIutNc.Api;

namespace WidgetIutNc.ViewModels;

public class MainPageViewModel
    : ReactiveObject
{

    public MainPageViewModel(IUpdatedCalendarFileDownloaderService calendarFileDownloaderService)
    {
        RefreshDataAsync = ReactiveCommand.CreateFromTask(async () => await calendarFileDownloaderService.GetUpdatedCalendarFileAsync().ConfigureAwait(true));
        RefreshDataAsync.BindTo(this, x => x.Description);

    }

    [Reactive]
    public string Description { get; set; }

    public ReactiveCommand<Unit, Calendar> RefreshDataAsync { get; }
}

