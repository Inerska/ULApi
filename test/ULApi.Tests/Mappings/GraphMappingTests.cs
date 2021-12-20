// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using ULApi.BusinessLayer.Mappings;
using Xunit;

namespace ULApi.Test.Mappings;

/// <summary>
///     Unitary tests of <see cref="GraphMapping" /> class.
/// </summary>
public class GraphMappingTests
{
    /// <summary>
    /// </summary>
    [Fact]
    public void test_Ctor_GraphMapping()
    {
        // Test GraphMapping initialization
        var graphMapping = new GraphMapping();
        Assert.NotNull(graphMapping);
    }

    /// <summary>
    /// </summary>
    [Fact]
    public void test_GraphMapping_Nodes_AddElement()
    {
        var graphMapping = new GraphMapping
        {
            // Create 3 node and add them to the graph, with one with 2 children
            "Hey",
            "Hello",
            {
                "World", new GraphMapping {"hello", "Dude"}
            }
        };

        // Test if the graph has 3 nodes
        Assert.Equal(3, graphMapping.Count);
    }
}