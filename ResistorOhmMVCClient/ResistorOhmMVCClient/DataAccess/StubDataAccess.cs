using ResistorOhmMVCClient.DTO.Request;
using ResistorOhmMVCClient.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ResistorOhmMVCClient.DataAccess
{
    public class StubDataAccess: IData
    {
        public async Task<ResistorOhmResponse> GetResistorOhmValue(ResistorOhmRequest request)
        {
            ResistorOhmResponse response = new ResistorOhmResponse();
            switch (request.testScenario)
            {
                case TestScenarioEnum.validateBlackBlackBlack:
                    response = new ResistorOhmResponse()
                    {
                      Ohm = 0,
                      Success = true
                    };
                    break;
                case TestScenarioEnum.validateRedOrangeBlack:
                    response = new ResistorOhmResponse()
                    {
                        Ohm = 230,
                        Success = true
                    };
                    break;
                default:
                    break;
            }

            return response;
        }
    }

}
