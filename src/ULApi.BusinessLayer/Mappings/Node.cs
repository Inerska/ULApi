//  Copyright (c) Alexis Chân Gridel. All Rights Reserved.
//  Licensed under the GNU General Public License v3.0.
//  See the LICENSE file in the project root for more information.

namespace ULApi.BusinessLayer.Mappings;

/// <summary>
///     Represents a Node that's used to being part of a <see cref="GraphMapping" />.
/// </summary>
public class Node
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Node" /> class.
    /// </summary>
    /// <param name="value">Value of the node.</param>
    public Node(string value)
    {
        Value = value;
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="Node" /> class.
    /// </summary>
    /// <param name="value">Value of the node.</param>
    /// <param name="children">Children of the node.</param>
    public Node(string value, GraphMapping children)
    {
        Value = value;
        Children = children;
    }

    /// <summary>
    ///     Value of the current node.
    /// </summary>
    private string Value { get; }

    /// <summary>
    ///     Parent of the current node.
    /// </summary>
    private Node? Parent { get; set; }

    /// <summary>
    ///     Children of the current node.
    /// </summary>
    private GraphMapping? Children { get; }

    /// <summary>
    ///     Get the root node.
    /// </summary>
    public Node Root => Parent is null
        ? this
        : Parent.Root;
}