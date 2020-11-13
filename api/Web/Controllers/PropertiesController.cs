using Application.Dto.Request;
using Application.Response;
using Application.Dto.Model;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropertiesController : ControllerBase
    {
        private readonly IFacade _facade;

        public PropertiesController(IFacade facade)
        {
            _facade = facade;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(_facade.GetPropertyCatalog());
            }
            catch
            {
                var errorResponse = Builder.InternalServerErrorResponse();
                return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
            }           
        }

        [HttpPost]
        public ActionResult Post(Request<Property> request)
        {
            try
            {
                return Ok(_facade.AddProperty(request));
            }
            catch
            {
                var errorResponse = Builder.InternalServerErrorResponse();
                return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
            }
        }
    }
}
