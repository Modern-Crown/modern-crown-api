using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Modern.Crown.Domain.Catalog;

namespace Modern.Crown.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
    [HttpGet]
    public IActionResult GetItems()
    {
        return Ok("hello world.");
    }
    }
    
}