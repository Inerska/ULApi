// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using System.Collections;

namespace ULApi.BusinessLayer.Mappings;

/// <summary>
///     Represents a Graph object relational mapping.
/// </summary>
public class GraphMapping
    : IEnumerable
{
    /// <summary>
    ///     Collection of nodes that are part of the graph.
    /// </summary>
    private readonly IList<Node> _nodes = new List<Node>();

    /// <summary>
    ///     Get the count of the collection of nodes.
    /// </summary>
    public int Count => _nodes.Count;

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _nodes.GetEnumerator();
    }


    /// <summary>
    ///     Add overload for <see cref="Node" />, accepting a value.
    /// </summary>
    /// <param name="value"></param>
    public void Add(string value)
    {
        _nodes.Add(new Node(value));
    }

    /// <summary>
    ///     Add overload for <see cref="Node" />, accepting a value and Children.
    /// </summary>
    /// <param name="hey"></param>
    /// <param name="hes"></param>
    public void Add(string value, GraphMapping children)
    {
        _nodes.Add(new Node(value, children));
    }
}