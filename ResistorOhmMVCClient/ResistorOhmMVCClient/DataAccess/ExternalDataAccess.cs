using Newtonsoft.Json;
using ResistorOhmMVCClient.DTO.Request;
using ResistorOhmMVCClient.DTO.Response;
using ResistorOhmMVCClient.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ResistorOhmMVCClient.DataAccess
{
    public class ExternalDataAccess: IData
    {
        HttpHelper httpHelper = new HttpHelper();
        HttpClient _Client;
        public ExternalDataAccess()
        {
            _Client = httpHelper.InitializeClient();
        }
        public async Task<ResistorOhmResponse> GetResistorOhmValue(ResistorOhmRequest request)
        {
            ResistorOhmResponse ohmResponse;

            var response =  await _Client.GetAsync("/OhmCalculator/Ohmvalue?bandAColor=" + request.bandAColor.GetHashCode() + "&bandBColor=" + request.bandBColor.GetHashCode() + "&bandCColor=" + request.bandCColor.GetHashCode());
            if (response.IsSuccessStatusCode)
            {
                var strResponse = await response.Content.ReadAsStringAsync();
                ohmResponse = JsonConvert.DeserializeObject<ResistorOhmResponse>(strResponse);
                ohmResponse.Success = true;
            }
            else
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
