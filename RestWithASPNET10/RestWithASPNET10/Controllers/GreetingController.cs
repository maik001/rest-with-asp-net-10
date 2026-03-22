using Microsoft.AspNetCore.Mvc;
using RestWithASPNET10.Model;

namespace RestWithASPNET10.Controllers;

[ApiController]
[Route("[controller]")]
public class GreetingController : ControllerBase
{
    private static long _counter = 0;
    private static readonly string _template = "Olá {0}";
    
    [HttpGet]
    public Greeting Get([FromQuery] string name = "Mundo")
    {
        var id = Interlocked.Increment(ref _counter);
        var message = string.Format(_template, name);
        return new Greeting(1, message);
    }
}