// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using ULApi.Controllers;
using Xunit;

namespace ULApi.Test.Controllers;
public class NewsControllerTests
    : IClassFixture<TestSetup>
{
    private readonly ServiceProvider _serviceProvider;
    private readonly NewsController _newsController;

    public NewsControllerTests(TestSetup testSetup)
    {
        _serviceProvider = testSetup.ServiceProvider;
        _newsController = _serviceProvider.GetService<NewsController>();
    }

    [Fact]
    public async Task GetAsync_WithCount_Should_Return_Ok_Result()
    {
        var count = 1;
        var res = await _newsController!.GetAsync(count);

        Assert.IsType<OkObjectResult>(res);
    }
}
