// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using FluentAssertions;
using ULApi.BusinessLayer.Mappings;
using Xunit;

namespace ULApi.Test.Mappings;

/// <summary>
/// Unitary tests of <see cref="GraphMapping"/> class.
/// </summary>
public class GraphMappingTests
{
    /// <summary>
    /// RenderQuery method should has a conform rendered query.
    /// </summary>
    [Fact]
    public void Graph_RenderQuery_Should_Be_Conform()
    {
        var a1 = new GraphMapping("query factuel");
        var a2 = new GraphMapping("news");
        var a3 = new GraphMapping("3");
        var a4 = new GraphMapping("4");
        a1.AddChildren(a2)
            .AddChildren(a4);
        a1.AddChildren(a3);
        a2.AddChildren(a4);

        var expected = @"query factuel{
news{
    4
    4
    }
3
}";
        a1.RenderQuery().Trim().Should().Be(expected);
    }

    /// <summary>
    /// RenderQuery method should has a conform query with root enabled.
    /// </summary>
    [Fact]
    public void Graph_RenderQuery_WithRoot_Ctor_Should_Be_Conform()
    {
        var a1 = new GraphMapping("factuel", true);
        var a2 = new GraphMapping("news");
        var a3 = new GraphMapping("3");
        var a4 = new GraphMapping("4");
        a1.AddChildren(a2)
          .AddChildren(a4);
        a1.AddChildren(a3);
        a2.AddChildren(a4);

        var expected = @"query factuel{
news{
    4
    4
    }
3
}";
        a1.RenderQuery().Trim().Should().Be(expected);
    }

    /// <summary>
    /// ParentSize recursive method should return the exact amount of parents of the current instance.
    /// </summary>
    [Fact]
    public void Graph_ParentSize_Should_Return_RightValues()
    {
        var a1 = new GraphMapping("factuel", true);
        var a2 = new GraphMapping("news");
        a1.AddChildren(a2);

        a2.ParentSize().Should().Be(1);
        a1.ParentSize().Should().Be(0);
    }
}
