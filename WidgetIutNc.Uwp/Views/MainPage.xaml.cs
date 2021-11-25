using WidgetIutNc.Uwp.ViewModels;
using Windows.UI.Xaml.Controls;

namespace WidgetIutNc.Uwp;

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainPage
    : Page
{
    private readonly MainPageViewModel _viewModel;
    public MainPage(MainPageViewModel viewModel)
    {
        this.InitializeComponent();

        _viewModel = viewModel;

        this.DataContext = _viewModel;
    }
}
