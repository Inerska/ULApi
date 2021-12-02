// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace WidgetIutNc.ViewModels.Controls;
public class ScheduleCellViewModel
    : ReactiveObject
{
    [Reactive]
    public string StartDate { get; set; }

    [Reactive]
    public string EndDate { get; set; }

    [Reactive]
    public string Location { get; set; }

    [Reactive]
    public string Description { get; set; }
}
