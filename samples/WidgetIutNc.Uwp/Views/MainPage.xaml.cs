using Microsoft.Extensions.DependencyInjection;
using WidgetIutNc.ViewModels;
using Windows.UI.Xaml.Controls;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WidgetIutNc.Uwp;

/// <summary>
/// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
/// </summary>
public sealed partial class MainPage
    : Page
{
    public MainPage()
    {
        InitializeComponent();
        DataContext = App.Current.Services.GetService<MainPageViewModel>();
    }
}