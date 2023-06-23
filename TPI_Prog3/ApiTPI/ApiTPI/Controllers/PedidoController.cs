using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.ViewModel;
using Models.DTO;

namespace ApiTPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {


        [HttpGet("GetListadoPedidos")]
        public ActionResult<List<PedidoDTO>> GetListadoPedidos()
        {
            return Ok();
        }

        [HttpGet("GetPedido/{id}")]
        public ActionResult<PedidoDTO> GetPedidoById(int id)
        {
            return Ok();
        }

        [HttpPost("PostPedido")]
        public ActionResult<PedidoDTO> PostPedido([FromBody] PedidoViewModel pedido)
        {
            return Ok();
        }

        [HttpPut("PutPedido/{id}")]
        public ActionResult<PedidoDTO> PutPedido(int id, [FromBody] PedidoViewModel pedido)
        {
            return Ok();
        }

        [HttpDelete("DeletePedido/{id}")]
        public ActionResult<PedidoDTO> DeletePedido(int id)
        {
            return Ok();
        }
    }
}
