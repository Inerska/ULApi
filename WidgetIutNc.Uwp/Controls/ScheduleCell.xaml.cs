// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Microsoft.Extensions.DependencyInjection;
using ReactiveUI.Fody.Helpers;
using WidgetIutNc.ViewModels.Controls;
using Windows.UI.Xaml.Controls;

namespace WidgetIutNc.Uwp.Controls;

public sealed partial class ScheduleCell
        : UserControl
{
    public ScheduleCell()
    {
        InitializeComponent();
        DataContext = App.Current.Services.GetService<ScheduleCellViewModel>();
    }

    [Reactive]
    public string UserInput { get; set; }
}