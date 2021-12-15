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

/// <summary>
/// Unitary tests of <see cref="News"/> class.
/// </summary>
public class NewsControllerTests
    : IClassFixture<TestSetup>
{
    private readonly NewsController _newsController;

    /// <summary>
    /// Main entry of the unitary tests class file.
    /// Dependency Injection container for the whole testing project.
    /// </summary>
    /// <param name="testSetup">Fixure class.</param>
    public NewsControllerTests(TestSetup testSetup)
    {
        var serviceProvider = testSetup.ServiceProvider;
        _newsController = serviceProvider.GetService<NewsController>()!;
    }

    /// <summary>
    /// GET method should return an object of type <see cref="OkObjectResult"/>.
    /// </summary>
    [Fact]
    public async Task GetAsync_WithCount_Should_Return_Ok_Result()
    {
        var count = 1;
        var res = await _newsController.GetAsync(count);

        Assert.IsType<OkObjectResult>(res);
    }

    /// <summary>
    /// GET method should be a type of <see cref="IEnumerable{T}"/>.
    /// </summary>
    [Fact]
    public async Task GetAsync_WithCount_Should_Return_Valid_List_Data()
    {
        var count = 2;
        var res = await _newsController.GetAsync(count);

        Assert.IsAssignableFrom<IEnumerable<News>>((res as OkObjectResult)!.Value);
    }

    /// <summary>
    /// GET method should return the same amount of result as count.
    /// </summary>
    [Fact]
    public async Task GetAsync_WithCount_Should_Return_List_Of_Data_With_Same_Count()
    {
        var count = 3;
        var res = await _newsController.GetAsync(count) as OkObjectResult;

        Assert.Equal(3, (res!.Value as IEnumerable<News>)!.Count());
    }

    /// <summary>
    /// GET method should return a valid non-null result.
    /// </summary>
    [Fact]
    public async Task GetAsync_WithCount_Should_Return_NotNull_Result()
    {
        var count = 1;
        var res = await _newsController.GetAsync(count) as OkObjectResult;

        Assert.NotNull(res!.Value);
    }
}
