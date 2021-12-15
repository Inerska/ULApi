// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using FluentAssertions;
using System;
using ULApi.BusinessLayer.Mappings;
using Xunit;

namespace ULApi.Test.Mappings;
public class GraphMappingTests
{
    [Fact]
    public void Graph_ToString_Overide_Should_Be_Conform()
    {
        var a1 = new GraphMapping("query factuel");
        var a2 = new GraphMapping("news");
        var a3 = new GraphMapping("3");
        var a4 = new GraphMapping("4");
        a1.AddChildren(a2);
        a2.AddChildren(a4);
        a1.AddChildren(a3);
        a2.AddChildren(a4);

        var expected = @"query factuel{
news{
    4
    4
    }
3
}";
        a1.RenderQuery().Should().Be(expected);
    }
}
