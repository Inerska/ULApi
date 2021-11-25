using WidgetIutNc.ViewModels.Controls;
using Windows.UI.Xaml.Controls;

namespace WidgetIutNc.Uwp.Controls;
public sealed partial class ScheduleCell
    : UserControl
{
    public ScheduleCell(ScheduleCellViewModel scheduleCellViewModel)
    {
        InitializeComponent();

        this.DataContext = scheduleCellViewModel;
    }
}
