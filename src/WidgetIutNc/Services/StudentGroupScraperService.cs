// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using WidgetIutNc.Api.Entities;

namespace WidgetIutNc.Api.Services;
public class StudentGroupScraperService
    : IStudentGroupScraperService
{
    public IEnumerable<StudentGroup> Scrap()
    {
        var baseUri = new Uri(AppSecretsProviderService.API_PARENT_SCRAP_URL);
        var studentGroups = new List<StudentGroup>();
        var web = new HtmlWeb();
        var document = new HtmlDocument();

        //TODO: Fix magic string
        var nodes = document.DocumentNode
                            .Descendants()
                            .Where(node => node.HasClass("x-tree3-el"));

        foreach (var node in nodes)
        {
            Console.WriteLine(node);
        }

        return studentGroups;
    }
}
