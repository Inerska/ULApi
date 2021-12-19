// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Microsoft.AspNetCore.Mvc;
using ULApi.BusinessLayer.Models;
using ULApi.BusinessLayer.Services;

namespace ULApi.Controllers;

/// <summary>
/// News endpoint controller.
/// </summary>
[ApiController]
[Route("/api/[controller]")]
public class NewsController
    : ControllerBase
{
    private readonly GraphBusinessFetcherService<NewsDataRoot> _graphBusinessFetcherService;

    /// <summary>
    /// Initializes a new instance of the <see cref="NewsController"/> class
    /// </summary>
    /// <param name="graphBusinessFetcherService"></param>
    public NewsController(
        GraphBusinessFetcherService<NewsDataRoot> graphBusinessFetcherService)
    {
        _graphBusinessFetcherService = graphBusinessFetcherService;
    }

    /// <summary>
    /// Asynchronous GET method of the controller.
    /// </summary>
    /// <param name="count">Number of <see cref="News"/> to get.</param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> GetAsync([FromQuery] int count)
    {
        const string query = @"query factuel {
  news {
            title
            image
    date
    description
    link
    __typename
  }
    }
";
        /* var query = new GraphMapping("factuel", true);
        var news = new GraphMapping("news");
        var title = new GraphMapping("title");
        var image = new GraphMapping("image");
        var date = new GraphMapping("date");
        var description = new GraphMapping("description");
        var link = new GraphMapping("link");
        var typeName = new GraphMapping("__typename");

        query.AddChildren(news)
            .AddChildren(title);
        news.AddChildren(image);
        query.AddChildren(date);
        query.AddChildren(description);
        query.AddChildren(link);
        query.AddChildren(typeName);*/

        var res = await _graphBusinessFetcherService.FetchAsync(query);
        var newsAggregate = res.Data?.News;
        var hasAny = newsAggregate?.Any() ?? false;

        if (!hasAny)
        {
            return NotFound();
        }

        return Ok(newsAggregate?.Take(count));
    }
}
