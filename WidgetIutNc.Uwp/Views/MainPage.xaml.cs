using WidgetIutNc.Api;
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

        var dbgRange = DesiredRangeDateNormalizer.GetNormalizedRangeDateWeek();

        dbgTextBlock.Text = $"Hey + {dbgRange.Item1} - {dbgRange.Item2}";
    }
}
