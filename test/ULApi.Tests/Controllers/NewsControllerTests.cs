// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ULApi.BusinessLayer.Models;
using ULApi.Controllers;
using Xunit;

namespace ULApi.Test.Controllers;
public class NewsControllerTests
    : IClassFixture<TestSetup>
{
    private readonly NewsController _newsController;

    public NewsControllerTests(TestSetup testSetup)
    {
        var serviceProvider = testSetup.ServiceProvider;
        _newsController = serviceProvider!.GetService<NewsController>()!;
    }

    [Fact]
    public async Task GetAsync_WithCount_Should_Return_Ok_Result()
    {
        var count = 1;
        var res = await _newsController!.GetAsync(count);

        Assert.IsType<OkObjectResult>(res);
    }

    [Fact]
    public async Task GetAsync_WithCount_Should_Return_Valid_List_Data()
    {
        var count = 2;
        var res = await _newsController!.GetAsync(count);

        Assert.IsAssignableFrom<IEnumerable<News>>((res as OkObjectResult)!.Value);
    }

    [Fact]
    public async Task GetAsync_WithCount_Should_Return_List_Of_Data_With_Same_Count()
    {
        var count = 3;
        var res = await _newsController!.GetAsync(count) as OkObjectResult;

        Assert.Equal(3, (res!.Value as IEnumerable<News>)!.Count());
    }

    [Fact]
    public async Task GetAsync_WithCount_Should_Return_NotNull_Result()
    {
        var count = 1;
        var res = await _newsController!.GetAsync(count) as OkObjectResult;

        Assert.NotNull(res!.Value);
    }
}
