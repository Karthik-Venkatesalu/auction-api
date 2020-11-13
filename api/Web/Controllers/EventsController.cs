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
    public class EventsController : ControllerBase
    {
        private readonly IFacade _facade;

        public EventsController(IFacade facade)
        {
            _facade = facade;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(_facade.GetEvents());
            }
            catch
            {
                var errorResponse = Builder.InternalServerErrorResponse();
                return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
            }           
        }

        [HttpPost]
        public ActionResult Post(Request<Event> request)
        {
            try
            {
                return StatusCode(StatusCodes.Status201Created,_facade.AddEvent(request));
            }
            catch
            {
                var errorResponse = Builder.InternalServerErrorResponse();
                return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
            }
        }

        [HttpGet("{eventID}")]
        public ActionResult GetEvent(int eventID)
        {
            try
            {
                return Ok(_facade.GetEvent(eventID));
            }
            catch
            {
                var errorResponse = Builder.InternalServerErrorResponse();
                return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
            }
        }

        [HttpGet("{eventID}/biddingrecords")]
        public ActionResult Get(int eventID)
        {
            try
            {
                return Ok(_facade.GetBiddingDataList(eventID));
            }
            catch
            {
                var errorResponse = Builder.InternalServerErrorResponse();
                return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
            }
        }

        [HttpGet("{eventID}/executeauction")]
        public ActionResult PerformAuction(int eventID)
        {
            try
            {
                return Ok(_facade.PerformAuction(eventID));
            }
            catch
            {
                var errorResponse = Builder.InternalServerErrorResponse();
                return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
            }
        }
    }
}
