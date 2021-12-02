// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace WidgetIutNc.Uwp.Controls;

public partial class ScheduleCell
    : UserControl
{
    public string StartDate {
        get { return (string)GetValue(StartDateProperty); }
        set { SetValue(StartDateProperty, value); }
    }

    public static readonly DependencyProperty StartDateProperty =
        DependencyProperty.Register("StartDate", typeof(string), typeof(ScheduleCell), null);

    public string EndDate {
        get { return (string)GetValue(EndDateProperty); }
        set { SetValue(EndDateProperty, value); }
    }

    public static readonly DependencyProperty EndDateProperty =
        DependencyProperty.Register("EndDate", typeof(string), typeof(ScheduleCell), null);

    public string Location {
        get { return (string)GetValue(LocationProperty); }
        set { SetValue(LocationProperty, value); }
    }

    public static readonly DependencyProperty LocationProperty =
        DependencyProperty.Register("Location", typeof(string), typeof(ScheduleCell), null);

    public string Summary {
        get { return (string)GetValue(SummaryProperty); }
        set { SetValue(SummaryProperty, value); }
    }

    public static readonly DependencyProperty SummaryProperty =
        DependencyProperty.Register("Summary", typeof(string), typeof(ScheduleCell), null);

    public string Description {
        get { return (string)GetValue(DescriptionProperty); }
        set { SetValue(DescriptionProperty, value); }
    }

    public static readonly DependencyProperty DescriptionProperty =
        DependencyProperty.Register("Description", typeof(string), typeof(ScheduleCell), null);


    public ScheduleCell()
    {
        DataContext = this;
        InitializeComponent();
        //DataContext = App.Current.Services.GetService<ScheduleCellViewModel>();
    }
}