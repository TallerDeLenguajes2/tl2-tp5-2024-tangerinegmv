using Tienda;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

[ApiController]
[Route("[controller]")]

public class ProductosController : ControllerBase
{
    private ProductosRepository prodRep;

    public ProductosController()
    {
      prodRep  = new ProductosRepository();
    }

    [HttpGet("ListarProductos")]
    public ActionResult<List<Productos>> ListarProductos()
    {
        return Ok(prodRep.ListarProductos());
    }

   
}