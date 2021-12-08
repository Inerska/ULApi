// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using WidgetIutNc.Api.Entities;

namespace WidgetIutNc.Api;
public interface IStudentGroupScraperService
{
    public IEnumerable<StudentGroup> Scrap();
}
