using BancaEnLinea.Models;
using BancaEnLinea.BL;
using Microsoft.AspNetCore.Mvc;

namespace BancaEnLinea.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServiciosController : ControllerBase
    {
        private readonly ILogger<ServiciosController> _logger;

        private static readonly string[] MovimientosTest = new[]
        {
            "Mov1", "Mov2", "Mov3",
            "Mov4", "Mov4", "Mov5",
            "Mov6", "Mov7", "Mov8"
        };

        public ServiciosController(ILogger<ServiciosController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{idCuenta}")]
        public Cuenta Get(string idCuenta)
        {
            return CuentaController.getCuenta(idCuenta);
            
        }
    }
}
