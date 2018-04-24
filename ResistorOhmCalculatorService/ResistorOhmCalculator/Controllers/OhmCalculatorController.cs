using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResistorOhmCalculator.BO;
using ResistorOhmCalculator.DTO.Request;
using ResistorOhmCalculator.DTO.Response;
using ResistorOhmCalculator.Model;

namespace ResistorOhmCalculator.Controllers
{
    [Produces("application/json")]
    [Route("OhmCalculator")]
    public class OhmCalculatorController : Controller
    {
        private readonly IOhmValueCalculator _OhmValueCalculator;

        public OhmCalculatorController(IOhmValueCalculator ohmValueCalculator)
        {
            _OhmValueCalculator = ohmValueCalculator;
        }

        // GET: api/OhmCalculator/OhmValue
        [HttpGet("Ohmvalue")]
        public JsonResult GetOhmValue([FromQuery]OhmRequest request)
        {
            var response = new OhmResponse();
            try
            {
                if (request == null)
                {
                    response.Success = false;
                    response.Error = "Bad Request";
                    Json(response);
                }

                var model = new OhmCalculatorModel(_OhmValueCalculator);
                response.Ohm = model.GetOhmValue(request);
                response.Success = true;
            }
            catch
            {
                response.Success = false;
                response.Error = "Service Error";
            }

            return  Json(response);
        }
    }
}
