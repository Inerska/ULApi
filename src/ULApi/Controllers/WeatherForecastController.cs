// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Microsoft.AspNetCore.Mvc;
using ULApi.Services;
using ULApi.Services.Models;

namespace ULApi.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class WeatherForecastController 
    : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IConfiguration _configuration;

    public WeatherForecastController(
        ILogger<WeatherForecastController> logger,
        IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    [HttpGet]
    public async Task<Root> Get()
    {
        var service = new GraphBusinessFetcherService<Root>(_configuration);
        var res = await service.FetchAsync();

        return res;
    }
}
