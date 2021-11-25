using Microsoft.Extensions.DependencyInjection;
using WidgetIutNc.Uwp.ViewModels;
using Windows.UI.Xaml.Controls;

namespace WidgetIutNc.Uwp;

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainPage
    : Page
{
    public MainPage()
    {
        this.InitializeComponent();
        var container = (Windows.UI.Xaml.Application.Current as App)?.Container;
        this.DataContext = ActivatorUtilities.GetServiceOrCreateInstance(container, typeof(MainPageViewModel));
    }
}
