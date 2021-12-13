// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Microsoft.AspNetCore.Mvc;
using ULApi.Services;
using ULApi.Services.Models;

namespace ULApi.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class NewsController
    : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly GraphBusinessFetcherService<Root> _graphBusinessFetcherService;

    public NewsController(
        IConfiguration configuration,
        GraphBusinessFetcherService<Root> graphBusinessFetcherService)
    {
        _configuration = configuration;
        _graphBusinessFetcherService = graphBusinessFetcherService;
    }

    [HttpGet]
    public async Task<ActionResult> Get([FromQuery] int count)
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
