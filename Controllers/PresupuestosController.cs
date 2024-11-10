using Tienda;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

[ApiController]
[Route("[controller]")]

public class PresupuestosController : ControllerBase
{
    private PresupuestosRepository PresupRep;
    public PresupuestosController()
    {
        PresupRep = new PresupuestosRepository();
    }

    [HttpPost("CrearNuevoPresupuesto")]
    public ActionResult CrearNuevoPresupuesto([FromForm]Presupuestos nuevo)
    {
        PresupRep.CrearNuevoPesupuesto(nuevo);
        return Ok();
    
    }

    [HttpGet("ListarPresupuestos")]
    public ActionResult<List<Presupuestos>> ListarPresupuestos()
    {
        return Ok(PresupRep.ListarPresupuestos());
    }
}