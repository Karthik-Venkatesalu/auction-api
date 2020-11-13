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
    public class BiddingRecordsController : ControllerBase
    {
        private readonly IFacade _facade;

        public BiddingRecordsController(IFacade facade)
        {
            _facade = facade;
        }

        [HttpPost]
        public ActionResult Post(Request<BiddingRecord> request)
        {
            try
            {
                return StatusCode(StatusCodes.Status201Created, _facade.AddBiddingRecord(request));
            }
            catch
            {
                var errorResponse = Builder.InternalServerErrorResponse();
                return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
            }
        }
    }
}
