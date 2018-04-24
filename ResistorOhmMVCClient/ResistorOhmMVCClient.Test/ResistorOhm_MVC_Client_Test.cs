using ResistorOhmMVCClient.Controllers;
using ResistorOhmMVCClient.DataAccess;
using ResistorOhmMVCClient.DTO.Request;
using ResistorOhmMVCClient.Model;
using System;
using Xunit;

namespace ResistorOhmMVCClient.Test
{
    public class ResistorOhm_MVC_Client_Test
    {
        ResistorModel _Model;
        ResistorOhmRequest _Request;

        public ResistorOhm_MVC_Client_Test()
        {
            StubDataAccess dataAccess = new StubDataAccess();
            _Model = new ResistorModel(dataAccess);
        }
        [Fact]
        public void TestAllBlack()
        {
            _Request = new ResistorOhmRequest()
            {
                testScenario = TestScenarioEnum.validateBlackBlackBlack
            };

            var response = _Model.GetOhmValue(_Request).Result;

            Assert.True(response != null && response.Success == true);
            Assert.True(response.Ohm == 0);
        }

        [Fact]
        public void TestRedOrangeBlack()
        {
            _Request = new ResistorOhmRequest()
            {
                testScenario = TestScenarioEnum.validateRedOrangeBlack
            };

            var response = _Model.GetOhmValue(_Request).Result;

            Assert.True(response != null && response.Success == true);
            Assert.True(response.Ohm == 230);
        }
    }
}
