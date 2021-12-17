// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

namespace ULApi.BusinessLayer.Mappings;

/// <summary>
/// Represents a Graph object relational mapping.
/// </summary>
public class GraphMapping
{
    public string Value { get; set; }
    public GraphMapping Parent { get; set; }
    public GraphMapping[] Children { get; set; }

    /// <summary>
    /// Initializes a new instance of <see cref="GraphMapping"/> class.
    /// </summary>
    /// <param name="value">Value to set.</param>
    /// <param name="isRoot">Add query keyword before.</param>
    /*public GraphMapping(
        string value,
        bool isRoot = false)
    {
        _parent = null;
        _value = isRoot
            ? $"query {value}"
            : value;
        _children = Array.Empty<GraphMapping>();
    }*/

    /// <summary>
    /// Add a <see cref="GraphMapping"/> children to the current instance.
    /// </summary>
    /// <param name="children"><see cref="GraphMapping"/> instance to add.</param>
    /// <returns>The <see cref="GraphMapping"/> children.</returns>
    public GraphMapping AddChildren(GraphMapping children)
    {
        var newChildren = new GraphMapping[_children.Length + 1];
        for (var i = 0; i < _children.Length; i++)
        {
            newChildren[i] = _children[i];
        }

        newChildren[_children.Length] = children;
        _children = newChildren;
        children._parent = this;

        return children;
    }

    /// <summary>
    /// Add a <see cref="GraphMapping"/> children to the current instance.
    /// </summary>
    /// <param name="value">Value of the children.</param>
    /// <returns>The <see cref="GraphMapping"/> children.</returns>
    public GraphMapping AddChildren(string value)
    {
        var newChildren = new GraphMapping[_children.Length + 1];
        for (var i = 0; i < _children.Length; i++)
        {
            newChildren[i] = _children[i];
        }

        var children = new GraphMapping(value);

        newChildren[_children.Length] = children;
        _children = newChildren;
        children._parent = this;

        return children;
    }

    /// <summary>
    /// The number of parents of the current instance.
    /// </summary>
    /// <returns></returns>
    public int ParentSize()
        => _parent is not null
            ? _parent.ParentSize() + 1
            : 0;

    /// <summary>
    /// Stringify the <see cref="GraphMapping"/> instance.
    /// </summary>
    /// <returns>A string that represents the current instance.</returns>
    public string RenderQuery()
    {
        var s = "";
        if (_children.Length != 0)
        {
            s += _value + "{\r\n";
        }
        else
        {
            s += _value;
        }
        foreach (var t in _children)
        {
            for (var j = 0; j < ParentSize(); j++)
            {
                s += "    ";
            }
            s += t.RenderQuery();
        }

        if (_children.Length == 0)
        {
            return s + "\r\n";
        }

        {
            for (var j = 0; j < ParentSize(); ++j)
            {
                s += "    ";
            }
            return s + "}\r\n";
        }

    }
}
