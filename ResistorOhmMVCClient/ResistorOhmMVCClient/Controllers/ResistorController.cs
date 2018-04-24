using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResistorOhmMVCClient.DataAccess;
using ResistorOhmMVCClient.DTO.Request;
using ResistorOhmMVCClient.DTO.Response;
using ResistorOhmMVCClient.Helper;
using ResistorOhmMVCClient.Model;
using ResistorOhmMVCClient.ViewModel;

namespace ResistorOhmMVCClient.Controllers
{
    public class ResistorController : Controller
    {
        private readonly IData _DataAccess;


        public ResistorController(IData dataAccess)
        {
            _DataAccess = dataAccess;
        }


        // GET: Resistor
        public async Task<ActionResult> Index(ResistorViewModel viewModel)
        {
            ResistorOhmRequest request;
            ResistorOhmResponse respone;
            if (viewModel.btnResistorOhm != null)
            {
                request = new ResistorOhmRequest()
                {
                    bandAColor = viewModel.bandAColor,
                    bandBColor = viewModel.bandBColor,
                    bandCColor = viewModel.bandCColor
                };

                var model = new ResistorModel(_DataAccess);

                respone = await model.GetOhmValue(request);

                if(respone.Success)
                {
                    viewModel.Ohm = respone.Ohm.ToString();
                }
                else
                {
                    ViewBag.Error = respone.Error;
                }
                 
            }
            return View(viewModel);
        }

    }
}