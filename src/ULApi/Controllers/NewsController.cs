// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Microsoft.AspNetCore.Mvc;
using ULApi.BusinessLayer;
using ULApi.BusinessLayer.Models;

namespace ULApi.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class NewsController
    : ControllerBase
{
    private readonly GraphBusinessFetcherService<Root> _graphBusinessFetcherService;

    public NewsController(
        GraphBusinessFetcherService<Root> graphBusinessFetcherService)
    {
        _graphBusinessFetcherService = graphBusinessFetcherService;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> GetAsync([FromQuery] int count)
    {
        var res = await _graphBusinessFetcherService.FetchAsync();
        var newsAggregate = res?.Data?.News;

        if (!newsAggregate!.Any())
        {
            return NotFound();
        }

        return Ok(newsAggregate?.Take(count));
    }
}
