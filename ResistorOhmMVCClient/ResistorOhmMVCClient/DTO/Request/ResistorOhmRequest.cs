using ResistorOhmMVCClient.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResistorOhmMVCClient.DTO.Request
{
    public class ResistorOhmRequest
    {
        public BandColor bandAColor { get; set; }
        public BandColor bandBColor { get; set; }
        public BandColor bandCColor { get; set; }
        public BandColor? bandDColor { get; set; }

        public TestScenarioEnum? testScenario { get; set; }
    }


    public enum TestScenarioEnum
    {
        validateRedWhiteOrange,
        validateRedOrangeBlack,
        validateBlackBlackBlack,
        validateServiceError
    }

}
