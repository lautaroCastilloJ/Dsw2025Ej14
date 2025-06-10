using Microsoft.AspNetCore.Mvc;
using Dsw2025Ej14.Api.Domain;

namespace Dsw2025Ej14.Api.Controllers;

[ApiController]
[Route("api/products")]
//[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IPersistencia _persistencia;

    public ProductsController(IPersistencia persistencia)
    {
        _persistencia = persistencia;
    }
    [HttpGet]

    public IActionResult GetProducts()
    {
        return Ok(_persistencia.GetProducts());
    }
}

