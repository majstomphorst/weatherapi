using Microsoft.AspNetCore.Mvc;

namespace weatherapi.Controllers;

[ApiController]
[Route("/")]
public class HomeController
{
    [HttpGet]
    public string Get()
    {
        return "Maxim";
    }
}