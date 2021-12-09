// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace WidgetIutNc.Api.Entities;
public class StudentGroup
{
    public string Name { get; set; }
    public List<GroupLocalization> GroupLocalizations { get; set; }
}
