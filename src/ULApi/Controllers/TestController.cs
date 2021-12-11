using Microsoft.AspNetCore.Mvc;

namespace ULApi.Controllers;

[Route("/api/[controller]")]
[ApiController]
public class TestController
    : Controller
{
    [HttpGet]
    public string[] GetSampleDatasString()
    {
        return new string[] { "hey", "sir" };
    }
}
