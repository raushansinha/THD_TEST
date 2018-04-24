using Newtonsoft.Json;
using ResistorOhmMVCClient.DataAccess;
using ResistorOhmMVCClient.DTO.Request;
using ResistorOhmMVCClient.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ResistorOhmMVCClient.Model
{
    public class ResistorModel
    {
        private readonly IData _DataAccess;


        public ResistorModel(IData dataAccess)
        {
            _DataAccess = dataAccess;
        }

        public async Task<ResistorOhmResponse> GetOhmValue(ResistorOhmRequest request)
        {
            ResistorOhmResponse ohmResponse;
            try
            {
                if (request == null)
                {
                    return new ResistorOhmResponse()
                    {
                        Success = false,
                        Error = "Bad Request"
                    };
                }

                ohmResponse = await _DataAccess.GetResistorOhmValue(request);
            }
            catch
            {
                ohmResponse = new ResistorOhmResponse()
                {
                    Success = false,
                    Error = "Service Error"
                };
            }

            return ohmResponse;
        }
    }
}
