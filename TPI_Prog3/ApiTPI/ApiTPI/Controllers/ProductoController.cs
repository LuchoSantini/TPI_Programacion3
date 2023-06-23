using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using Model.ViewModel;
using Models.DTO;

namespace ApiTPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        
        [HttpGet("GetListadoProductos")]
        public ActionResult<List<ProductoDTO>> GetListadoProductos()
        {
            return new List<ProductoDTO>
            {
                new ProductoDTO {IdProducto=1, Nombre="Remera", PrecioUnitario=2000},
                new ProductoDTO {IdProducto=2, Nombre="Pantalon",  PrecioUnitario=15000}
            };
        }

        [HttpGet("GetProductos/{id}")]
        public ActionResult<ProductoDTO> GetProductoById(int id)
        { 
            // falta agregar la response y el servicio
            return Ok();
        }

        [HttpPost("PostProducto")]
        public ActionResult<ProductoDTO> PostProducto([FromBody] ProductoViewModel producto)
        {
            return Ok(); // agregar logica de la database
        }

        [HttpPut("PutProducto/{id}")]
        public ActionResult<ProductoDTO> PutProducto(int id, [FromBody] ProductoViewModel producto)
        {
            return Ok();
        }


        [HttpDelete("DeleteProducto/{id}")]
        public ActionResult<ProductoDTO> DeleteProducto(int id)
        {
            return Ok();
=======
using Models.DTO;
using Service.Services;

namespace ApiTPI.Controllers
{
    // Si dejamos por defecto [controller] lo que va a hacer es tomar por defecto el nombre de ProductoController sin Controller
    
    [Route("api/[controller]")]
    [ApiController]
    // ControladorProducto/GetListadoProductos, asi se accede al metodo
    // La capa API hace referencia a la capa modelo porque necesito poner el tipo de producto que voy a devolver

    public class ProductoController : ControllerBase
    {
        // readonly es de solo lectura, es decir se puede modificar su valor al momento de declararlas o dentro del constructor.
        // Inyeccion de dependencias.
        // Tomamos productoService y se la asignamos a nuestro servicio _productoService
        // Esto se hace para no instanciar un objeto de tipo producto cada vez que lo necesitemos

        // Se hace con un framework la inyeccion de dependencias

        //private readonly ProductoService _productoService;

        //public ProductoController(ProductoService productoService)
        //{
        //    _productoService = productoService;
        //}

        // Se hace con un framework la inyeccion de dependencias


        private readonly ProductoService _productoService = new ProductoService();

        public ProductoController()
        {
            
        }

        [HttpGet("GetListadoProductos")]
        // Geteamos el listado de productos

        // Creamos instancia de la clase Producto service para acceder al metodo GetListadoProductos
        // Siempre tiene que haber referencia de uno a otro, sino hay referencia circular
        public ActionResult<List<ProductoDTO>> GetProductos()
        {
            //var producto = new ProductoService();
            var response = _productoService.GetListadoProductos();
            
            // Ok = statuscode 200
            return Ok(response);
        }

        [HttpGet("GetProductoById/{id}")]
        public ActionResult<ProductoDTO> GetProductoById(int id)
        {
            //var producto = new ProductoService();
            var response = _productoService.GetProductoById(id);

            return Ok(response);
        }

        [HttpPost("PostProducto")]
        public ActionResult<ProductoDTO> CreateProducto([FromBody] ProductoDTO producto) // Por body (chequear postman) enviamos un producto que va a tener sus atributos.
        {
            //var producto = new ProductoService();
            var response = _productoService.CreateProducto(producto);
            return Ok(response);
        }

        [HttpPut("PutProducto/{id}")] // Recibimos el id por Header y por body el producto que vamos a modificar. Se puede pasar mas de un atributo por header.
        public ActionResult<List<ProductoDTO>> ModifyProducto(int id, [FromBody] ProductoDTO producto) // Por body (chequear postman) enviamos un producto que va a tener sus atributos.
        {
            //var producto = new ProductoService();
            var response = _productoService.ModifyProducto(id, producto);
            return Ok(response);
        }

        [HttpDelete("DeleteProducto/{id}")] // Recibimos el id por Header.
        public ActionResult<ProductoDTO> DeleteProducto(int id)
        {
            //var producto = new ProductoService();
            var response = _productoService.DeleteProducto(id);
            return Ok(response);
>>>>>>> f19194c8d37571abb0338c3f5dbe909531d715f9
        }

    }
}
