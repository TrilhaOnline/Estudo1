using Newtonsoft.Json.Linq;
using Swashbuckle.Swagger.Annotations;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using TrilhaOnline.Domain.Entity.Car;
using TrilhaOnline.Services.BusinessService.Car;

namespace TrilhaOnline.Application.API.Controllers
{
    /// <summary>
    /// Classe responsável pelo controle das APIs de Carros da Trilhar Car
    /// </summary>
    [RoutePrefix("api/trilharent")]
    public class TrilhaRentController : ApiController
    {
        private CarBusinessService _businessCar;

        /// <summary>
        /// Método construtor
        /// </summary>
        public TrilhaRentController()
        {
            _businessCar = new CarBusinessService();
        }
        /// <summary>
        /// API responsável pelo retorno de carros da Trilha Car
        /// </summary>
        /// <returns></returns>
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(CarResponseDTO))]
        [SwaggerResponse(HttpStatusCode.NotFound, "NotFound")]
        [SwaggerResponse(HttpStatusCode.GatewayTimeout, "GatewayTimeout")]
        [SwaggerResponse(HttpStatusCode.BadGateway, "BadGateway")]
        [SwaggerResponse(HttpStatusCode.BadRequest, "BadRequest")]
        [SwaggerResponse(HttpStatusCode.InternalServerError, "InternalServerError")]
        [ResponseType(typeof(CarResponseDTO))]
        [HttpGet]
        [Route("getallcars")]
        public IHttpActionResult GetAllCars()
        {
            return Ok(JObject.FromObject(_businessCar.GetAllCars()));
        }

        /// <summary>
        /// API responsável pelo retorno de carro da Trilha Car por Id
        /// </summary>
        /// <returns></returns>
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(CarResponseDTO))]
        [SwaggerResponse(HttpStatusCode.NotFound, "NotFound")]
        [SwaggerResponse(HttpStatusCode.GatewayTimeout, "GatewayTimeout")]
        [SwaggerResponse(HttpStatusCode.BadGateway, "BadGateway")]
        [SwaggerResponse(HttpStatusCode.BadRequest, "BadRequest")]
        [SwaggerResponse(HttpStatusCode.InternalServerError, "InternalServerError")]
        [ResponseType(typeof(CarResponseDTO))]
        [HttpGet]
        [Route("getcarbyid")]
        public IHttpActionResult GetCarById([FromBody] int idCar)
        {
            return Ok(JObject.FromObject(new CarResponseDTO()));
        }

        /// <summary>
        /// API responsável pela inclusão de carros da Trilha Car
        /// </summary>
        /// <returns></returns>
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(bool))]
        [SwaggerResponse(HttpStatusCode.NotFound, "NotFound")]
        [SwaggerResponse(HttpStatusCode.GatewayTimeout, "GatewayTimeout")]
        [SwaggerResponse(HttpStatusCode.BadGateway, "BadGateway")]
        [SwaggerResponse(HttpStatusCode.BadRequest, "BadRequest")]
        [SwaggerResponse(HttpStatusCode.InternalServerError, "InternalServerError")]
        [ResponseType(typeof(bool))]
        [HttpPost]
        [Route("insertcar")]
        public IHttpActionResult InsertCar([FromBody] CarRequestDTO data)
        {
            return Ok(_businessCar.InsertCar(data));
        }

        /// <summary>
        /// API responsável pela alteração de carros da Trilha Car
        /// </summary>
        /// <returns></returns>
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(CarResponseDTO))]
        [SwaggerResponse(HttpStatusCode.NotFound, "NotFound")]
        [SwaggerResponse(HttpStatusCode.GatewayTimeout, "GatewayTimeout")]
        [SwaggerResponse(HttpStatusCode.BadGateway, "BadGateway")]
        [SwaggerResponse(HttpStatusCode.BadRequest, "BadRequest")]
        [SwaggerResponse(HttpStatusCode.InternalServerError, "InternalServerError")]
        [ResponseType(typeof(CarResponseDTO))]
        [HttpPut]
        [Route("updatecar")]
        public IHttpActionResult UpdateCar([FromBody] CarRequestDTO data)
        {
            return Ok(JObject.FromObject(new CarResponseDTO()));
        }

        /// <summary>
        /// API responsável pela exclusão de carros da Trilha Car
        /// </summary>
        /// <returns></returns>
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(CarResponseDTO))]
        [SwaggerResponse(HttpStatusCode.NotFound, "NotFound")]
        [SwaggerResponse(HttpStatusCode.GatewayTimeout, "GatewayTimeout")]
        [SwaggerResponse(HttpStatusCode.BadGateway, "BadGateway")]
        [SwaggerResponse(HttpStatusCode.BadRequest, "BadRequest")]
        [SwaggerResponse(HttpStatusCode.InternalServerError, "InternalServerError")]
        [ResponseType(typeof(CarResponseDTO))]
        [HttpPut]
        [Route("deletecar")]
        public IHttpActionResult DeleteCar([FromBody] int idCar)
        {
            return Ok(JObject.FromObject(new CarResponseDTO()));
        }
    }
}
