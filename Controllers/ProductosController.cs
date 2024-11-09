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

    [HttpPost("CrearProducto")]
    public ActionResult CrearProducto([FromForm]Productos producto)
    {
      prodRep.CrearNuevo(producto);
      return Ok();
    }

    [HttpPut("ModificarProducto/{id}")]
    public ActionResult ModificarProducto(int id, [FromForm]Productos prod)
    {
      prodRep.ModificarProducto(id, prod);
      return Ok();
    }
   
}