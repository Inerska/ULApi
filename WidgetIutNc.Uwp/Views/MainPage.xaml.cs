// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Microsoft.Extensions.DependencyInjection;
using WidgetIutNc.ViewModels;
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
        this.DataContext = App.Current.Services.GetService<MainPageViewModel>();
    }
}
