// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ULApi.Controllers;
using Xunit;

namespace ULApi.Tests;

public class TestControllerTests
{
    [Fact]
    public void GetSampleDatasString_Should_Return_The_Correct_Values()
    {
        var contoller = new TestController();
        var actionResult = contoller.GetSampleDatasString();
        var result = actionResult as OkObjectResult;

        Assert.Equal(new string[]{"hey", "sir"}, result?.Value);
    }

    [Fact]
    public void GetSampleDatasString_Should_Return_Ok_ActionResult()
    {
        var contoller = new TestController();
        var actionResult = contoller.GetSampleDatasString();

        Assert.IsType<OkObjectResult>(actionResult);
    }
}
