using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Moq;
using ULApi.Controllers;
using Xunit;

namespace ULApi.Test.Controllers;
public class NewsControllerTests
{
    private readonly Mock<IConfiguration> _configuration;
    private NewsController _controller;

    /// <summary>
    /// Test initialization, inject mock IConfiguration to News controller.
    /// </summary>
    public NewsControllerTests()
    {
        _configuration = new Mock<IConfiguration>();
        _controller = new NewsController(_configuration.Object);
    }

    [Fact]
    public void GetMethod_WithCount_Should_Return_News()
    {
        var count = 1;
        var response = _controller.Get(count);

        Assert.NotNull(response);
    }

    [Fact]
    public void GetMethod_WithCount_Should_Return_OkResult()
    {
        var count = 1;
        var response = _controller.Get(count);

        Assert.IsType<OkObjectResult>(response.Result);
    }
}
