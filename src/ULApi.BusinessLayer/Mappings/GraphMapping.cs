// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using System;

namespace ULApi.BusinessLayer.Mappings;

public class GraphMapping
{
    private string _value;
    private GraphMapping? _parent;
    private GraphMapping[] _children;

    public GraphMapping(
        string value,
        bool isRoot = false)
    {
        _parent = null;
        _value = isRoot
            ? $"query {value}"
            : value;
        _children = Array.Empty<GraphMapping>();
    }

    public void AddChildren(GraphMapping children)
    {
        var newChildren = new GraphMapping[_children.Length + 1];
        for (var i = 0; i < _children.Length; i++)
        {
            newChildren[i] = _children[i];
        }

        newChildren[_children.Length] = children;
        _children = newChildren;
        children._parent = this;
    }

    private int ParentSize()
        => _parent is not null
            ? _parent.ParentSize() + 1
            : 0;

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
        for (var i = 0; i < _children.Length; i++)
        {
            for (var j = 0; j < ParentSize(); j++)
            {
                s += "    ";
            }
            s += _children[i].RenderQuery();
        }
        if (_children.Length != 0)
        {
            for (var j = 0; j < ParentSize(); ++j)
            {
                s += "    ";
            }
            return s += "}\r\n";
        }
        else
        {
            return s += "\r\n";
        }
    }
}
